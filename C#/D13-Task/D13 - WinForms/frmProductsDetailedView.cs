using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmProductsDetailedView : Form
    {
        private string _initialTitleId;

        public frmProductsDetailedView()
        {
            InitializeComponent();
        }

        public frmProductsDetailedView(string selectedTitleId) : this()
        {
            _initialTitleId = selectedTitleId;
        }

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDaPrds;
        DataTable dtPrds = new();

        BindingSource prdBindingSource;
        BindingNavigator BindingNavigator;
        private void frmProductsDetailedView_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
            sqlCmd = new("Select * from titles", sqlCn);

            sqlDaPrds = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDaPrds);

            sqlDaPrds.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaPrds.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaPrds.DeleteCommand = commandBuilder.GetDeleteCommand();

            sqlDaPrds.Fill(dtPrds);

            prdBindingSource = new BindingSource(dtPrds, "");

            lstProducts.DataSource = prdBindingSource;
            lstProducts.DisplayMember = "title";
            lstProducts.ValueMember = "title_id";

            // Select the initial title if provided
            if (!string.IsNullOrEmpty(_initialTitleId))
            {
                int index = prdBindingSource.Find("title_id", _initialTitleId);
                if (index >= 0)
                {
                    prdBindingSource.Position = index;
                }
            }

            BindingNavigator = new BindingNavigator(prdBindingSource);
            BindingNavigator.Dock = DockStyle.Top;

            this.Controls.Add(BindingNavigator);

            lblProductID.DataBindings.Add("Text", prdBindingSource, "title_id");
            txtProductName.DataBindings.Add("Text", prdBindingSource, "title");
            
            // Handle DBNull for price
            Binding priceBinding = new Binding("Value", prdBindingSource, "price", true);
            priceBinding.NullValue = 0m;
            numUnitPrice.DataBindings.Add(priceBinding);

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedValue != null)
                this.Text = lstProducts.SelectedValue.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prdBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            prdBindingSource.MoveNext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                prdBindingSource.EndEdit();
                sqlDaPrds.Update(dtPrds);
                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
