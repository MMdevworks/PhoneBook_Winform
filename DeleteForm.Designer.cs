namespace Assignment4_1
{
    partial class DeleteContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDeleteContact = new Label();
            txtDeleteKey = new TextBox();
            btnContactDelete = new Button();
            SuspendLayout();
            // 
            // lblDeleteContact
            // 
            lblDeleteContact.AutoSize = true;
            lblDeleteContact.Location = new Point(41, 41);
            lblDeleteContact.Name = "lblDeleteContact";
            lblDeleteContact.Size = new Size(268, 15);
            lblDeleteContact.TabIndex = 0;
            lblDeleteContact.Text = "Enter the name of the contact you want to delete:";
            // 
            // txtDeleteKey
            // 
            txtDeleteKey.Location = new Point(41, 73);
            txtDeleteKey.Name = "txtDeleteKey";
            txtDeleteKey.Size = new Size(268, 23);
            txtDeleteKey.TabIndex = 1;
            // 
            // btnContactDelete
            // 
            btnContactDelete.BackColor = Color.SandyBrown;
            btnContactDelete.Cursor = Cursors.Hand;
            btnContactDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContactDelete.ForeColor = Color.Black;
            btnContactDelete.Location = new Point(136, 113);
            btnContactDelete.Name = "btnContactDelete";
            btnContactDelete.Size = new Size(73, 30);
            btnContactDelete.TabIndex = 2;
            btnContactDelete.Text = "Delete";
            btnContactDelete.UseVisualStyleBackColor = false;
            btnContactDelete.Click += btnContactDelete_Click;
            // 
            // DeleteContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(362, 164);
            Controls.Add(btnContactDelete);
            Controls.Add(txtDeleteKey);
            Controls.Add(lblDeleteContact);
            Name = "DeleteContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeleteContact;
        private TextBox txtDeleteKey;
        private Button btnContactDelete;
    }
}