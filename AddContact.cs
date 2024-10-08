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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(PhoneBookData.phoneBook.ContainsKey(txtContactFName.Text))
            {
                MessageBox.Show("Contact already exists!");
            }
            else
            {
                Person person = new Person();
                person.FirstName = txtContactFName.Text;
                person.LastName = txtContactLName.Text;
                person.MobileNumber = txtContactMobile.Text;
                person.WorkNumber = txtContactWork.Text;
                person.Address = txtAddress.Text;

                PhoneBookData.phoneBook.Add(person.FirstName, person);
                MessageBox.Show("Contact Added!");
                RefreshInputs();
            }
        }
        private void RefreshInputs()
        {
            txtContactFName.Clear();
            txtContactLName.Clear();
            txtContactWork.Clear();
            txtContactMobile.Clear();
            txtAddress.Clear();
        }

    }
}
