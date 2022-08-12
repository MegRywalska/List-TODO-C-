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
    public partial class Tasks : UserControl
    {
        private MainForm mainForm;
        public Tasks(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            Dock = DockStyle.Fill;
        }
        private void SingOutButtonClick(object sender, EventArgs e)
        {
            mainForm.ShowLogin();
        }

        private void AddButtomClick()
        {

        }

        private void EditButtonClick()
        {

        }

        private void DeleteButtomClick()
        {

        }
      
    }
}
