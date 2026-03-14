using BLL.EntityLists;
using BLL.EntityManagers;
using System;
using System.Windows.Forms;

namespace PubsUI
{
    public partial class frmPrdsGridView : Form
    {
        public frmPrdsGridView()
        {
            InitializeComponent();
        }

        TitleList Titles;
        BindingSource TitleBindingSource;

        private void LoadTitles()
        {
            Titles = TitleManager.SelectALLTitles();
            TitleBindingSource = new BindingSource(Titles, "");
            grdViewPrds.DataSource = TitleBindingSource;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTitles();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TitleBindingSource == null) return;

            TitleBindingSource.EndEdit();

            bool anyFailed = false;
            foreach (var title in Titles)
            {
                if (title.State == BLL.Entities.EntitySate.Modified)
                {
                    if (!TitleManager.UpdateTitlePrice(title.TitleID, title.Price ?? 0))
                        anyFailed = true;
                    else
                        title.State = BLL.Entities.EntitySate.UnChanged;
                }
            }

            if (anyFailed)
                MessageBox.Show("One or more updates failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadTitles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddTitle();
            frm.ShowDialog(this);
            if (frm.Added)
                LoadTitles();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TitleBindingSource?.Current is not BLL.Entities.Title selected) return;

            var frm = new frmPrdDetailedView(selected);
            frm.ShowDialog(this);
            if (frm.Saved)
                LoadTitles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TitleBindingSource?.Current is not BLL.Entities.Title selected) return;

            var confirm = MessageBox.Show($"Delete '{selected.TitleName}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool result = TitleManager.DeleteTitle(selected.TitleID);
            if (!result)
                MessageBox.Show("Failed to delete title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                LoadTitles();
        }
    }
}
