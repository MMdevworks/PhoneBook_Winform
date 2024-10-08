using System.Windows.Forms;

namespace Assignment4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GenerateRandom()
        {
            Random rnd = new Random();
            long randomNum = rnd.Next(1000000000, int.MaxValue);
            string format = "000-000-0000";

            return randomNum.ToString(format);

        }
        private void Contacts_Load(object sender, EventArgs e)
        {
            PhoneBookData.phoneBook.Add("Doug", new Person() { FirstName = "Doug", LastName = "Funny", MobileNumber = GenerateRandom(), WorkNumber = GenerateRandom(), Address = "123 Quail St" });
            PhoneBookData.phoneBook.Add("Patty", new Person() { FirstName = "Patty", LastName = "Mayo", MobileNumber = GenerateRandom(), WorkNumber = GenerateRandom(), Address = "322 Skeeter Ave" });
            PhoneBookData.phoneBook.Add("Arnold", new Person() { FirstName = "Arnold", LastName = "Smith", MobileNumber = GenerateRandom(), WorkNumber = GenerateRandom(), Address = "57 North Blvd" });
            PhoneBookData.phoneBook.Add("Bobby", new Person() { FirstName = "Bobby", LastName = "Taco", MobileNumber = GenerateRandom(), WorkNumber = GenerateRandom(), Address = "880 Island Lake" });
            PhoneBookData.phoneBook.Add("Gary", new Person() { FirstName = "Gary", LastName = "Anderson", MobileNumber = GenerateRandom(), WorkNumber = GenerateRandom(), Address = "9652 Elm Street" });
            PhoneBookData.phoneBook.Add("Lil", new Person() { FirstName = "Lil", LastName = "Biggs", MobileNumber = GenerateRandom(), WorkNumber = GenerateRandom(), Address = "1010 Strode Circle" });
            // show values in dictionary on grid
            dataGridContacts.DataSource = PhoneBookData.phoneBook.Values.ToList();
        }

        private void RefreshData()
        {
            dataGridContacts.DataSource = null;
            dataGridContacts.DataSource = PhoneBookData.phoneBook.Values.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteContact deleteContact = new DeleteContact();
            deleteContact.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ContactSearch contactSearch = new ContactSearch();
            contactSearch.ShowDialog();
        }
    }
}
