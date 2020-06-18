using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNHA_SACH.Modules;
namespace QLNHA_SACH
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        XLNHANVIEN tblNhanVien

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
                tblNhanVien = new XLNHANVIEN();
                var r = tblNhanVien.Select("Username='" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
                if (r.Count() > 0)
                {
                    nhanvien f = (nhanvien)this.MdiParent;
                    f.Text = "Quản lí Nhà Sách - Chào" + r[0]["TenNV"].ToString();
                    f.maNV = r[0]["MaNV"].ToString();
                    f.EnableControl((int)r[0]["MaLTK"]);
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tên tài khoản và mật khẩu!!!");
            
        }

        private void simpleButton1_Enter(object sender, EventArgs e)
        {

            simpleButton1_Click(sender, e);
            
        }

        private void simpleButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == (int)Keys.Enter)
                {
                simpleButton1_Click(sender, e);
                }
            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
}
