﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learn_CSharp_EFCore_Beginner.Models.Db;
using Microsoft.IdentityModel.Tokens;

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
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.Size = new Size(1100, 900);

            center.DoubleBuffered(dataGridView1, true);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            StatusToolStripStatusLabel.Text = string.Format("Hello,{0}", center.CurrentFullName);
            loadData("");
        }

        /////////////////////////////////Load/////////////////////////////////////////////////////////////////////////////////////////////

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
                           Picture = c.Picture,
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

                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.GetType() == typeof(DataGridViewImageColumn))
                            {
                                col.DefaultCellStyle.NullValue = null;

                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    DataGridViewImageCell cell = (DataGridViewImageCell)row.Cells[1];

                                    cell.ImageLayout = DataGridViewImageCellLayout.Stretch;

                                    cell.Description = "Stretched";

                                    for (int i = 0; i < row.Cells.Count; i++)
                                    {
                                        if (row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                                        {
                                            row.Height = 135;
                                        }
                                        else
                                        {
                                            row.Height = 40;
                                        }
                                    }
                                }
                            }
                        }

                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                        dataGridView1.Columns[0].HeaderText = "Customer ID";
                        dataGridView1.Columns[0].Width = 100;

                        dataGridView1.Columns[1].HeaderText = "Picture";
                        dataGridView1.Columns[1].Width = 135;

                        dataGridView1.Columns[2].HeaderText = "Company Name";
                        dataGridView1.Columns[2].Width = 200;

                        dataGridView1.Columns[3].HeaderText = "Contact Name";
                        dataGridView1.Columns[3].Width = 200;

                        dataGridView1.Columns[4].HeaderText = "Contact Title";
                        dataGridView1.Columns[4].Width = 200;

                        dataGridView1.Columns[5].HeaderText = "Address";
                        dataGridView1.Columns[4].Width = 200;

                        dataGridView1.Columns[6].HeaderText = "City";
                        dataGridView1.Columns[6].Width = 200;


                        dataGridView1.Columns[7].HeaderText = "Region";
                        dataGridView1.Columns[7].Width = 100;

                        dataGridView1.Columns[8].HeaderText = "Postal Code";
                        dataGridView1.Columns[8].Width = 200;

                        dataGridView1.Columns[9].HeaderText = "Country";
                        dataGridView1.Columns[9].Width = 200;

                        dataGridView1.Columns[10].HeaderText = "Phone";
                        dataGridView1.Columns[10].Width = 200;
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


        /////////////////////////////////CRUD/////////////////////////////////////////////////////////////////////////////////////////////
        private string WhichID = ""; // Waiting for datagridview clicked
        private string whichCRUD = ""; // Waiting for Add, Update, Delete button clicked


        private void openCustomerForm_CRUD(string whichCRUD, string WhichID)
        {
            if (whichCRUD.ToUpper().Equals("UPDATE") || whichCRUD.ToUpper().Equals("DELETE"))
            {
                if (string.IsNullOrEmpty(WhichID.Trim()))
                {
                    MessageBox.Show("ID NOT FOUND.", "Open CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dataGridView1.Rows.Count == 0 || dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an item from the list", "Open CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            CustomerForm_CRUD f = new CustomerForm_CRUD(whichCRUD, WhichID);
            f.ShowDialog();

            if (center.isExecuted == true)
            {
                // Refresh the main form after Executed data.
                loadData("");
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string? v = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                WhichID = v;
                //MessageBox.Show(WhichID);
            }
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



        /////////////////////////////////Add New Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewButton.PerformClick();
        }
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            whichCRUD = "ADD";
            openCustomerForm_CRUD(whichCRUD, "");
        }

        /////////////////////////////////Update Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            whichCRUD = "UPDATE";
            openCustomerForm_CRUD(whichCRUD, WhichID);
        }

        /////////////////////////////////Delete Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.PerformClick();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            whichCRUD = "DELETE";
            openCustomerForm_CRUD(whichCRUD, WhichID);
        }

        /////////////////////////////////DataGridView1 Cell Mouse Double Click/////////////////////////////////////////////////////////////////////////////////////////////
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                whichCRUD = "UPDATE";
                openCustomerForm_CRUD(whichCRUD, WhichID);
            }
        }

        /////////////////////////////////About Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void aboutMyAPpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "My Application Version 1.0.0";
            string caption = "About my application";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /////////////////////////////////Log-Out Button/////////////////////////////////////////////////////////////////////////////////////////////
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeMode = "Log-out";
            string msg = "Are yot sure you want to log-out?";
            DialogResult result = MessageBox.Show(msg, "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Close the main form
                Close();

                //Show the Log-in Form
                LoginForm f = new LoginForm();
                f.Closed += (s, e) => this.Close();
                f.Show();
            }
        }

        /////////////////////////////////Exit Button/////////////////////////////////////////////////////////////////////////////////////////////
        private string closeMode = "";

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeMode = "exit";
            Application.Exit();
        }

        /////////////////////////////////DataGridView1 Cell Mouse Down//////////////////////////////////////////////////////////////////////////
        private bool cancelShowContextMenu = false;

        public object DataGridViewImageCellLaout { get; private set; }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cancelShowContextMenu = false;

                if (e.Button == MouseButtons.Right)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    string? v = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    WhichID = v;
                }
            }
            else
            {
                cancelShowContextMenu = true;
            }

        }


        /////////////////////////////////DataGridView1 Mouse Click//////////////////////////////////////////////////////////////////////////
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cancelShowContextMenu == true)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }


        /////////////////////////////////ContextMenuStrip1 Item Click//////////////////////////////////////////////////
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Add New":
                    AddNewButton.PerformClick();
                    break;
                case "Update":
                    UpdateButton.PerformClick();
                    break;
                case "Delete":
                    DeleteButton.PerformClick();
                    break;
                case "View":
                    whichCRUD = "VIEW";
                    openCustomerForm_CRUD(whichCRUD, WhichID);
                    break;

            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            center.CurrentUserID = string.Empty;
            center.CurrentUserName = string.Empty;
            center.CurrentFullName = string.Empty;

            if (closeMode.Equals("Log-out") || closeMode.Equals("Exit"))
            {
                return;
            }

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}
