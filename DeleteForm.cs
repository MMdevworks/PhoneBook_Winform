using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_1
{
    public partial class DeleteContact : Form
    {
        public DeleteContact()
        {
            InitializeComponent();
        }

        private void btnContactDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this contact?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PhoneBookData.phoneBook.Remove(txtDeleteKey.Text);
                txtDeleteKey.Clear();
            }
        }
    }
}
