using ListTODO.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTODO.Control
{
    public partial class Login : UserControl
    {
        private MainForm _mainFrom;

        public Login(MainForm mainFrom)
        {
            InitializeComponent();

            _mainFrom = mainFrom;
            Dock = DockStyle.Fill;
        }

        private void SignInButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text) &&
                string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                lblValidationLogin.Visible = true;
                lblValidationLogin.Text = "Login and password can not be blanck.";
            }
            else
            {
                User user = _mainFrom.UserManager.FindUser(tbLogin.Text, tbPassword.Text);

                if (user != null)
                {
                    lblValidationLogin.Visible = true;
                    lblValidationLogin.Text = "Incorrect login or password";
                }
                else
                {
                    _mainFrom.ShowTasks();
                }
            }
        }


        private void SignUpButtonClick(object sender, EventArgs e) => _mainFrom.ShowRegister();
    }
}
