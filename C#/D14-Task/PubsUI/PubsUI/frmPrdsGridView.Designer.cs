namespace PubsUI
{
    partial class frmPrdsGridView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grdViewPrds = new DataGridView();
            menuStrip1 = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grdViewPrds).BeginInit();
            menuStrip1.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            grdViewPrds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViewPrds.Dock = DockStyle.Fill;
            grdViewPrds.Location = new System.Drawing.Point(0, 28);
            grdViewPrds.Name = "grdViewPrds";
            grdViewPrds.RowHeadersWidth = 51;
            grdViewPrds.Size = new System.Drawing.Size(800, 382);
            grdViewPrds.TabIndex = 0;

            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";

            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, toolStripMenuItem1, saveToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            manageToolStripMenuItem.Text = "Manage";

            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;

            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);

            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;

            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 40;
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnDelete);

            btnAdd.Location = new System.Drawing.Point(8, 6);
            btnAdd.Size = new System.Drawing.Size(90, 28);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;

            btnEdit.Location = new System.Drawing.Point(106, 6);
            btnEdit.Size = new System.Drawing.Size(90, 28);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;

            btnDelete.Location = new System.Drawing.Point(204, 6);
            btnDelete.Size = new System.Drawing.Size(90, 28);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(grdViewPrds);
            Controls.Add(pnlButtons);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrdsGridView";
            Text = "Products Grid";
            ((System.ComponentModel.ISupportInitialize)grdViewPrds).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView grdViewPrds;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Panel pnlButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
