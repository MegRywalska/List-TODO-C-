using ListTODO.Class;
using ListTODO.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTODO
{
    public partial class MainForm : Form
    {
        private UserManager userManager;
        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager();

            ShowLogin();
        }

        public void ShowLogin()
        {
            Controls.Clear();
            Controls.Add(new Login(this));
        }

        public void ShowTasks(User user)
        {
            Controls.Clear();
            Controls.Add(new Tasks(this, user));
        }

        public void ShowRegister()
        {
            Controls.Clear();
            Controls.Add(new Register(this));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
