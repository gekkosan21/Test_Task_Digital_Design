using System;
using System.Windows.Forms;

namespace Test_Task_Digital_Design
{
    public partial class Signup_form : Form
    {
        DataBase dataBase = new DataBase();
        public Signup_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Signup_form_load(object sender, EventArgs e)
        {
            Password_txtbox.PasswordChar = '*';
            Username_txtbox.MaxLength = 50;
            Password_txtbox.MaxLength = 50;
        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            var loginNewUser = Username_txtbox.Text;
            var PasswordNewUser = Password_txtbox.Text;

            foreach (var user in dataBase.model.Accounts)
            {
                if (loginNewUser == user.login_user)
                {
                    MessageBox.Show("Something went wrong...", "Oops");
                    return;
                }
            }
            dataBase.add_user(loginNewUser, PasswordNewUser);
            dataBase.model.SaveChanges();
            MessageBox.Show("Account created successfully!", "Success!");
            
            this.Hide();


        }

    }
}
