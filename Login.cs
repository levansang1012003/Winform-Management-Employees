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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string TK = txtTaikhoan.Text;
            string MK = txtMatKhau.Text;
            if (TK.Trim() == "") { MessageBox.Show("vui long nhập tên tài khoản ");  }
            else if (MK.Trim() =="") { MessageBox.Show("vui long nhập Mật khẩu "); }
            else
            {
               
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + TK + "' and MatKhau ='" + MK + "'";
                if (modify.taikhoans(query).Count>0)
                {
                    MessageBox.Show(" Đăng nhập thành công ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Tên tài khoản hoặc mật khẩu không chính xác ");

                }
            }

        }

        private void linkLabel1_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();
          
            this.Show();
            

        }

        private void linkLabel2_Dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dangky = new Dangky();
             this.Hide();
            dangky.ShowDialog();
           
            this.Show();

           

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
