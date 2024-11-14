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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridContacts = new DataGridView();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dataGridContacts.Size = new Size(747, 481);
            dataGridContacts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightCyan;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(765, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 71);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Contact";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(765, 186);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 71);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PeachPuff;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(765, 109);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 71);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Contact";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(765, 263);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 71);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(758, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(900, 545);
            Controls.Add(pictureBox1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(dataGridContacts);
            Name = "Form1";
            Text = "Contacts";
            Load += Contacts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridContacts;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnRefresh;
        private PictureBox pictureBox1;
    }
}
