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



        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        /////////////////////////////////Load Data/////////////////////////////////////////////////////////////////////////////////////////////

        LearnCsharpEfcoreBeginnerDbContext db = new LearnCsharpEfcoreBeginnerDbContext();

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
                    if (dataGridView1.Rows.Count > 0)
                    {
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
                    setupDataTable();
                    foreach (var cs in data)
                    {
                        dt.Rows.Add(cs.CustomerId, cs.CompanyName, cs.ContactName, cs.ContactTitle, cs.Address, cs.City, cs.Region, cs.PostalCode, cs.Country, cs.Phone);
                    }
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No records found.", "C# EFcore Beginner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            createAutoComplete();
        }

        /////////////////////////////////Auto Complete/////////////////////////////////////////////////////////////////////////////////////////////
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


        /////////////////////////////////Search/////////////////////////////////////////////////////////////////////////////////////////////
        private void SearchButton_Click(object sender, EventArgs e)
        {
            serachData();
        }

        private void KeywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Disable Windows Sound
                e.SuppressKeyPress = true;
                serachData();
            }
        }

        private void serachData()
        {
            if (string.IsNullOrEmpty(KeywordTextBox.Text.Trim()))
            {
                loadData(""); //Refresh
            }
            else
            {
                loadData(KeywordTextBox.Text.Trim());
            }
            KeywordTextBox.Focus();
            KeywordTextBox.SelectAll();
        }

        private void KeywordTextBox_DoubleClick(object sender, EventArgs e)
        {
            KeywordTextBox.Clear();
            KeywordTextBox.Focus();
        }



        /////////////////////////////////Export to Excel/////////////////////////////////////////////////////////////////////////////////////////////

        DataTable dt = new DataTable("Customers");

        private void setupDataTable()
        {
            try
            {
                dt.Clear();
                dt.Columns.Clear();
                dt.Rows.Clear();

                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("CustomerID", typeof(string)),
                    new DataColumn("CompanyName", typeof(string)),
                    new DataColumn("ContactName", typeof(string)),
                    new DataColumn("ContactTitle", typeof(string)),
                    new DataColumn("Address", typeof(string)),
                    new DataColumn("City", typeof(string)),
                    new DataColumn("Region", typeof(string)),
                    new DataColumn("PostalCode", typeof(string)),
                    new DataColumn("Country", typeof(string)),
                    new DataColumn("Phone", typeof(string)),
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Setup DataTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            string caption = "Export to Excel.";
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found.", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    workbook.Worksheets.Add(dt);
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.FileName = "ร้านธีรภัทร์";
                        sfd.Filter = "Excel Workbook (*.xlsx) | *.xlsx";
                        sfd.Title = "C# Export to Excel";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            string strFilename;
                            string msg = "Export done successfully! " + Environment.NewLine;

                            if (sfd.FileName != "")
                            {
                                strFilename = sfd.FileName;
                                workbook.SaveAs(strFilename);
                                msg += strFilename;
                            }
                            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /////////////////////////////////About Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void aboutMyAPpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "My Application Version 1.0.0";
            string caption = "About my application";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /////////////////////////////////Add New Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewButton.PerformClick();
        }
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New");
        }

        /////////////////////////////////Add New Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update");
        }

        /////////////////////////////////Add New Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.PerformClick();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }

        /////////////////////////////////Log-Out Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        /////////////////////////////////Exit Button/////////////////////////////////////////////////////////////////////////////////////////////
        private string closeMode = "";

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeMode = "exit";
            Application.Exit();
        }

    }
}
