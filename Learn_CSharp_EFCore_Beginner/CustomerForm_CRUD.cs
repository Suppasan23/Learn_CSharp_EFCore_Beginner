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
    public partial class CustomerForm_CRUD : Form
    {
        LearnCsharpEfcoreBeginnerDbContext db = new LearnCsharpEfcoreBeginnerDbContext();
        private string theCRUD;
        private string theID;

        public CustomerForm_CRUD(String whichCRUD, string WhichID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.theCRUD = whichCRUD;
            this.theID = WhichID;
            this.CustomerIDTextBox.MaxLength = 5;

            ExecuteButton.Text = this.theCRUD;
        }

        /////////////////////////////////Load////////////////////////////////////////////////////////////////////////////////////
        private void CustomerForm_CRUD_Load(object sender, EventArgs e)
        {
            center.isExecuted = false;

            try
            {
                if (this.theCRUD.ToUpper().Equals("VIEW")) 
                {
                    Text += " " + "(Read Only)";
                    ChooseImageButton.Enabled = false;
                    ClearImageButton.Enabled = false;
                    ExecuteButton.Enabled = false;  

                    foreach(var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Enabled = false;
                    }
                }

                if(string.IsNullOrEmpty(this.theID))
                {
                    // ADD NEW
                    CustomerIDTextBox.Enabled = true;
                    foreach (var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                        if (txt.Name.Equals("CustomerIDTextBox"))
                        {
                            txt.Focus();
                        }
                    }
                }
                else
                {
                    //UPDATE , DELETE , VIEW
                    CustomerIDTextBox.Enabled = false;

                }


                var data = from c in db.Customers
                           where c.CustomerId == this.theID
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
                               Phone = c.Phone,
                               
                           };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////////////////////////////Byte to Image////////////////////////////////////////////////////////////////////////
        private Image byteArraytoImage(byte[] input)
        { 
            using(var ms = new MemoryStream(input))
            {
                var image = Image.FromStream(ms);
                return image;
            }
        }


    }
}
