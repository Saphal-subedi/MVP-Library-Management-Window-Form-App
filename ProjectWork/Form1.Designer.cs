namespace ProjectWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnReset = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dtReturned = new DateTimePicker();
            label8 = new Label();
            cbFaculty = new ComboBox();
            label7 = new Label();
            txtBookName = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            txtName = new RichTextBox();
            label4 = new Label();
            txtId = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            label9 = new Label();
            txtSearch = new RichTextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 46);
            label1.TabIndex = 0;
            label1.Text = "Student Library Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(dtReturned);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 445);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 255, 255);
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(438, 363);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 50);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(291, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 255);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(151, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 50);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Lime;
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(6, 363);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 50);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dtReturned
            // 
            dtReturned.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtReturned.Location = new Point(208, 287);
            dtReturned.Name = "dtReturned";
            dtReturned.Size = new Size(419, 38);
            dtReturned.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 287);
            label8.Name = "label8";
            label8.Size = new Size(196, 38);
            label8.TabIndex = 10;
            label8.Text = "Returned Day";
            // 
            // cbFaculty
            // 
            cbFaculty.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "CSIT", "BCA", "BBS", "BBA", "BSW" });
            cbFaculty.Location = new Point(230, 219);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(302, 45);
            cbFaculty.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 222);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 8;
            label7.Text = "Faculty";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookName.Location = new Point(230, 163);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(302, 43);
            txtBookName.TabIndex = 7;
            txtBookName.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 163);
            label5.Name = "label5";
            label5.Size = new Size(171, 38);
            label5.TabIndex = 6;
            label5.Text = "Book Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 191);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(230, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 43);
            txtName.TabIndex = 4;
            txtName.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 98);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(230, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(302, 43);
            txtId.TabIndex = 2;
            txtId.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 132);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 38);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(697, 67);
            label9.Name = "label9";
            label9.Size = new Size(104, 38);
            label9.TabIndex = 2;
            label9.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(807, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(302, 43);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search_icon;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(1125, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 50);
            btnSearch.TabIndex = 17;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(669, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(683, 407);
            dataGridView1.TabIndex = 18;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1377, 561);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox txtBookName;
        private Label label5;
        private Label label6;
        private RichTextBox txtName;
        private Label label4;
        private RichTextBox txtId;
        private Label label3;
        private Label label2;
        private ComboBox cbFaculty;
        private Label label7;
        private ColorDialog colorDialog1;
        private DateTimePicker dtReturned;
        private Label label8;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnReset;
        private Label label9;
        private RichTextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
    }
}
