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
            int R= sqlDaPrds.Update(dtProducts); ///Commit Changes into Database From dtProducts
            Trace.WriteLine($"{R} Rows Affected");
        }
    }
}
