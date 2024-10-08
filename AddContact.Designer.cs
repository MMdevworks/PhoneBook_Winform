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
            btnAdd.Location = new Point(134, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblContactFName
            // 
            lblContactFName.AutoSize = true;
            lblContactFName.Location = new Point(28, 60);
            lblContactFName.Name = "lblContactFName";
            lblContactFName.Size = new Size(64, 15);
            lblContactFName.TabIndex = 1;
            lblContactFName.Text = "First Name";
            // 
            // lblContactMobile
            // 
            lblContactMobile.AutoSize = true;
            lblContactMobile.Location = new Point(28, 142);
            lblContactMobile.Name = "lblContactMobile";
            lblContactMobile.Size = new Size(91, 15);
            lblContactMobile.TabIndex = 2;
            lblContactMobile.Text = "Mobile Number";
            // 
            // txtContactFName
            // 
            txtContactFName.Location = new Point(166, 58);
            txtContactFName.Name = "txtContactFName";
            txtContactFName.Size = new Size(218, 23);
            txtContactFName.TabIndex = 3;
            // 
            // txtContactMobile
            // 
            txtContactMobile.Location = new Point(163, 134);
            txtContactMobile.Name = "txtContactMobile";
            txtContactMobile.Size = new Size(218, 23);
            txtContactMobile.TabIndex = 4;
            // 
            // txtContactWork
            // 
            txtContactWork.Location = new Point(163, 176);
            txtContactWork.Name = "txtContactWork";
            txtContactWork.Size = new Size(218, 23);
            txtContactWork.TabIndex = 6;
            // 
            // lblContactWork
            // 
            lblContactWork.AutoSize = true;
            lblContactWork.Location = new Point(28, 184);
            lblContactWork.Name = "lblContactWork";
            lblContactWork.Size = new Size(82, 15);
            lblContactWork.TabIndex = 5;
            lblContactWork.Text = "Work Number";
            // 
            // txtContactLName
            // 
            txtContactLName.Location = new Point(166, 96);
            txtContactLName.Name = "txtContactLName";
            txtContactLName.Size = new Size(218, 23);
            txtContactLName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 98);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Last Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(166, 224);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 23);
            txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(28, 226);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
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