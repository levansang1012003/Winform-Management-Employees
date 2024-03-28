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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmailDangky.Text;

            if (email.Trim() == "") { MessageBox.Show("vui lòng nhập email"); }
            else
            {
                string query = "SELECT * FROM TaiKhoan WHERE Email = '" + email + "'";
                var taikhoans = modify.taikhoans(query);
                if (taikhoans.Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    // Hiển thị cả tài khoản và mật khẩu
                    label2.Text = "Tài khoản: " + taikhoans[0].TenTaiKhoan1 + " - Mật khẩu: " + taikhoans[0].MatKhau1;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = " Email này chưa được đăng ký";
                    this.Close();
                }

            }
            


        }

        private void label3_Click(object sender, EventArgs e)
        {
          this.Hide();
          
        }
    }
}
