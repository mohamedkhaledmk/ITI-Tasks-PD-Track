namespace PubsUI
{
    partial class frmAddTitle
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
            lblTitleID = new Label();
            txtTitleID = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();

            lblTitleID.AutoSize = true;
            lblTitleID.Location = new System.Drawing.Point(20, 20);
            lblTitleID.Text = "Title ID:";

            txtTitleID.Location = new System.Drawing.Point(100, 17);
            txtTitleID.Size = new System.Drawing.Size(160, 27);
            txtTitleID.MaxLength = 6;

            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(20, 60);
            lblTitle.Text = "Title:";

            txtTitle.Location = new System.Drawing.Point(100, 57);
            txtTitle.Size = new System.Drawing.Size(260, 27);
            txtTitle.MaxLength = 80;

            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(20, 100);
            lblType.Text = "Type:";

            txtType.Location = new System.Drawing.Point(100, 97);
            txtType.Size = new System.Drawing.Size(160, 27);
            txtType.MaxLength = 12;

            btnSave.Location = new System.Drawing.Point(100, 145);
            btnSave.Size = new System.Drawing.Size(90, 30);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;

            btnCancel.Location = new System.Drawing.Point(200, 145);
            btnCancel.Size = new System.Drawing.Size(90, 30);
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 200);
            Controls.Add(lblTitleID);
            Controls.Add(txtTitleID);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblType);
            Controls.Add(txtType);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Title";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitleID;
        private TextBox txtTitleID;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblType;
        private TextBox txtType;
        private Button btnSave;
        private Button btnCancel;
    }
}
