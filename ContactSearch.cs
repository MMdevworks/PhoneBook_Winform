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
    public partial class ContactSearch : Form
    {
        public ContactSearch()
        {
            InitializeComponent();
        }

        private void btnSearchContacts_Click(object sender, EventArgs e)
        {
            if (PhoneBookData.phoneBook.ContainsKey(txtSearchName.Text))
            {
                lblFirstNameOut.Text = PhoneBookData.phoneBook[txtSearchName.Text].FirstName;
                lblLastNameOut.Text = PhoneBookData.phoneBook[txtSearchName.Text].LastName;
                lblMobileOut.Text = PhoneBookData.phoneBook[txtSearchName.Text].MobileNumber;
                lblWorkOut.Text = PhoneBookData.phoneBook[txtSearchName.Text].WorkNumber;
                lblAddressOut.Text = PhoneBookData.phoneBook[txtSearchName.Text].Address;
                
            }
        }
    }
}
