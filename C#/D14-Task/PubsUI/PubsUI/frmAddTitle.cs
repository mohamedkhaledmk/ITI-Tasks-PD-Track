using BLL.EntityManagers;
using System;
using System.Windows.Forms;

namespace PubsUI
{
    public partial class frmAddTitle : Form
    {
        public bool Added { get; private set; } = false;

        public frmAddTitle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleID.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("All fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = TitleManager.AddTitle(txtTitleID.Text.Trim(), txtTitle.Text.Trim(), txtType.Text.Trim());
            if (!result)
            {
                MessageBox.Show("Failed to add title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Added = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
