using ListTODO.Class;
using System;
using System.Windows.Forms;

namespace ListTODO.Control
{
    public partial class Tasks : UserControl
    {
        private MainForm _mainForm;
        private User _userSignedUp;
        public Tasks(MainForm mainForm, User user)
        {
            InitializeComponent();

            _mainForm = mainForm;
            Dock = DockStyle.Fill;

            _userSignedUp = user;

        }
        private void SignOutButtonClick(object sender, EventArgs e) => _mainForm.ShowLogin();

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
