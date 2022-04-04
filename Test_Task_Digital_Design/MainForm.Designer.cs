namespace Test_Task_Digital_Design
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.Path_txtbox = new System.Windows.Forms.TextBox();
            this.bChoose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bDeleteFile = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(599, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.Path_txtbox);
            this.groupBox1.Controls.Add(this.bChoose);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select file";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(15, 163);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(252, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add to DB";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // Path_txtbox
            // 
            this.Path_txtbox.Location = new System.Drawing.Point(15, 37);
            this.Path_txtbox.Multiline = true;
            this.Path_txtbox.Name = "Path_txtbox";
            this.Path_txtbox.ReadOnly = true;
            this.Path_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Path_txtbox.Size = new System.Drawing.Size(252, 52);
            this.Path_txtbox.TabIndex = 1;
            // 
            // bChoose
            // 
            this.bChoose.Location = new System.Drawing.Point(169, 116);
            this.bChoose.Name = "bChoose";
            this.bChoose.Size = new System.Drawing.Size(98, 23);
            this.bChoose.TabIndex = 0;
            this.bChoose.Text = "Select";
            this.bChoose.UseVisualStyleBackColor = true;
            this.bChoose.Click += new System.EventHandler(this.bChoose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available files";
            // 
            // bDeleteFile
            // 
            this.bDeleteFile.Location = new System.Drawing.Point(793, 234);
            this.bDeleteFile.Name = "bDeleteFile";
            this.bDeleteFile.Size = new System.Drawing.Size(141, 23);
            this.bDeleteFile.TabIndex = 3;
            this.bDeleteFile.Text = "Delete file";
            this.bDeleteFile.UseVisualStyleBackColor = true;
            this.bDeleteFile.Click += new System.EventHandler(this.bDeleteFile_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(332, 234);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 4;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDownload
            // 
            this.bDownload.Location = new System.Drawing.Point(493, 234);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(85, 23);
            this.bDownload.TabIndex = 5;
            this.bDownload.Text = "Download";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 270);
            this.Controls.Add(this.bDownload);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDeleteFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Test_Task_Digital_Design";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Path_txtbox;
        private System.Windows.Forms.Button bChoose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bDeleteFile;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDownload;
    }
}