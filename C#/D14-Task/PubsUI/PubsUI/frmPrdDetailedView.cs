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
    public partial class frmPrdDetailedView : Form
    {
        public frmPrdDetailedView()
        {
            InitializeComponent();
        }
        BindingNavigator TitleBindingNavigator;
        private void frmPrdDetailedView_Load(object sender, EventArgs e)
        {
            TitleList Titles = TitleManager.SelectALLTitles();
            prdBindingSource = new(Titles, "");

            prdBindingSource.AddingNew += (sender, e) => e.NewObject = new Title() { TitleName = "",  State = EntitySate.Added, Price = 10 };


            TitleBindingNavigator = new BindingNavigator(prdBindingSource);

            TitleBindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(TitleBindingNavigator);

            lblProductID.DataBindings.Add("Text", prdBindingSource, "TitleID");
            txtProductName.DataBindings.Add("Text", prdBindingSource, "TitleName");
            numUnitPrice.DataBindings.Add("Value", prdBindingSource, "Price");

        }
    }
}
