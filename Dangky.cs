using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LoginandCreateacountCsharp
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)// check tai khoan mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em) // check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            string TenTk = txtTenTaiKhoan.Text;
            string MK = txtMatKhau.Text;
            string xnMK = txtXacNhanMatKhau.Text;
            string email = txtEmail.Text;
            if (!CheckAccount(TenTk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            // Kiểm tra mật khẩu
            if (!CheckAccount(MK))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            // Kiểm tra xác nhận mật khẩu
            if (xnMK != MK)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }
            // Kiểm tra email
            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
                return;
            }
            // Kiểm tra email đã tồn tại
            if (modify.taikhoans("select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác");
                return;
            }
            // Thực hiện đăng ký
            try
            {
                string query = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email) VALUES ('" + TenTk + "', '" + MK + "', '" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi đăng ký: " + ex.Message);
            }







        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();     
        }
    }
}
