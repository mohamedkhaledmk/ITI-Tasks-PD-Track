using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsUI
{
    public partial class frmUpdatePrdPrice : Form
    {
        public frmUpdatePrdPrice()
        {
            InitializeComponent();
        }
        BindingSource TitleBindingSrc;
        TitleList Titles;
        private void frmUpdatePrdPrice_Load(object sender, EventArgs e)
        {
            Titles = TitleManager.SelectALLTitles();
            TitleBindingSrc = new BindingSource(Titles, "");

            lstPrds.DataSource = TitleBindingSrc;
            lstPrds.DisplayMember = "TitleName";
            lstPrds.ValueMember = "TitleID";

            // numPrdPrice.DataBindings.Add("Value", PrdBindingSrc, "UnitPrice");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TitleBindingSrc.EndEdit();
            if (lstPrds.SelectedValue?.ToString() is string TitleID)
                this.Text = $"{TitleManager.UpdateTitlePrice(TitleID, numPrdPrice.Value)}";
        }

        private void lstPrds_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPrdPrice.Value = (lstPrds.SelectedItem as Title).Price??0;
        }

    }
}
