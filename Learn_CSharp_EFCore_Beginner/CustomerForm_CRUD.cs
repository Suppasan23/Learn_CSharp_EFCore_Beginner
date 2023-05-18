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

            ExecuteButton.Text = this.theCRUD; //<--- VIEW, INSERT, UPDATE, DELETE
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
                    ExecuteButton.Enabled = true;
                    ExecuteButton.Text = "Close";


                    foreach (var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Enabled = false;
                    }
                }

                if (string.IsNullOrEmpty(this.theID))// ADD NEW
                {
                    
                    CustomerIDTextBox.Enabled = true;
                    foreach (var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                        if (txt.Name.Equals("CustomerIDTextBox"))
                        {
                            txt.Focus();
                        }
                    }
                    return;
                }
                else//UPDATE , DELETE , VIEW
                {
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

        //////////////////////////////Choose Image Button////////////////////////////////////////////////////////////////////////
        private string imageFileName;
        private bool imageHasChangeed;

        private void ChooseImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Choose a picture";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Image|*.png|" + "All files (*.*)|*.*";

                openFileDialog1.AddExtension = true;
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ValidateNames = true;
                // openFileDialog1.InitialDirectory = MyPicture;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    PictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    imageFileName = openFileDialog1.FileName;
                    imageHasChangeed = true;
                    PictureBox.Tag = "NewImage";
                }
                else
                {
                    imageFileName = "";
                    imageHasChangeed = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Choose Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //////////////////////////////Clear Image Button////////////////////////////////////////////////////////////////////////
        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            PictureBox.Tag = "Empty";

            imageFileName = "";
            imageHasChangeed = true;
        }


        //////////////////////////////Execute Button////////////////////////////////////////////////////////////////////////////
        private byte[] imgToByteArr;
        
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            var tr = db.Database.BeginTransaction();//Transaction control: Create, Update, Deleate

            try
            {
                if(imageHasChangeed == true)
                { 
                    if(!string.IsNullOrEmpty(imageFileName))
                    {
                        //Initialize a file stream to read the image file
                        FileStream fs = new FileStream(imageFileName, FileMode.Open, FileAccess.Read);
                        //Initialize a byte array with size of stream || Read the source file into a byte array.
                        imgToByteArr = new byte[fs.Length];
                        //Read data from the file stream and put into the byte array
                        fs.Read(imgToByteArr, 0, Convert.ToInt32(fs.Length));
                        //Close a file stream
                        fs.Close();
                    }
                }

                //VIEW//
                if(theCRUD.ToUpper().Equals("VIEW"))
                {
                    center.isExecuted = false;
                    Close();
                }

                //ADD//
                else if (theCRUD.ToUpper().Equals("ADD"))
                {
                    if(string.IsNullOrEmpty(CustomerIDTextBox.Text.Trim()) || string.IsNullOrEmpty(CompanyNameTextBox.Text.Trim()))
                    {
                        MessageBox.Show("Please fill in the required fields.", "Add new Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if(CustomerIDTextBox.Text.Trim().Length != 5)
                    {
                        MessageBox.Show("Customer ID must be 5 Characters", "Add new Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var dup = (from c in db.Customers where c.CustomerId == CustomerIDTextBox.Text.Trim() select c);//Check duplicate customer ID.
                    if (dup.Count() > 0)
                    {
                        MessageBox.Show("Customer ID already taken", "Add new Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    result = MessageBox.Show("Do you want to add this new customer?", "Add new customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes) 
                    {
                        Customer cs = new Customer();
                        cs.CustomerId = CustomerIDTextBox.Text.Trim();  
                        cs.CompanyName = CompanyNameTextBox.Text.Trim();    
                        cs.ContactName = ContactNameTextBox.Text.Trim();    
                        cs.ContactTitle = ContactTitleTextBox.Text.Trim();  
                        cs.Address = AddressTextBox.Text.Trim();    
                        cs.City = CityTextBox.Text.Trim();
                        cs.Region = RegionTextBox.Text.Trim();
                        cs.PostalCode = PostalCodeTextBox.Text.Trim();  
                        cs.Country = CountryTextBox.Text.Trim();    
                        cs.Phone = PhoneTextBox.Text.Trim();    
                        
                        if(imageHasChangeed == true)
                        {
                            if(!string.IsNullOrEmpty(imageFileName))
                            {
                                cs.Picture = imgToByteArr;
                            }
                            else
                            {
                                cs.Picture = null;
                            }
                        }

                        db.Customers.Add(cs);
                        db.SaveChanges();   
                        tr.Commit();

                        center.isExecuted = true;
                        MessageBox.Show("Record has been added successfully.", "ADD DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

                //UPDATE//
                else if (theCRUD.ToUpper().Equals("UPDATE"))
                {
                    result = MessageBox.Show("Do you want to save the changes you have made?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes) 
                    { 
                        var cs = (from c in db.Customers
                                  where c.CustomerId == theID
                                  select c).FirstOrDefault();
                        if(cs != null) 
                        { 
                            cs.CompanyName = CompanyNameTextBox.Text.Trim();   
                            cs.ContactName = ContactNameTextBox.Text.Trim();    
                            cs.ContactTitle = ContactTitleTextBox.Text.Trim();  
                            cs.Address = AddressTextBox.Text.Trim();    
                            cs.City = CityTextBox.Text.Trim();  
                            cs.Region = RegionTextBox.Text.Trim();  
                            cs.PostalCode = PostalCodeTextBox.Text.Trim();  
                            cs.Country = CountryTextBox.Text.Trim();    
                            cs.Phone = PhoneTextBox.Text.Trim();
                            
                            if(imageHasChangeed == true) 
                            { 
                                if(!string.IsNullOrEmpty(imageFileName)) 
                                { 
                                    cs.Picture = imgToByteArr;
                                }
                                else 
                                {
                                    cs.Picture = null;
                                }
                            }

                            db.SaveChanges();
                            tr.Commit();

                            center.isExecuted = true;
                            MessageBox.Show("Record has been Update successfully.", "UPDATE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }

                //DELETE// 
                else if (theCRUD.ToUpper().Equals("DELETE"))
                {
                    result = MessageBox.Show(theID +"--" + "Do you want to delete the selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes) 
                    {

                        //(จำเป็นต้องลบข้อมูลออกจาก 3 Table คือ Customers,Orders และ OrderDetails เนื่องจากข้อมูลถูกยึดโยงกันอยู่)

                        //1.Delete in table Customers
                        var cs = (from c in db.Customers
                                  where c.CustomerId == theID
                                  select c).FirstOrDefault();
                        if(cs != null) 
                        {
                            db.Customers.Remove(cs);
                        }

                        //2.Delete in table Orders
                        var idToBeDeleted1 = new List<int>();
                        var idToBeDeleted2 = new List<int>();

                        var od = (from os in db.Orders
                                  where os.CustomerId == theID
                                  select os);
                        if(od != null ) 
                        { 
                            foreach(var oo in od) 
                            {
                                idToBeDeleted1.Add(oo.OrderId);
                                db.Orders.Remove(oo);
                            }
                        }

                        //3.Delete in table OrderDetails
                        var ods = (from oss in db.OrderDetails
                                  where idToBeDeleted1.Contains(oss.OrderId)
                                  select oss);
                        if (ods != null)
                        {
                            foreach (var oos in ods)
                            {
                                idToBeDeleted2.Add(oos.OrderId);
                                db.OrderDetails.Remove(oos);
                            }
                        }

                        db.SaveChanges();
                        tr.Commit();
                        idToBeDeleted1.Clear();
                        idToBeDeleted2.Clear();

                        center.isExecuted = true;
                        MessageBox.Show("Records have been deleted successfully.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                tr.Rollback();
                MessageBox.Show("Error: " + ex.Message, theCRUD + "Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tr.Dispose();
            }
        }
    }
}