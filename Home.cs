using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginandCreateacountCsharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("are u sure u want to Logout ?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login LoginForm = new Login();
                LoginForm.Show();
                this.Hide();    
            }
        }

        private void DASHBOARD_BTN_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
        }

        private void ADDEmPloyyee_Btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployee1.Visible=true;
            salary1.Visible = false;
        }

        private void Salary_BTN_Click(object sender, EventArgs e)
        {
            salary1.Visible=true;
            dashBoard1.Visible=false;
           addEmployee1 .Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
