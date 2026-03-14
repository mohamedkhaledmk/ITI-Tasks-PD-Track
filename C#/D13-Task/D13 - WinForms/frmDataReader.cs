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
    public partial class frmDataReader : Form
    {
        public frmDataReader()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        private void frmDataReader_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
            sqlCmd = new();
            sqlCmd.Connection = sqlCn;


            sqlCmd.CommandText = "select count(*) from titles";
            sqlCn.Open();
            if (int.TryParse(sqlCmd.ExecuteScalar().ToString(), out int PrdCount))
                this.Text = $"{PrdCount} Titles";
            sqlCn.Close();

            //sqlCmd.CommandType = CommandType.StoredProcedure;
            //sqlCmd.CommandText = "SelectALLProducts";
            sqlCmd.CommandText = "Select * from titles";

            sqlUpdateProductPrice = new SqlCommand(string.Empty, sqlCn);

            sqlUpdateProductPrice.CommandText = """
                UPDATE titles
                SET          price = @price
                WHERE  (title_id = @title_id)
                """;
            sqlUpdateProductPrice.Parameters.Add("@price", SqlDbType.Money);
            sqlUpdateProductPrice.Parameters.Add("@title_id", SqlDbType.VarChar, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlCn.State != ConnectionState.Open)
                sqlCn.Open();
            ///connected Mode
            SqlDataReader Reader = sqlCmd.ExecuteReader();

            while (Reader.Read())
            {
                lstPrdNames.Items.Add(
                    //Reader["title"].ToString()
                    Reader.GetString("title")
                    );

                //Reader["UnitPrice"] = 50;
            }
            sqlCn.Close();
        }

        SqlCommand sqlUpdateProductPrice;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sqlCn.State  == ConnectionState.Closed)
            sqlCn.Open();
           
            if (!string.IsNullOrEmpty(txtPrdID.Text))
            {
                sqlUpdateProductPrice.Parameters["@title_id"].Value = txtPrdID.Text;
                sqlUpdateProductPrice.Parameters["@price"].Value = numUnitProce.Value;
            }

            int R = sqlUpdateProductPrice.ExecuteNonQuery();

            this.Text = $"{R} Rows Affected";


            sqlCn.Close();
        }
    }
}
