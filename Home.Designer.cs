namespace LoginandCreateacountCsharp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_Dangxuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salary_BTN = new System.Windows.Forms.Button();
            this.ADDEmPloyyee_Btn = new System.Windows.Forms.Button();
            this.DASHBOARD_BTN = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addEmployee1 = new LoginandCreateacountCsharp.AddEmployee();
            this.dashBoard1 = new LoginandCreateacountCsharp.DashBoard();
            this.salary1 = new LoginandCreateacountCsharp.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_Dangxuat.ForeColor = System.Drawing.Color.White;
            this.btn_Dangxuat.Location = new System.Drawing.Point(12, 559);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Size = new System.Drawing.Size(81, 32);
            this.btn_Dangxuat.TabIndex = 2;
            this.btn_Dangxuat.Text = "Sign Out";
            this.btn_Dangxuat.UseVisualStyleBackColor = false;
            this.btn_Dangxuat.Click += new System.EventHandler(this.btn_Dangxuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 39);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1226, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.Salary_BTN);
            this.panel2.Controls.Add(this.ADDEmPloyyee_Btn);
            this.panel2.Controls.Add(this.DASHBOARD_BTN);
            this.panel2.Controls.Add(this.btn_Dangxuat);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 613);
            this.panel2.TabIndex = 4;
            // 
            // Salary_BTN
            // 
            this.Salary_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Salary_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salary_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Salary_BTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Salary_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Salary_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Salary_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_BTN.ForeColor = System.Drawing.Color.White;
            this.Salary_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salary_BTN.Location = new System.Drawing.Point(7, 479);
            this.Salary_BTN.Name = "Salary_BTN";
            this.Salary_BTN.Size = new System.Drawing.Size(209, 55);
            this.Salary_BTN.TabIndex = 6;
            this.Salary_BTN.Text = "SALARY";
            this.Salary_BTN.UseVisualStyleBackColor = false;
            this.Salary_BTN.Click += new System.EventHandler(this.Salary_BTN_Click);
            // 
            // ADDEmPloyyee_Btn
            // 
            this.ADDEmPloyyee_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ADDEmPloyyee_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDEmPloyyee_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ADDEmPloyyee_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ADDEmPloyyee_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ADDEmPloyyee_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ADDEmPloyyee_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDEmPloyyee_Btn.ForeColor = System.Drawing.Color.White;
            this.ADDEmPloyyee_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ADDEmPloyyee_Btn.Location = new System.Drawing.Point(7, 386);
            this.ADDEmPloyyee_Btn.Name = "ADDEmPloyyee_Btn";
            this.ADDEmPloyyee_Btn.Size = new System.Drawing.Size(209, 55);
            this.ADDEmPloyyee_Btn.TabIndex = 5;
            this.ADDEmPloyyee_Btn.Text = "ADD EMPLOYEE";
            this.ADDEmPloyyee_Btn.UseVisualStyleBackColor = false;
            this.ADDEmPloyyee_Btn.Click += new System.EventHandler(this.ADDEmPloyyee_Btn_Click);
            // 
            // DASHBOARD_BTN
            // 
            this.DASHBOARD_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.DASHBOARD_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DASHBOARD_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DASHBOARD_BTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DASHBOARD_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DASHBOARD_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DASHBOARD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARD_BTN.ForeColor = System.Drawing.Color.White;
            this.DASHBOARD_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DASHBOARD_BTN.Location = new System.Drawing.Point(7, 297);
            this.DASHBOARD_BTN.Name = "DASHBOARD_BTN";
            this.DASHBOARD_BTN.Size = new System.Drawing.Size(209, 55);
            this.DASHBOARD_BTN.TabIndex = 4;
            this.DASHBOARD_BTN.Text = "DASHBOARD";
            this.DASHBOARD_BTN.UseVisualStyleBackColor = false;
            this.DASHBOARD_BTN.Click += new System.EventHandler(this.DASHBOARD_BTN_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.White;
            this.greet_user.Location = new System.Drawing.Point(68, 168);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(87, 16);
            this.greet_user.TabIndex = 3;
            this.greet_user.Text = "Welcom, User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::LoginandCreateacountCsharp.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Controls.Add(this.dashBoard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Location = new System.Drawing.Point(225, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 675);
            this.panel3.TabIndex = 5;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1042, 675);
            this.addEmployee1.TabIndex = 0;
            // 
            // dashBoard1
            // 
            this.dashBoard1.Location = new System.Drawing.Point(0, 0);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(1042, 675);
            this.dashBoard1.TabIndex = 1;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(1042, 701);
            this.salary1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 652);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Dangxuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DASHBOARD_BTN;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button Salary_BTN;
        private System.Windows.Forms.Button ADDEmPloyyee_Btn;
        private System.Windows.Forms.Panel panel3;
        private Salary salary1;
        private DashBoard dashBoard1;
        private AddEmployee addEmployee1;
    }
}