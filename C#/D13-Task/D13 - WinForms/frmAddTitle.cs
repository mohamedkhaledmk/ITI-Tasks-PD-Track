using System;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmAddTitle : Form
    {
        public string TitleId { get; private set; }
        public string TitleName { get; private set; }
        public string TitleType { get; private set; }

        public frmAddTitle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleId.Text) || 
                string.IsNullOrWhiteSpace(txtTitle.Text) || 
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TitleId = txtTitleId.Text;
            TitleName = txtTitle.Text;
            TitleType = txtType.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
