namespace Learn_CSharp_EFCore_Beginner
{
    partial class LoginForm
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            ShowHidePoasswordCheckBox = new CheckBox();
            LogInButton = new Button();
            CancelButton = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 168);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(491, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.Crimson;
            toolStripStatusLabel1.Image = Properties.Resources.play_4_24;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(55, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(179, 15);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(65, 15);
            UserNameLabel.TabIndex = 2;
            UserNameLabel.Text = "UserName:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(247, 12);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(233, 23);
            UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(247, 45);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(233, 23);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(184, 48);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(60, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // ShowHidePoasswordCheckBox
            // 
            ShowHidePoasswordCheckBox.AutoSize = true;
            ShowHidePoasswordCheckBox.Location = new Point(247, 78);
            ShowHidePoasswordCheckBox.Name = "ShowHidePoasswordCheckBox";
            ShowHidePoasswordCheckBox.Size = new Size(108, 19);
            ShowHidePoasswordCheckBox.TabIndex = 3;
            ShowHidePoasswordCheckBox.Text = "Show Password";
            ShowHidePoasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(247, 113);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(115, 49);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "LogIn";
            LogInButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(365, 113);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(115, 49);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // LoginForm
            // 
            AcceptButton = LogInButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 190);
            ControlBox = false;
            Controls.Add(CancelButton);
            Controls.Add(LogInButton);
            Controls.Add(ShowHidePoasswordCheckBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private Label UserNameLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private CheckBox ShowHidePoasswordCheckBox;
        private Button LogInButton;
        private Button CancelButton;
    }
}