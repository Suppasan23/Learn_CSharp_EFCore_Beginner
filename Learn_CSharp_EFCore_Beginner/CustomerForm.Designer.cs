namespace Learn_CSharp_EFCore_Beginner
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutMyAPpToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            StatusToolStripStatusLabel = new ToolStripStatusLabel();
            LogInToolStripStatusLabel = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddNewButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            ExportToExcelButton = new Button();
            KeywordTextBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(3, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1233, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(151, 26);
            addNewToolStripMenuItem.Text = "Add new";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(151, 26);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(151, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(151, 26);
            logoutToolStripMenuItem.Text = "Log-out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(151, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMyAPpToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMyAPpToolStripMenuItem
            // 
            aboutMyAPpToolStripMenuItem.Name = "aboutMyAPpToolStripMenuItem";
            aboutMyAPpToolStripMenuItem.Size = new Size(187, 26);
            aboutMyAPpToolStripMenuItem.Text = "About my app";
            aboutMyAPpToolStripMenuItem.Click += aboutMyAPpToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusToolStripStatusLabel, LogInToolStripStatusLabel });
            statusStrip1.Location = new Point(3, 1107);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1233, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusToolStripStatusLabel
            // 
            StatusToolStripStatusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatusToolStripStatusLabel.ForeColor = Color.ForestGreen;
            StatusToolStripStatusLabel.Image = Properties.Resources.play_4_24;
            StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
            StatusToolStripStatusLabel.Size = new Size(70, 20);
            StatusToolStripStatusLabel.Text = "Status";
            // 
            // LogInToolStripStatusLabel
            // 
            LogInToolStripStatusLabel.Name = "LogInToolStripStatusLabel";
            LogInToolStripStatusLabel.Size = new Size(18, 20);
            LogInToolStripStatusLabel.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 354F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AddNewButton, 0, 0);
            tableLayoutPanel1.Controls.Add(UpdateButton, 1, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 2, 0);
            tableLayoutPanel1.Controls.Add(SearchButton, 3, 0);
            tableLayoutPanel1.Controls.Add(ExportToExcelButton, 5, 0);
            tableLayoutPanel1.Controls.Add(KeywordTextBox, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 6, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 30);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1233, 47);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // AddNewButton
            // 
            AddNewButton.Dock = DockStyle.Fill;
            AddNewButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewButton.Location = new Point(3, 4);
            AddNewButton.Margin = new Padding(1);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(112, 39);
            AddNewButton.TabIndex = 1;
            AddNewButton.Text = "Add New";
            AddNewButton.UseVisualStyleBackColor = true;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Fill;
            UpdateButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(117, 4);
            UpdateButton.Margin = new Padding(1);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(112, 39);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(231, 4);
            DeleteButton.Margin = new Padding(1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 39);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Fill;
            SearchButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(345, 4);
            SearchButton.Margin = new Padding(1);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 39);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ExportToExcelButton
            // 
            ExportToExcelButton.BackColor = Color.OliveDrab;
            ExportToExcelButton.Dock = DockStyle.Fill;
            ExportToExcelButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExportToExcelButton.ForeColor = SystemColors.Window;
            ExportToExcelButton.Location = new Point(813, 4);
            ExportToExcelButton.Margin = new Padding(1);
            ExportToExcelButton.Name = "ExportToExcelButton";
            ExportToExcelButton.Size = new Size(147, 39);
            ExportToExcelButton.TabIndex = 5;
            ExportToExcelButton.Text = "Export To Excel";
            ExportToExcelButton.UseVisualStyleBackColor = false;
            ExportToExcelButton.Click += ExportToExcelButton_Click;
            // 
            // KeywordTextBox
            // 
            KeywordTextBox.Dock = DockStyle.Fill;
            KeywordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KeywordTextBox.Location = new Point(459, 4);
            KeywordTextBox.Margin = new Padding(1);
            KeywordTextBox.Name = "KeywordTextBox";
            KeywordTextBox.Size = new Size(352, 34);
            KeywordTextBox.TabIndex = 0;
            KeywordTextBox.DoubleClick += KeywordTextBox_DoubleClick;
            KeywordTextBox.KeyDown += KeywordTextBox_KeyDown;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(962, 4);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(147, 39);
            label1.TabIndex = 6;
            label1.Text = "C# EFCore";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 77);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1233, 1030);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addNewToolStripMenuItem1, updateToolStripMenuItem1, deleteToolStripMenuItem1, viewToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(141, 100);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // addNewToolStripMenuItem1
            // 
            addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            addNewToolStripMenuItem1.Size = new Size(140, 24);
            addNewToolStripMenuItem1.Text = "Add New";
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(140, 24);
            updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(140, 24);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(140, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 1133);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            Padding = new Padding(3, 0, 3, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Form";
            FormClosing += CustomerForm_FormClosing;
            Load += CustomerForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutMyAPpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusToolStripStatusLabel;
        private ToolStripStatusLabel LogInToolStripStatusLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddNewButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button SearchButton;
        private Button ExportToExcelButton;
        private TextBox KeywordTextBox;
        private Label label1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addNewToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}