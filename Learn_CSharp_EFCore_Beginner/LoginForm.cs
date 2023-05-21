using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_CSharp_EFCore_Beginner
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ControlBox = false;
            AcceptButton = LogInButton;
            PasswordTextBox.UseSystemPasswordChar = true;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();

        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowHidePoasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowHidePoasswordCheckBox.Checked;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string caption = "User Login";
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            if (string.IsNullOrEmpty(UserNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input username.", caption, btn, ico);
                UserNameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PasswordTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input password.", caption, btn, ico);
                PasswordTextBox.Focus();
                return;
            }

            var strUserName = UserNameTextBox.Text.Trim();
            var strPassword = PasswordTextBox.Text.Trim();

            using (var db = new Models.Db.LearnCsharpEfcoreBeginnerDbContext())
            {
                var loginData = from u in db.Users
                                where u.UserName.Trim().Equals(strUserName)
                                && u.Password.Trim().Equals(strPassword)
                                select new
                                {
                                    UID = u.UserName,
                                    User = u.UserName,
                                    FULL = u.FullName,

                                };
                if (loginData.Count() > 0)
                {
                    center.CurrentUserID = loginData.FirstOrDefault().UID;
                    center.CurrentUserName = loginData.FirstOrDefault().User;
                    center.CurrentFullName = loginData.FirstOrDefault().FULL;

                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();

                    ShowHidePoasswordCheckBox.Checked = false;

                    this.Hide();

                    CustomerForm f = new CustomerForm();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", caption, btn, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void LogInButton_Enter(object sender, EventArgs e)
        {
            LogInButton.PerformClick();
        }
    }
}