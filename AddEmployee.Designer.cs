namespace LoginandCreateacountCsharp
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addemployee_BtnPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_Deletebtn = new System.Windows.Forms.Button();
            this.addEmployee_ClearBtn = new System.Windows.Forms.Button();
            this.addEmployee_Updatebtn = new System.Windows.Forms.Button();
            this.addEmployee_Addbtn = new System.Windows.Forms.Button();
            this.addEmployee_Importbtn = new System.Windows.Forms.Button();
            this.addEmployee_Picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_Status = new System.Windows.Forms.ComboBox();
            this.addEmployee_Gender = new System.Windows.Forms.ComboBox();
            this.addEmployee_PhoneNumber = new System.Windows.Forms.TextBox();
            this.addEmployee_FullName = new System.Windows.Forms.TextBox();
            this.addEmployee_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 298);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1028, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.Addemployee_BtnPosition);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployee_Deletebtn);
            this.panel2.Controls.Add(this.addEmployee_ClearBtn);
            this.panel2.Controls.Add(this.addEmployee_Updatebtn);
            this.panel2.Controls.Add(this.addEmployee_Addbtn);
            this.panel2.Controls.Add(this.addEmployee_Importbtn);
            this.panel2.Controls.Add(this.addEmployee_Picture);
            this.panel2.Controls.Add(this.addEmployee_Status);
            this.panel2.Controls.Add(this.addEmployee_Gender);
            this.panel2.Controls.Add(this.addEmployee_PhoneNumber);
            this.panel2.Controls.Add(this.addEmployee_FullName);
            this.panel2.Controls.Add(this.addEmployee_ID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 282);
            this.panel2.TabIndex = 1;
            // 
            // Addemployee_BtnPosition
            // 
            this.Addemployee_BtnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addemployee_BtnPosition.FormattingEnabled = true;
            this.Addemployee_BtnPosition.Items.AddRange(new object[] {
            "Business Management",
            "Front-End Developer",
            "Back-end Developer",
            "Data Adminstrator",
            "Ul/UX Design"});
            this.Addemployee_BtnPosition.Location = new System.Drawing.Point(490, 120);
            this.Addemployee_BtnPosition.Name = "Addemployee_BtnPosition";
            this.Addemployee_BtnPosition.Size = new System.Drawing.Size(173, 24);
            this.Addemployee_BtnPosition.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Position:";
            // 
            // addEmployee_Deletebtn
            // 
            this.addEmployee_Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_Deletebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_Deletebtn.Location = new System.Drawing.Point(391, 163);
            this.addEmployee_Deletebtn.Name = "addEmployee_Deletebtn";
            this.addEmployee_Deletebtn.Size = new System.Drawing.Size(96, 48);
            this.addEmployee_Deletebtn.TabIndex = 15;
            this.addEmployee_Deletebtn.Text = "Delete";
            this.addEmployee_Deletebtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_ClearBtn
            // 
            this.addEmployee_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_ClearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_ClearBtn.Location = new System.Drawing.Point(530, 163);
            this.addEmployee_ClearBtn.Name = "addEmployee_ClearBtn";
            this.addEmployee_ClearBtn.Size = new System.Drawing.Size(96, 48);
            this.addEmployee_ClearBtn.TabIndex = 14;
            this.addEmployee_ClearBtn.Text = "Clear";
            this.addEmployee_ClearBtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_Updatebtn
            // 
            this.addEmployee_Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_Updatebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_Updatebtn.Location = new System.Drawing.Point(261, 163);
            this.addEmployee_Updatebtn.Name = "addEmployee_Updatebtn";
            this.addEmployee_Updatebtn.Size = new System.Drawing.Size(96, 48);
            this.addEmployee_Updatebtn.TabIndex = 13;
            this.addEmployee_Updatebtn.Text = "Update";
            this.addEmployee_Updatebtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_Addbtn
            // 
            this.addEmployee_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_Addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Addbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addEmployee_Addbtn.Location = new System.Drawing.Point(140, 163);
            this.addEmployee_Addbtn.Name = "addEmployee_Addbtn";
            this.addEmployee_Addbtn.Size = new System.Drawing.Size(96, 48);
            this.addEmployee_Addbtn.TabIndex = 12;
            this.addEmployee_Addbtn.Text = "Add";
            this.addEmployee_Addbtn.UseVisualStyleBackColor = false;
            this.addEmployee_Addbtn.Click += new System.EventHandler(this.addEmployee_Addbtn_Click);
            // 
            // addEmployee_Importbtn
            // 
            this.addEmployee_Importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_Importbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Importbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Importbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Importbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_Importbtn.Location = new System.Drawing.Point(874, 166);
            this.addEmployee_Importbtn.Name = "addEmployee_Importbtn";
            this.addEmployee_Importbtn.Size = new System.Drawing.Size(122, 34);
            this.addEmployee_Importbtn.TabIndex = 11;
            this.addEmployee_Importbtn.Text = "Import";
            this.addEmployee_Importbtn.UseVisualStyleBackColor = false;
            this.addEmployee_Importbtn.Click += new System.EventHandler(this.addEmployee_Importbtn_Click);
            // 
            // addEmployee_Picture
            // 
            this.addEmployee_Picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addEmployee_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_Picture.Location = new System.Drawing.Point(874, 16);
            this.addEmployee_Picture.Name = "addEmployee_Picture";
            this.addEmployee_Picture.Size = new System.Drawing.Size(122, 144);
            this.addEmployee_Picture.TabIndex = 10;
            this.addEmployee_Picture.TabStop = false;
            // 
            // addEmployee_Status
            // 
            this.addEmployee_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_Status.FormattingEnabled = true;
            this.addEmployee_Status.Items.AddRange(new object[] {
            "Active",
            "Lanctive",
            "\t"});
            this.addEmployee_Status.Location = new System.Drawing.Point(490, 75);
            this.addEmployee_Status.Name = "addEmployee_Status";
            this.addEmployee_Status.Size = new System.Drawing.Size(173, 24);
            this.addEmployee_Status.TabIndex = 9;
            this.addEmployee_Status.SelectedIndexChanged += new System.EventHandler(this.addEmployee_Position_SelectedIndexChanged);
            // 
            // addEmployee_Gender
            // 
            this.addEmployee_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_Gender.FormattingEnabled = true;
            this.addEmployee_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addEmployee_Gender.Location = new System.Drawing.Point(99, 136);
            this.addEmployee_Gender.Name = "addEmployee_Gender";
            this.addEmployee_Gender.Size = new System.Drawing.Size(173, 24);
            this.addEmployee_Gender.TabIndex = 8;
            this.addEmployee_Gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addEmployee_PhoneNumber
            // 
            this.addEmployee_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_PhoneNumber.Location = new System.Drawing.Point(490, 26);
            this.addEmployee_PhoneNumber.Name = "addEmployee_PhoneNumber";
            this.addEmployee_PhoneNumber.Size = new System.Drawing.Size(173, 22);
            this.addEmployee_PhoneNumber.TabIndex = 7;
            // 
            // addEmployee_FullName
            // 
            this.addEmployee_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_FullName.Location = new System.Drawing.Point(99, 79);
            this.addEmployee_FullName.Name = "addEmployee_FullName";
            this.addEmployee_FullName.Size = new System.Drawing.Size(173, 22);
            this.addEmployee_FullName.TabIndex = 6;
            // 
            // addEmployee_ID
            // 
            this.addEmployee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_ID.Location = new System.Drawing.Point(99, 29);
            this.addEmployee_ID.Name = "addEmployee_ID";
            this.addEmployee_ID.Size = new System.Drawing.Size(173, 22);
            this.addEmployee_ID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1042, 713);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox addEmployee_Status;
        private System.Windows.Forms.ComboBox addEmployee_Gender;
        private System.Windows.Forms.TextBox addEmployee_PhoneNumber;
        private System.Windows.Forms.TextBox addEmployee_FullName;
        private System.Windows.Forms.TextBox addEmployee_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox addEmployee_Picture;
        private System.Windows.Forms.Button addEmployee_Importbtn;
        private System.Windows.Forms.Button addEmployee_Addbtn;
        private System.Windows.Forms.Button addEmployee_Deletebtn;
        private System.Windows.Forms.Button addEmployee_ClearBtn;
        private System.Windows.Forms.Button addEmployee_Updatebtn;
        private System.Windows.Forms.ComboBox Addemployee_BtnPosition;
        private System.Windows.Forms.Label label7;
    }
}
