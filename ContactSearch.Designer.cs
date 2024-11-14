namespace Assignment4_1
{
    partial class ContactSearch
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
            txtSearchName = new TextBox();
            label1 = new Label();
            btnSearchContacts = new Button();
            lblLName = new Label();
            lblLastNameOut = new Label();
            lblFirstNameOut = new Label();
            lblFName = new Label();
            lblMobileOut = new Label();
            lblMobile = new Label();
            lblWorkOut = new Label();
            lblWork = new Label();
            lblAddressOut = new Label();
            lblAddress = new Label();
            SuspendLayout();
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(39, 52);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(270, 23);
            txtSearchName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(270, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter the name of the contact you want to search:";
            // 
            // btnSearchContacts
            // 
            btnSearchContacts.BackColor = Color.FromArgb(0, 64, 64);
            btnSearchContacts.Cursor = Cursors.Hand;
            btnSearchContacts.FlatAppearance.BorderColor = Color.Black;
            btnSearchContacts.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchContacts.ForeColor = SystemColors.ControlLightLight;
            btnSearchContacts.Location = new Point(136, 92);
            btnSearchContacts.Name = "btnSearchContacts";
            btnSearchContacts.Size = new Size(70, 27);
            btnSearchContacts.TabIndex = 2;
            btnSearchContacts.Text = "Search";
            btnSearchContacts.UseVisualStyleBackColor = false;
            btnSearchContacts.Click += btnSearchContacts_Click;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(60, 190);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(63, 15);
            lblLName.TabIndex = 3;
            lblLName.Text = "Last Name";
            // 
            // lblLastNameOut
            // 
            lblLastNameOut.AutoSize = true;
            lblLastNameOut.Location = new Point(170, 190);
            lblLastNameOut.Name = "lblLastNameOut";
            lblLastNameOut.Size = new Size(107, 15);
            lblLastNameOut.TabIndex = 4;
            lblLastNameOut.Text = "--------------------";
            // 
            // lblFirstNameOut
            // 
            lblFirstNameOut.AutoSize = true;
            lblFirstNameOut.Location = new Point(170, 155);
            lblFirstNameOut.Name = "lblFirstNameOut";
            lblFirstNameOut.Size = new Size(107, 15);
            lblFirstNameOut.TabIndex = 6;
            lblFirstNameOut.Text = "--------------------";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(60, 155);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(64, 15);
            lblFName.TabIndex = 5;
            lblFName.Text = "First Name";
            // 
            // lblMobileOut
            // 
            lblMobileOut.AutoSize = true;
            lblMobileOut.Location = new Point(170, 226);
            lblMobileOut.Name = "lblMobileOut";
            lblMobileOut.Size = new Size(107, 15);
            lblMobileOut.TabIndex = 8;
            lblMobileOut.Text = "--------------------";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(60, 226);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(44, 15);
            lblMobile.TabIndex = 7;
            lblMobile.Text = "Mobile";
            // 
            // lblWorkOut
            // 
            lblWorkOut.AutoSize = true;
            lblWorkOut.Location = new Point(170, 262);
            lblWorkOut.Name = "lblWorkOut";
            lblWorkOut.Size = new Size(107, 15);
            lblWorkOut.TabIndex = 10;
            lblWorkOut.Text = "--------------------";
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Location = new Point(60, 262);
            lblWork.Name = "lblWork";
            lblWork.Size = new Size(35, 15);
            lblWork.TabIndex = 9;
            lblWork.Text = "Work";
            // 
            // lblAddressOut
            // 
            lblAddressOut.AutoSize = true;
            lblAddressOut.Location = new Point(170, 300);
            lblAddressOut.Name = "lblAddressOut";
            lblAddressOut.Size = new Size(107, 15);
            lblAddressOut.TabIndex = 12;
            lblAddressOut.Text = "--------------------";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(60, 300);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address";
            // 
            // ContactSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(348, 391);
            Controls.Add(lblAddressOut);
            Controls.Add(lblAddress);
            Controls.Add(lblWorkOut);
            Controls.Add(lblWork);
            Controls.Add(lblMobileOut);
            Controls.Add(lblMobile);
            Controls.Add(lblFirstNameOut);
            Controls.Add(lblFName);
            Controls.Add(lblLastNameOut);
            Controls.Add(lblLName);
            Controls.Add(btnSearchContacts);
            Controls.Add(label1);
            Controls.Add(txtSearchName);
            Name = "ContactSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchName;
        private Label label1;
        private Button btnSearchContacts;
        private Label lblLName;
        private Label lblLastNameOut;
        private Label lblFirstNameOut;
        private Label lblFName;
        private Label lblMobileOut;
        private Label lblMobile;
        private Label lblWorkOut;
        private Label lblWork;
        private Label lblAddressOut;
        private Label lblAddress;
    }
}