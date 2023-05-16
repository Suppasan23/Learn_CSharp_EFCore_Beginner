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
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(3, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(121, 22);
            addNewToolStripMenuItem.Text = "Add new";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(121, 22);
            updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(121, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(121, 22);
            logoutToolStripMenuItem.Text = "Log-out";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(121, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMyAPpToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMyAPpToolStripMenuItem
            // 
            aboutMyAPpToolStripMenuItem.Name = "aboutMyAPpToolStripMenuItem";
            aboutMyAPpToolStripMenuItem.Size = new Size(150, 22);
            aboutMyAPpToolStripMenuItem.Text = "About my app";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusToolStripStatusLabel, LogInToolStripStatusLabel });
            statusStrip1.Location = new Point(3, 739);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(978, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusToolStripStatusLabel
            // 
            StatusToolStripStatusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatusToolStripStatusLabel.ForeColor = Color.ForestGreen;
            StatusToolStripStatusLabel.Image = Properties.Resources.play_4_24;
            StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
            StatusToolStripStatusLabel.Size = new Size(56, 17);
            StatusToolStripStatusLabel.Text = "Status";
            // 
            // LogInToolStripStatusLabel
            // 
            LogInToolStripStatusLabel.Name = "LogInToolStripStatusLabel";
            LogInToolStripStatusLabel.Size = new Size(16, 17);
            LogInToolStripStatusLabel.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Info;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AddNewButton, 0, 0);
            tableLayoutPanel1.Controls.Add(UpdateButton, 1, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 2, 0);
            tableLayoutPanel1.Controls.Add(SearchButton, 3, 0);
            tableLayoutPanel1.Controls.Add(ExportToExcelButton, 5, 0);
            tableLayoutPanel1.Controls.Add(KeywordTextBox, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 6, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(978, 35);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // AddNewButton
            // 
            AddNewButton.Dock = DockStyle.Fill;
            AddNewButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewButton.Location = new Point(3, 3);
            AddNewButton.Margin = new Padding(1);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(98, 29);
            AddNewButton.TabIndex = 1;
            AddNewButton.Text = "Add New";
            AddNewButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Fill;
            UpdateButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(103, 3);
            UpdateButton.Margin = new Padding(1);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(98, 29);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(203, 3);
            DeleteButton.Margin = new Padding(1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Fill;
            SearchButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(303, 3);
            SearchButton.Margin = new Padding(1);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(98, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // ExportToExcelButton
            // 
            ExportToExcelButton.BackColor = Color.OliveDrab;
            ExportToExcelButton.Dock = DockStyle.Fill;
            ExportToExcelButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExportToExcelButton.ForeColor = SystemColors.Window;
            ExportToExcelButton.Location = new Point(713, 3);
            ExportToExcelButton.Margin = new Padding(1);
            ExportToExcelButton.Name = "ExportToExcelButton";
            ExportToExcelButton.Size = new Size(128, 29);
            ExportToExcelButton.TabIndex = 5;
            ExportToExcelButton.Text = "Export To Excel";
            ExportToExcelButton.UseVisualStyleBackColor = false;
            // 
            // KeywordTextBox
            // 
            KeywordTextBox.Dock = DockStyle.Fill;
            KeywordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KeywordTextBox.Location = new Point(403, 3);
            KeywordTextBox.Margin = new Padding(1);
            KeywordTextBox.Name = "KeywordTextBox";
            KeywordTextBox.Size = new Size(308, 29);
            KeywordTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(843, 3);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(128, 29);
            label1.TabIndex = 6;
            label1.Text = "C# EFCore";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(978, 680);
            dataGridView1.TabIndex = 7;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CustomerForm";
            Padding = new Padding(3, 0, 3, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}