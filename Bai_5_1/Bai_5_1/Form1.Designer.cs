namespace Bai_5_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpThongTinCaNhan;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;

        private System.Windows.Forms.GroupBox grpThongTinBoSung;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.CheckBox chkDieuKhoan;

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.ErrorProvider epCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.grpThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();

            this.grpThongTinBoSung = new System.Windows.Forms.GroupBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.chkDieuKhoan = new System.Windows.Forms.CheckBox();

            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpThongTinCaNhan.SuspendLayout();
            this.grpThongTinBoSung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTinCaNhan
            // 
            this.grpThongTinCaNhan.Controls.Add(this.lblTenDangNhap);
            this.grpThongTinCaNhan.Controls.Add(this.lblMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.lblXacNhanMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.txtTenDangNhap);
            this.grpThongTinCaNhan.Controls.Add(this.txtMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.txtXacNhanMatKhau);
            this.grpThongTinCaNhan.Location = new System.Drawing.Point(30, 25);
            this.grpThongTinCaNhan.Name = "grpThongTinCaNhan";
            this.grpThongTinCaNhan.Size = new System.Drawing.Size(540, 190);
            this.grpThongTinCaNhan.TabIndex = 0;
            this.grpThongTinCaNhan.TabStop = false;
            this.grpThongTinCaNhan.Text = "Thông tin tài khoản";

            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(30, 35);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(95, 15);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";

            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(30, 80);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(58, 15);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu:";

            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(30, 125);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(111, 15);
            this.lblXacNhanMatKhau.TabIndex = 2;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";

            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(180, 32);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(300, 23);
            this.txtTenDangNhap.TabIndex = 3;

            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(180, 77);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(300, 23);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;

            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(180, 122);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(300, 23);
            this.txtXacNhanMatKhau.TabIndex = 5;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;

            // 
            // grpThongTinBoSung
            // 
            this.grpThongTinBoSung.Controls.Add(this.lblNgaySinh);
            this.grpThongTinBoSung.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinBoSung.Controls.Add(this.lblGioiTinh);
            this.grpThongTinBoSung.Controls.Add(this.rdoNam);
            this.grpThongTinBoSung.Controls.Add(this.rdoNu);
            this.grpThongTinBoSung.Controls.Add(this.chkDieuKhoan);
            this.grpThongTinBoSung.Location = new System.Drawing.Point(30, 230);
            this.grpThongTinBoSung.Name = "grpThongTinBoSung";
            this.grpThongTinBoSung.Size = new System.Drawing.Size(540, 190);
            this.grpThongTinBoSung.TabIndex = 1;
            this.grpThongTinBoSung.TabStop = false;
            this.grpThongTinBoSung.Text = "Thông tin bổ sung";

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(62, 15);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày sinh:";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(180, 30);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaySinh.TabIndex = 1;

            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 80);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(52, 15);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính:";

            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(180, 78);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(51, 19);
            this.rdoNam.TabIndex = 3;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;

            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(260, 78);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(41, 19);
            this.rdoNu.TabIndex = 4;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;

            // 
            // chkDieuKhoan
            // 
            this.chkDieuKhoan.AutoSize = true;
            this.chkDieuKhoan.Location = new System.Drawing.Point(180, 125);
            this.chkDieuKhoan.Name = "chkDieuKhoan";
            this.chkDieuKhoan.Size = new System.Drawing.Size(216, 19);
            this.chkDieuKhoan.TabIndex = 5;
            this.chkDieuKhoan.Text = "Tôi đồng ý với điều khoản dịch vụ";
            this.chkDieuKhoan.UseVisualStyleBackColor = true;

            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(160, 445);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 40);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(320, 445);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.grpThongTinCaNhan);
            this.Controls.Add(this.grpThongTinBoSung);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";

            this.grpThongTinCaNhan.ResumeLayout(false);
            this.grpThongTinCaNhan.PerformLayout();

            this.grpThongTinBoSung.ResumeLayout(false);
            this.grpThongTinBoSung.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();

            this.ResumeLayout(false);
        }
    }
}