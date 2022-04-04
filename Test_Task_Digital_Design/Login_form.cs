using System;
using System.Windows.Forms;

namespace Test_Task_Digital_Design
{
    public partial class Login_form : Form
    {
        DataBase dataBase = new DataBase();
        public Login_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_form_load(object sender, EventArgs e)
        {
            Password_txtbox.PasswordChar = '*';
            Username_txtbox.MaxLength = 50;
            Password_txtbox.MaxLength = 50;
        }

        private void Log_in_btn_Click(object sender, EventArgs e)
        {
            var loginUser = Username_txtbox.Text;
            var PasswordUser = Password_txtbox.Text;
            bool Check = false;
            foreach (var user in dataBase.model.Accounts)
            {
               
                if (loginUser == user.login_user && PasswordUser == user.password_user)
                {
                    Check = true;
                    MessageBox.Show("You have successfully logged in!", "Success!");
                    break;
                }
            }
            if (Check == true)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Something went wrong...", "Oops");
        }
        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            Signup_form frm_signup = new Signup_form();
            frm_signup.ShowDialog();
            //this.Hide();
        }
    }
}
