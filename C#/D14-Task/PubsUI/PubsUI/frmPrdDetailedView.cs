using BLL.Entities;
using BLL.EntityManagers;
using System;
using System.Windows.Forms;

namespace PubsUI
{
    public partial class frmPrdDetailedView : Form
    {
        private readonly Title _title;
        public bool Saved { get; private set; } = false;

        public frmPrdDetailedView(Title title)
        {
            InitializeComponent();
            _title = title;
        }

        public frmPrdDetailedView()
        {
        }

        private void frmPrdDetailedView_Load(object sender, EventArgs e)
        {
            lblProductID.Text = _title.TitleID;
            txtProductName.Text = _title.TitleName;
            numUnitPrice.Value = _title.Price ?? 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = TitleManager.UpdateTitlePrice(_title.TitleID, numUnitPrice.Value);
            if (!result)
            {
                MessageBox.Show("Failed to update price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Saved = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
