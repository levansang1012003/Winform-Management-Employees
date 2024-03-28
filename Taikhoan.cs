using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginandCreateacountCsharp
{
     class Taikhoan
    {
        private string TenTaiKhoan;
        private string MatKhau;

        public Taikhoan()
        {

        }

        public Taikhoan(string tenTaiKhoan, string matKhau)
        {
           this.TenTaiKhoan= tenTaiKhoan;
           this.MatKhau = matKhau;
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
