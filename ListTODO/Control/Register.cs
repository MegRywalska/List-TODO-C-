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
    public partial class Register : UserControl
    {
        private MainForm mainForm;
        public Register(MainForm mainForm)
        {
           InitializeComponent();

            this.mainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void SignInButtonClick(object sender, EventArgs e) => mainForm.ShowLogin();

        private void SignUpButtonClick(object sender, EventArgs e) => mainForm.ShowTasks();
    }
}
