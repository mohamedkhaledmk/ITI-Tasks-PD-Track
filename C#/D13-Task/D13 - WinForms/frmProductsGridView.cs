using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDaPrds;
        DataTable dtProducts;
        SqlCommand sqlcmdSelectAllCategories;
        SqlDataAdapter sqlDataCategories;
        DataTable dtCategories;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlDaPrds.Fill(dtProducts); ///Open sqlCN , Execute Select Command , fill Data Table with Data , Close Connection
            sqlDataCategories.Fill(dtCategories);
            grdViewPrds.DataSource = dtProducts; //Simple Data Binding 

            DataGridViewComboBoxColumn CatCol = new();

            CatCol.DataSource = dtCategories;
            CatCol.DisplayMember = "pub_name";
            CatCol.ValueMember = "pubId";
            CatCol.DataPropertyName = "pub_id";
            CatCol.HeaderText = "publisher";

            grdViewPrds.Columns.Add(CatCol);

            grdViewPrds.Columns["pub_id"]?.Visible = false;
            grdViewPrds.Columns["title_id"]?.ReadOnly = true;

        }
        private void frmProductsGridView_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
            sqlCmd = new("Select * from titles", sqlCn);
            dtProducts = new();
            sqlDaPrds = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDaPrds);

            sqlDaPrds.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaPrds.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaPrds.DeleteCommand = commandBuilder.GetDeleteCommand();

            sqlcmdSelectAllCategories=new("Select pub_id as pubId,pub_name from publishers",sqlCn);
            sqlDataCategories = new SqlDataAdapter(sqlcmdSelectAllCategories);
            dtCategories = new();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtProducts.Rows)
            {
                Trace.WriteLine(row.RowState);
            }
            grdViewPrds.EndEdit();
            int R = sqlDaPrds.Update(dtProducts); ///Commit Changes into Database From dtProducts
            Trace.WriteLine($"{R} Rows Affected");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTitle addForm = new frmAddTitle();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                DataRow newRow = dtProducts.NewRow();
                newRow["title_id"] = addForm.TitleId;
                newRow["title"] = addForm.TitleName;
                newRow["type"] = addForm.TitleType;
                dtProducts.Rows.Add(newRow);

                try
                {
                    sqlDaPrds.Update(dtProducts);
                    MessageBox.Show("Title added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding title: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
         {
             if (grdViewPrds.CurrentRow != null)
             {
                 string selectedTitleId = grdViewPrds.CurrentRow.Cells["title_id"].Value.ToString();
                 frmProductsDetailedView editForm = new frmProductsDetailedView(selectedTitleId);
                 editForm.ShowDialog();
                 
                 // Refresh the grid data after editing
                 dtProducts.Clear();
                 sqlDaPrds.Fill(dtProducts);
             }
            else
            {
                MessageBox.Show("Please select a title to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
         {
             if (grdViewPrds.CurrentRow != null)
             {
                 if (MessageBox.Show("Are you sure you want to delete this title?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                     DataRowView drv = (DataRowView)grdViewPrds.CurrentRow.DataBoundItem;
                     drv.Row.Delete();
                     try
                     {
                         sqlDaPrds.Update(dtProducts);
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show($"Error deleting title: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         dtProducts.RejectChanges();
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Please select a title to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }
    }
}
