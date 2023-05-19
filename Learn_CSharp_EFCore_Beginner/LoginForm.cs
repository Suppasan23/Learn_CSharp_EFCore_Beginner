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

    }
}
