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

                    foreach (var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Enabled = false;
                    }
                }

                if (string.IsNullOrEmpty(this.theID))
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
                               Picture = c.Picture
                           };
                CustomerIDTextBox.Text = data.FirstOrDefault().CustomerId.ToString();
                CompanyNameTextBox.Text = data.FirstOrDefault().CompanyName.ToString();
                ContactNameTextBox.Text = data.FirstOrDefault().ContactName.ToString();
                ContactTitleTextBox.Text = data.FirstOrDefault().ContactTitle.ToString();
                AddressTextBox.Text = data.FirstOrDefault().Address.ToString();
                CityTextBox.Text = data.FirstOrDefault().City.ToString();
                RegionTextBox.Text = (DBNull.Value.Equals(data.FirstOrDefault().Region) || string.IsNullOrEmpty(data.FirstOrDefault().Region)) ? "-" : data.FirstOrDefault().Region.ToString();
                PostalCodeTextBox.Text = data.FirstOrDefault().PostalCode.ToString();
                CountryTextBox.Text = data.FirstOrDefault().Country.ToString();
                PhoneTextBox.Text = data.FirstOrDefault().Phone.ToString();
                PictureBox.Image = (data.FirstOrDefault().Picture == null) ? null : byteArraytoImage(data.FirstOrDefault().Picture);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////////////////////////////ByteArray to Image////////////////////////////////////////////////////////////////////////
        private Image byteArraytoImage(byte[] input)
        {
            using (var ms = new MemoryStream(input))
            {
                var image = Image.FromStream(ms);
                return image;
            }
        }


    }
}
