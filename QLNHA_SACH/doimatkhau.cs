using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHA_SACH.Modules;

namespace QLNHA_SACH
{
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, "");
            errorProvider1.SetError(txtConfirmPass, "");
            if (txtPassNew.Text.Length < 8 || !txtPassNew.Text.Any(char.IsDigit) || !txtPassNew.Text.Any(char.IsLower) || !txtPassNew.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtPassNew, "Mật khẩu mới tối thiểu 8 kí tự, gồm chữ số, " + "in thường, in hoa.");
                return;
            }
            if (txtPassNew.Text != txtConfirmPass.Text)
            {
                errorProvider1.SetError(txtConfirmPass, "Mật khẩu nhập lại không trùng!!!");
                return;
            }
            nhanvien f = (nhanvien)this.MdiParent;
            int count =XLBANG.Thuc_hien_lenh("Update NHANVIEN set Password =' " + txtPassNew.Text + "' where MaNV = '" + f.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Mật khẩu không hợp lệ!!!");
        }

        private void bntCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



