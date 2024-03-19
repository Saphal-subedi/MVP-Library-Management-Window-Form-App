namespace ProjectWork.View
{
    partial class LogInForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            Show = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.admin_Page;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(356, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 446);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 43);
            label1.TabIndex = 1;
            label1.Text = "Admin Login Page";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.Location = new Point(83, 88);
            UserName.Name = "UserName";
            UserName.Size = new Size(186, 46);
            UserName.TabIndex = 2;
            UserName.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(12, 150);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(329, 51);
            txtUserName.TabIndex = 3;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(12, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(329, 51);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 214);
            label2.Name = "label2";
            label2.Size = new Size(171, 46);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Show.Location = new Point(161, 332);
            Show.Name = "Show";
            Show.Size = new Size(180, 32);
            Show.TabIndex = 6;
            Show.Text = "Show Password";
            Show.UseVisualStyleBackColor = true;
            Show.CheckedChanged += Show_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(105, 383);
            button1.Name = "button1";
            button1.Size = new Size(138, 55);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Show);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(UserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LogInForm";
            Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label UserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private CheckBox Show;
        private Button button1;
    }
}