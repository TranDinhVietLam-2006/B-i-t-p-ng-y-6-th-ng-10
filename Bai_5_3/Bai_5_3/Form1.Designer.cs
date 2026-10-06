namespace Bai_5_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpChucNang;

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;

        private System.Windows.Forms.ComboBox cboCategory;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.DataGridView dgvProducts;

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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();

            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();

            this.cboCategory = new System.Windows.Forms.ComboBox();

            this.grpChucNang = new System.Windows.Forms.GroupBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.grpThongTin.SuspendLayout();
            this.grpChucNang.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).BeginInit();

            this.SuspendLayout();

            
            this.grpThongTin.Controls.Add(this.lblProductId);
            this.grpThongTin.Controls.Add(this.lblProductName);
            this.grpThongTin.Controls.Add(this.lblUnitPrice);
            this.grpThongTin.Controls.Add(this.lblQuantity);
            this.grpThongTin.Controls.Add(this.lblCategory);

            this.grpThongTin.Controls.Add(this.txtProductId);
            this.grpThongTin.Controls.Add(this.txtProductName);
            this.grpThongTin.Controls.Add(this.txtUnitPrice);
            this.grpThongTin.Controls.Add(this.txtQuantity);

            this.grpThongTin.Controls.Add(this.cboCategory);

            this.grpThongTin.Location =
                new System.Drawing.Point(25, 20);

            this.grpThongTin.Name =
                "grpThongTin";

            this.grpThongTin.Size =
                new System.Drawing.Size(750, 180);

            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text =
                "Thông tin sản phẩm";

            
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location =
                new System.Drawing.Point(30, 35);

            this.lblProductId.Text =
                "Mã SP:";

            
            this.txtProductId.Location =
                new System.Drawing.Point(150, 32);

            this.txtProductId.Size =
                new System.Drawing.Size(220, 23);

            this.txtProductId.Name =
                "txtProductId";

            
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location =
                new System.Drawing.Point(30, 75);

            this.lblProductName.Text =
                "Tên SP:";

             
            this.txtProductName.Location =
                new System.Drawing.Point(150, 72);

            this.txtProductName.Size =
                new System.Drawing.Size(220, 23);

            this.txtProductName.Name =
                "txtProductName";

             
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location =
                new System.Drawing.Point(400, 35);

            this.lblUnitPrice.Text =
                "Đơn giá:";

           
            this.txtUnitPrice.Location =
                new System.Drawing.Point(500, 32);

            this.txtUnitPrice.Size =
                new System.Drawing.Size(200, 23);

            this.txtUnitPrice.Name =
                "txtUnitPrice";

            
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location =
                new System.Drawing.Point(400, 75);

            this.lblQuantity.Text =
                "Số lượng:";

           
            this.txtQuantity.Location =
                new System.Drawing.Point(500, 72);

            this.txtQuantity.Size =
                new System.Drawing.Size(200, 23);

            this.txtQuantity.Name =
                "txtQuantity";

             
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location =
                new System.Drawing.Point(30, 115);

            this.lblCategory.Text =
                "Danh mục:";

             
            this.cboCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboCategory.Location =
                new System.Drawing.Point(150, 112);

            this.cboCategory.Size =
                new System.Drawing.Size(220, 23);

            this.cboCategory.Name =
                "cboCategory";

            
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnTimKiem);

            this.grpChucNang.Location =
                new System.Drawing.Point(25, 215);

            this.grpChucNang.Size =
                new System.Drawing.Size(750, 75);

            this.grpChucNang.Name =
                "grpChucNang";

            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text =
                "Chức năng";

             
            this.btnThem.Location =
                new System.Drawing.Point(30, 28);

            this.btnThem.Size =
                new System.Drawing.Size(120, 30);

            this.btnThem.Name =
                "btnThem";

            this.btnThem.Text =
                "Thêm";

            this.btnThem.UseVisualStyleBackColor =
                true;

             
            this.btnSua.Location =
                new System.Drawing.Point(170, 28);

            this.btnSua.Size =
                new System.Drawing.Size(120, 30);

            this.btnSua.Name =
                "btnSua";

            this.btnSua.Text =
                "Sửa";

            this.btnSua.UseVisualStyleBackColor =
                true;

             
            this.btnXoa.Location =
                new System.Drawing.Point(310, 28);

            this.btnXoa.Size =
                new System.Drawing.Size(120, 30);

            this.btnXoa.Name =
                "btnXoa";

            this.btnXoa.Text =
                "Xóa";

            this.btnXoa.UseVisualStyleBackColor =
                true;

             
            this.btnTimKiem.Location =
                new System.Drawing.Point(450, 28);

            this.btnTimKiem.Size =
                new System.Drawing.Size(120, 30);

            this.btnTimKiem.Name =
                "btnTimKiem";

            this.btnTimKiem.Text =
                "Tìm kiếm";

            this.btnTimKiem.UseVisualStyleBackColor =
                true;

             
            this.dgvProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvProducts.Location =
                new System.Drawing.Point(25, 310);

            this.dgvProducts.Name =
                "dgvProducts";

            this.dgvProducts.Size =
                new System.Drawing.Size(750, 230);

             
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(810, 570);

            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.dgvProducts);

            this.Name =
                "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý danh sách sản phẩm";

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();

            this.grpChucNang.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
