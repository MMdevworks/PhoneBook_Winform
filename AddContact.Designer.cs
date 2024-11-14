namespace Assignment4_1
{
    partial class AddContact
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
            btnAdd = new Button();
            lblContactFName = new Label();
            lblContactMobile = new Label();
            txtContactFName = new TextBox();
            txtContactMobile = new TextBox();
            txtContactWork = new TextBox();
            lblContactWork = new Label();
            txtContactLName = new TextBox();
            label1 = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 64, 64);
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(166, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblContactFName
            // 
            lblContactFName.AutoSize = true;
            lblContactFName.Location = new Point(30, 46);
            lblContactFName.Name = "lblContactFName";
            lblContactFName.Size = new Size(64, 15);
            lblContactFName.TabIndex = 1;
            lblContactFName.Text = "First Name";
            // 
            // lblContactMobile
            // 
            lblContactMobile.AutoSize = true;
            lblContactMobile.Location = new Point(30, 128);
            lblContactMobile.Name = "lblContactMobile";
            lblContactMobile.Size = new Size(91, 15);
            lblContactMobile.TabIndex = 2;
            lblContactMobile.Text = "Mobile Number";
            // 
            // txtContactFName
            // 
            txtContactFName.Location = new Point(169, 43);
            txtContactFName.Name = "txtContactFName";
            txtContactFName.Size = new Size(218, 23);
            txtContactFName.TabIndex = 1;
            // 
            // txtContactMobile
            // 
            txtContactMobile.Location = new Point(169, 125);
            txtContactMobile.Name = "txtContactMobile";
            txtContactMobile.Size = new Size(218, 23);
            txtContactMobile.TabIndex = 3;
            // 
            // txtContactWork
            // 
            txtContactWork.Location = new Point(169, 166);
            txtContactWork.Name = "txtContactWork";
            txtContactWork.Size = new Size(218, 23);
            txtContactWork.TabIndex = 4;
            // 
            // lblContactWork
            // 
            lblContactWork.AutoSize = true;
            lblContactWork.Location = new Point(30, 169);
            lblContactWork.Name = "lblContactWork";
            lblContactWork.Size = new Size(82, 15);
            lblContactWork.TabIndex = 5;
            lblContactWork.Text = "Work Number";
            // 
            // txtContactLName
            // 
            txtContactLName.Location = new Point(169, 84);
            txtContactLName.Name = "txtContactLName";
            txtContactLName.Size = new Size(218, 23);
            txtContactLName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 87);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Last Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(169, 207);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 23);
            txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(30, 210);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(422, 314);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContactLName);
            Controls.Add(label1);
            Controls.Add(txtContactWork);
            Controls.Add(lblContactWork);
            Controls.Add(txtContactMobile);
            Controls.Add(txtContactFName);
            Controls.Add(lblContactMobile);
            Controls.Add(lblContactFName);
            Controls.Add(btnAdd);
            Name = "AddContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label lblContactFName;
        private Label lblContactMobile;
        private TextBox txtContactFName;
        private TextBox txtContactMobile;
        private TextBox txtContactWork;
        private Label lblContactWork;
        private TextBox txtContactLName;
        private Label label1;
        private TextBox txtAddress;
        private Label lblAddress;
    }
}