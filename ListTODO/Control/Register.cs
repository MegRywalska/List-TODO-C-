using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListTODO.Class;

namespace ListTODO.Control
{
    public partial class Register : UserControl
    {
        private MainForm _mainForm;

        public Register(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;


            Dock = DockStyle.Fill;
        }



        private void SignInButtonClick(object sender, EventArgs e) => _mainForm.ShowLogin();

        private void SignUpButtonClick(object sender, EventArgs e)
        {
            if (!_mainForm.UserManager.UserExists(tbLogin.Text))
            {
                User user = new User(Guid.NewGuid(), tbName.Text, tbLogin.Text, tbPassword.Text);
                _mainForm.UserManager.AddUser(user);

                _mainForm.ShowTasks(user);

            }

        }
    }
}
