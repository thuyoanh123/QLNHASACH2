using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLNHA_SACH
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        public string maNV;
        doimatkhau fDoiMatKhau;
        private void nhanvien_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            Form1 f = new Form1();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }
        public void enableControl(int maLTK)
        {
            switch (maLTK)
            {
                case 1: //admin
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
                case 2: //Nhan vien bang hang
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = false;
                    btnSanPham.Enabled = false;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = false;
                    break;
                case 3: //Nhan vien quan li kho
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnTaoHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
                default:
                    btnDangXuat.Enabled = false;
                    btnDoiMK.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = false;
                    btnSanPham.Enabled = false;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnTaoHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
            }
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fDoiMatKhau == null)
            {
                fDoiMatKhau = new doimatkhau();
                fDoiMatKhau.MdiParent = this;
                fDoiMatKhau.WindowState = FormWindowState.Maximized;
                fDoiMatKhau.Show();
            }
            else
            {
                fDoiMatKhau.Activate();
                fDoiMatKhau.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*foreach(Form f in.Mdichildren)
            {
                f.Close();

            }
            Form1_Load(sender, e);*/
        }
    }
    
}


       