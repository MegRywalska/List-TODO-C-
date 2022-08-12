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
        private MainForm mainFrom;

        public Login(MainForm mainFrom)
        {
            InitializeComponent();

            this.mainFrom = mainFrom;
            Dock = DockStyle.Fill;
        }

        private void SingInButtonClick(object sender, EventArgs e)
        {
            mainFrom.ShowTasks();
        }

        private void SingUpButtonClick(object sender, EventArgs e)
        {
            mainFrom.ShowRegister();
        }
    }
}
