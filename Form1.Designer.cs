namespace Assignment4_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridContacts = new DataGridView();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).BeginInit();
            SuspendLayout();
            // 
            // dataGridContacts
            // 
            dataGridContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridContacts.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridContacts.BorderStyle = BorderStyle.None;
            dataGridContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContacts.Location = new Point(12, 32);
            dataGridContacts.Name = "dataGridContacts";
            dataGridContacts.Size = new Size(872, 301);
            dataGridContacts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(191, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Contact";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(495, 394);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(719, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 45);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Contact";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(374, 418);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(900, 545);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(dataGridContacts);
            Name = "Form1";
            Text = "Contacts";
            Load += Contacts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridContacts;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnRefresh;
    }
}
