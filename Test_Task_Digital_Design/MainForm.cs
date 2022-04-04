using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Test_Task_Digital_Design
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        
        string _path = "";
        string _name = "";
        int _fileSize = 0;
        private const int port = 8888;
        private const string server = "127.0.0.1";
        string _temp = Path.GetTempPath();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CreateColumns();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns["id"].Width = 30;
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns["name"].Width = 100;
            dataGridView1.Columns.Add("path", "Path");
            dataGridView1.Columns["path"].Width = 300;
            dataGridView1.Columns.Add("size", "File size (bytes)");
            dataGridView1.Columns["size"].Width = 200;

            RefreshGrid();
            //dataGridView1.DataSource = dataBase.
        }

        void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var row in dataBase.model.Files)
            {
                dataGridView1.Rows.Add(new object[] { row.file_id, row.file_name, row.file_path, row.file_size });
            }
        }
        private void bChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Path_txtbox.Text = ofd.FileName;
                    _path = ofd.FileName;
                    _name = ofd.SafeFileName;
                    _fileSize =(int) new System.IO.FileInfo(_path).Length;
                }
            }

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(_path) && !string.IsNullOrEmpty(_name) && _fileSize > 0)
            {
                SendData();
                //if (dataBase.add_file(_name, _fileSize, _path))
                //{
                //    MessageBox.Show("You have successfully added file!", "Success!");
                //    RefreshGrid();
                //}
            }
                
        }

        enum eOperType 
        { 
            AddFile=1,
            DeleteFile,
            DownloadFile

        }
        void SendData()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                byte[] nameBuffer = new byte[256];
                byte operType = (byte)((int)eOperType.AddFile);
                //nameBytes= Encoding.UTF8.GetBytes(_name);
                for (int i = 0; i < nameBuffer.Length; i++)
                {
                    nameBuffer[i] = (byte)'\0';
                }
                nameBuffer[0] = operType;
                byte[] bytesName= Encoding.UTF8.GetBytes(_name);
                for (int i = 0; i < bytesName.Length; i++)
                {
                    nameBuffer[i+1] = bytesName[i];
                }

                byte[] data = File.ReadAllBytes(_path);
                byte[] allInfo = nameBuffer.Concat(data).ToArray();
                //StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();
                
                stream.Write(allInfo, 0, allInfo.Length);

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
        }
        void DeleteFile()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                byte[] nameBuffer = new byte[256];
                byte operType = (byte)((int)eOperType.DeleteFile);
                for (int i = 0; i < nameBuffer.Length; i++)
                {
                    nameBuffer[i] = (byte)'\0';
                }
                nameBuffer[0] = operType;
                byte[] bytesName = BitConverter.GetBytes((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < bytesName.Length; i++)
                {
                    nameBuffer[i + 1] = bytesName[i];
                }

                NetworkStream stream = client.GetStream();

                stream.Write(nameBuffer, 0, nameBuffer.Length);

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

        }
        void DownloadFile()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                byte[] nameBuffer = new byte[256];
                byte operType = (byte)((int)eOperType.DownloadFile);
                for (int i = 0; i < nameBuffer.Length; i++)
                {
                    nameBuffer[i] = (byte)'\0';
                }
                nameBuffer[0] = operType;
                byte[] bytesName = BitConverter.GetBytes( (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < bytesName.Length; i++)
                {
                    nameBuffer[i + 1] = bytesName[i];
                }

                //byte[] data = File.ReadAllBytes(_path);
                //byte[] allInfo = nameBuffer.Concat(data).ToArray();
                //StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                stream.Write(nameBuffer, 0, nameBuffer.Length);
                List<byte> allBytes = new List<byte>();
                byte[] data = new byte[256];
                int bytes = 0;
                bool first = true;
                string name = "";
                do
                {
                    if (first)
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        name = Encoding.UTF8.GetString(data).Replace("\0", String.Empty);
                        first = false;
                    }
                    else
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        allBytes.AddRange(data);
                    }


                }
                while (stream.DataAvailable);

                File.WriteAllBytes(_temp+name, allBytes.ToArray());
                Process.Start(_temp + name);
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
        }
        private void bDeleteFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                DeleteFile();
                //if (dataBase.remove_file(id))
                //{
                //    MessageBox.Show("You have successfully deleted file!", "Success!");
                //    RefreshGrid();
                //}
                
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void bDownload_Click(object sender, EventArgs e)
        {
            DownloadFile();
        }
    }
}
