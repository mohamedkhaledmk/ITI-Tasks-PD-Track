namespace D13___WinForms
{
    partial class frmAddTitle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitleId = new Label();
            txtTitleId = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitleId
            // 
            lblTitleId.AutoSize = true;
            lblTitleId.Location = new Point(12, 15);
            lblTitleId.Name = "lblTitleId";
            lblTitleId.Size = new Size(58, 20);
            lblTitleId.TabIndex = 0;
            lblTitleId.Text = "Title ID:";
            // 
            // txtTitleId
            // 
            txtTitleId.Location = new Point(90, 12);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(200, 27);
            txtTitleId.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(90, 52);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 3;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 95);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 4;
            lblType.Text = "Type:";
            // 
            // txtType
            // 
            txtType.Location = new Point(90, 92);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 27);
            txtType.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(90, 140);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(196, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddTitle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 185);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtType);
            Controls.Add(lblType);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtTitleId);
            Controls.Add(lblTitleId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddTitle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Title";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleId;
        private TextBox txtTitleId;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblType;
        private TextBox txtType;
        private Button btnSave;
        private Button btnCancel;
    }
}
