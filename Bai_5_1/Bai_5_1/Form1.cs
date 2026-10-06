using System;
using System.Windows.Forms;

namespace Bai_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dtpNgaySinh.MaxDate = DateTime.Today;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Xoa tat ca loi cu
            epCheck.Clear();

            bool hopLe = true;

            // Kiem tra ten dang nhap
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                epCheck.SetError(
                    txtTenDangNhap,
                    "Ten dang nhap khong duoc de trong."
                );

                hopLe = false;
            }

            // Kiem tra mat khau
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(
                    txtMatKhau,
                    "Mat khau khong duoc de trong."
                );

                hopLe = false;
            }

            // Kiem tra xac nhan mat khau
            if (txtXacNhanMatKhau.Text != txtMatKhau.Text)
            {
                epCheck.SetError(
                    txtXacNhanMatKhau,
                    "Mat khau xac nhan khong khop."
                );

                hopLe = false;
            }

            // Kiem tra do tuoi
            int tuoi = TinhTuoi(dtpNgaySinh.Value);

            if (tuoi < 18)
            {
                epCheck.SetError(
                    dtpNgaySinh,
                    "Nguoi dang ky phai du 18 tuoi."
                );

                hopLe = false;
            }

            // Kiem tra dieu khoan
            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(
                    chkDieuKhoan,
                    "Ban phai dong y voi dieu khoan dich vu."
                );

                hopLe = false;
            }

            // Neu tat ca hop le
            if (hopLe)
            {
                MessageBox.Show(
                    "Dang ky tai khoan thanh cong!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private int TinhTuoi(DateTime ngaySinh)
        {
            DateTime homNay = DateTime.Today;

            int tuoi = homNay.Year - ngaySinh.Year;

            if (ngaySinh.Date > homNay.AddYears(-tuoi))
            {
                tuoi--;
            }

            return tuoi;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();

            dtpNgaySinh.Value = DateTime.Today;

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            chkDieuKhoan.Checked = false;

            epCheck.Clear();

            txtTenDangNhap.Focus();
        }
    }
}