using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learn_CSharp_EFCore_Beginner.Models.Db;

namespace Learn_CSharp_EFCore_Beginner
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.Size = new Size(1100, 900);
        }

        LearnCsharpEfcoreBeginnerDbContext db = new LearnCsharpEfcoreBeginnerDbContext();

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            var data = from c in db.Customers
                       where c.CustomerId.Contains(keyword) ||
                       c.CompanyName.Contains(keyword) ||
                       c.ContactName.Contains(keyword) ||
                       c.ContactTitle.Contains(keyword) ||
                       c.Address.Contains(keyword) ||
                       c.City.Contains(keyword) ||
                       c.Region.Contains(keyword) ||
                       c.PostalCode.Contains(keyword) ||
                       c.Country.Contains(keyword) ||
                       c.Phone.Contains(keyword)
                       select new
                       {
                           CustomerId = c.CustomerId,
                           CompanyName = c.CompanyName,
                           ContactName = c.ContactName,
                           ContactTitle = c.ContactTitle,
                           Address = c.Address,
                           City = c.City,
                           Region = c.Region,
                           PostalCode = c.PostalCode,
                           Country = c.Country,
                           Phone = c.Phone
                       };
            if (data != null)
            {
                if (data.Count() > 0)
                {
                    dataGridView1.DataSource = data.ToList();
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.Columns[0].HeaderText = "Customer ID";
                    dataGridView1.Columns[1].HeaderText = "Company Name";
                    dataGridView1.Columns[2].HeaderText = "Contact Name";
                    dataGridView1.Columns[3].HeaderText = "Contact Title";
                    dataGridView1.Columns[4].HeaderText = "Address";
                    dataGridView1.Columns[5].HeaderText = "City";
                    dataGridView1.Columns[6].HeaderText = "Region";
                    dataGridView1.Columns[7].HeaderText = "Postal Code";
                    dataGridView1.Columns[8].HeaderText = "Country";
                    dataGridView1.Columns[9].HeaderText = "Phone";
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No records found.", "C# EFcore Beginner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            createAutoComplete();
        }


        private void createAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                //var customerList = db.Customers.Select(m => m.ContactName).Distinct(); //Lamda Expression.
                var results = (from cus in db.Customers select cus.ContactName).Distinct(); //LINQ query systax
                autoComplete.AddRange(results.ToArray());  

                KeywordTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                KeywordTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                KeywordTextBox.AutoCompleteCustomSource = autoComplete;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "Auto Complete.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
