namespace Learn_CSharp_EFCore_Beginner
{
    partial class CustomerForm_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            AddressLabel = new Label();
            AddressTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            RegionLabel = new Label();
            RegionTextBox = new TextBox();
            PostalCodeLabel = new Label();
            PostalCodeTextBox = new TextBox();
            CustomerIDLabel = new Label();
            CustomerIDTextBox = new TextBox();
            ContactNameLabel = new Label();
            CompanyNameLabel = new Label();
            ContactNameTextBox = new TextBox();
            CompanyNameTextBox = new TextBox();
            ContactTitleLabel = new Label();
            ContactTitleTextBox = new TextBox();
            CountryLabel = new Label();
            CountryTextBox = new TextBox();
            PhoneLabel = new Label();
            PhoneTextBox = new TextBox();
            PictureGroupBox = new GroupBox();
            PictureBox = new PictureBox();
            ChooseImageButton = new Button();
            ClearImageButton = new Button();
            ExecuteButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            PictureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(526, 32);
            label1.TabIndex = 0;
            label1.Text = "C# Entity Framework Core 7.0 CRUD Operation";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(31, 190);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 1;
            AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBox.Location = new Point(141, 187);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(330, 23);
            AddressTextBox.TabIndex = 2;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.Location = new Point(31, 219);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 1;
            CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            CityTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CityTextBox.Location = new Point(141, 216);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(330, 23);
            CityTextBox.TabIndex = 2;
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RegionLabel.Location = new Point(31, 248);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(47, 15);
            RegionLabel.TabIndex = 1;
            RegionLabel.Text = "Region:";
            // 
            // RegionTextBox
            // 
            RegionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RegionTextBox.Location = new Point(141, 245);
            RegionTextBox.Name = "RegionTextBox";
            RegionTextBox.Size = new Size(330, 23);
            RegionTextBox.TabIndex = 2;
            // 
            // PostalCodeLabel
            // 
            PostalCodeLabel.AutoSize = true;
            PostalCodeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PostalCodeLabel.Location = new Point(31, 277);
            PostalCodeLabel.Name = "PostalCodeLabel";
            PostalCodeLabel.Size = new Size(73, 15);
            PostalCodeLabel.TabIndex = 1;
            PostalCodeLabel.Text = "Postal Code:";
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PostalCodeTextBox.Location = new Point(141, 274);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(330, 23);
            PostalCodeTextBox.TabIndex = 2;
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerIDLabel.Location = new Point(31, 74);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(73, 15);
            CustomerIDLabel.TabIndex = 1;
            CustomerIDLabel.Text = "CustomerID:";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerIDTextBox.Location = new Point(141, 71);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(330, 23);
            CustomerIDTextBox.TabIndex = 2;
            // 
            // ContactNameLabel
            // 
            ContactNameLabel.AutoSize = true;
            ContactNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactNameLabel.Location = new Point(31, 132);
            ContactNameLabel.Name = "ContactNameLabel";
            ContactNameLabel.Size = new Size(87, 15);
            ContactNameLabel.TabIndex = 1;
            ContactNameLabel.Text = "Contact Name:";
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNameLabel.Location = new Point(31, 103);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(97, 15);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "Company Name:";
            // 
            // ContactNameTextBox
            // 
            ContactNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactNameTextBox.Location = new Point(141, 129);
            ContactNameTextBox.Name = "ContactNameTextBox";
            ContactNameTextBox.Size = new Size(330, 23);
            ContactNameTextBox.TabIndex = 2;
            // 
            // CompanyNameTextBox
            // 
            CompanyNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNameTextBox.Location = new Point(141, 100);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.Size = new Size(330, 23);
            CompanyNameTextBox.TabIndex = 2;
            // 
            // ContactTitleLabel
            // 
            ContactTitleLabel.AutoSize = true;
            ContactTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactTitleLabel.Location = new Point(31, 161);
            ContactTitleLabel.Name = "ContactTitleLabel";
            ContactTitleLabel.Size = new Size(77, 15);
            ContactTitleLabel.TabIndex = 1;
            ContactTitleLabel.Text = "Contact Title:";
            // 
            // ContactTitleTextBox
            // 
            ContactTitleTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactTitleTextBox.Location = new Point(141, 158);
            ContactTitleTextBox.Name = "ContactTitleTextBox";
            ContactTitleTextBox.Size = new Size(330, 23);
            ContactTitleTextBox.TabIndex = 2;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CountryLabel.Location = new Point(31, 306);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CountryTextBox.Location = new Point(141, 303);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(330, 23);
            CountryTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(31, 335);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(44, 15);
            PhoneLabel.TabIndex = 1;
            PhoneLabel.Text = "Phone:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTextBox.Location = new Point(141, 332);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(330, 23);
            PhoneTextBox.TabIndex = 2;
            // 
            // PictureGroupBox
            // 
            PictureGroupBox.Controls.Add(PictureBox);
            PictureGroupBox.Location = new Point(31, 369);
            PictureGroupBox.Name = "PictureGroupBox";
            PictureGroupBox.Size = new Size(270, 270);
            PictureGroupBox.TabIndex = 3;
            PictureGroupBox.TabStop = false;
            PictureGroupBox.Text = "Picture:";
            // 
            // PictureBox
            // 
            PictureBox.BorderStyle = BorderStyle.FixedSingle;
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 19);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(264, 248);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // ChooseImageButton
            // 
            ChooseImageButton.Location = new Point(321, 389);
            ChooseImageButton.Name = "ChooseImageButton";
            ChooseImageButton.Size = new Size(150, 55);
            ChooseImageButton.TabIndex = 4;
            ChooseImageButton.Text = "Choose Image";
            ChooseImageButton.UseVisualStyleBackColor = true;
            ChooseImageButton.Click += ChooseImageButton_Click;
            // 
            // ClearImageButton
            // 
            ClearImageButton.Location = new Point(321, 485);
            ClearImageButton.Name = "ClearImageButton";
            ClearImageButton.Size = new Size(150, 55);
            ClearImageButton.TabIndex = 4;
            ClearImageButton.Text = "Clear Image";
            ClearImageButton.UseVisualStyleBackColor = true;
            ClearImageButton.Click += ClearImageButton_Click;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(321, 581);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(150, 55);
            ExecuteButton.TabIndex = 4;
            ExecuteButton.Text = "Execute";
            ExecuteButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CustomerForm_CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 653);
            Controls.Add(ExecuteButton);
            Controls.Add(ClearImageButton);
            Controls.Add(ChooseImageButton);
            Controls.Add(PictureGroupBox);
            Controls.Add(ContactTitleTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(ContactTitleLabel);
            Controls.Add(PostalCodeLabel);
            Controls.Add(CompanyNameTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(ContactNameTextBox);
            Controls.Add(RegionTextBox);
            Controls.Add(CompanyNameLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(ContactNameLabel);
            Controls.Add(RegionLabel);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(CustomerIDLabel);
            Controls.Add(AddressTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(panel1);
            Name = "CustomerForm_CRUD";
            Text = "Customer Form Execute";
            Load += CustomerForm_CRUD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PictureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label AddressLabel;
        private TextBox AddressTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label RegionLabel;
        private TextBox RegionTextBox;
        private Label PostalCodeLabel;
        private TextBox PostalCodeTextBox;
        private Label CustomerIDLabel;
        private TextBox CustomerIDTextBox;
        private Label ContactNameLabel;
        private Label CompanyNameLabel;
        private TextBox ContactNameTextBox;
        private TextBox CompanyNameTextBox;
        private Label ContactTitleLabel;
        private TextBox ContactTitleTextBox;
        private Label CountryLabel;
        private TextBox CountryTextBox;
        private Label PhoneLabel;
        private TextBox PhoneTextBox;
        private GroupBox PictureGroupBox;
        private PictureBox PictureBox;
        private Button ChooseImageButton;
        private Button ClearImageButton;
        private Button ExecuteButton;
        private OpenFileDialog openFileDialog1;
    }
}