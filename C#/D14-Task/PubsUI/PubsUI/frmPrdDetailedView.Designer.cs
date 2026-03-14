namespace PubsUI
{
    partial class frmPrdDetailedView
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
            lblProductID = new Label();
            txtProductName = new TextBox();
            numUnitPrice = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            SuspendLayout();

            lblProductID.AutoSize = true;
            lblProductID.Location = new System.Drawing.Point(41, 47);
            lblProductID.Name = "lblProductID";
            lblProductID.Text = "";

            txtProductName.Location = new System.Drawing.Point(41, 88);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(260, 27);
            txtProductName.ReadOnly = true;

            numUnitPrice.Location = new System.Drawing.Point(41, 140);
            numUnitPrice.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numUnitPrice.DecimalPlaces = 2;
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new System.Drawing.Size(150, 27);

            btnSave.Location = new System.Drawing.Point(41, 195);
            btnSave.Size = new System.Drawing.Size(90, 30);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;

            btnCancel.Location = new System.Drawing.Point(140, 195);
            btnCancel.Size = new System.Drawing.Size(90, 30);
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 260);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Controls.Add(numUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductID);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "frmPrdDetailedView";
            Text = "Edit Title";
            Load += frmPrdDetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblProductID;
        private TextBox txtProductName;
        private NumericUpDown numUnitPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}
