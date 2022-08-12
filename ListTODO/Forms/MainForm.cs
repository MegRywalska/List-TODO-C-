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
        public MainForm()
        {
            InitializeComponent();

            ShowLogin();
        }

        public void ShowLogin()
        {
            Controls.Clear();
            Controls.Add(new Login(this));
        }

        public void ShowTasks()
        {
            Controls.Clear();
            Controls.Add(new Tasks(this));
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
