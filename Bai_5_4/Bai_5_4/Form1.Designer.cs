namespace Bai5_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDepartments = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.lsvEmployees = new System.Windows.Forms.ListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayVaoLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblViewMode = new System.Windows.Forms.Label();
            this.cboViewMode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.tvDepartments);
            this.splitContainer1.Panel1MinSize = 200;
            this.splitContainer1.Panel2.Controls.Add(this.lsvEmployees);
            this.splitContainer1.Size = new System.Drawing.Size(984, 561);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 0;

            
            this.tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartments.HideSelection = false;
            this.tvDepartments.ImageIndex = 0;
            this.tvDepartments.ImageList = this.imageListTree;
            this.tvDepartments.Location = new System.Drawing.Point(0, 0);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.SelectedImageIndex = 0;
            this.tvDepartments.Size = new System.Drawing.Size(328, 561);
            this.tvDepartments.TabIndex = 0;
            this.tvDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDepartments_AfterSelect);

            
            this.imageListTree.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;

            
            this.imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;

            
            this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;

            
            this.lsvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaNV, this.colHoTen, this.colChucVu, this.colNgayVaoLam});
            this.lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployees.FullRowSelect = true;
            this.lsvEmployees.GridLines = true;
            this.lsvEmployees.HideSelection = false;
            this.lsvEmployees.LargeImageList = this.imageListLarge;
            this.lsvEmployees.Location = new System.Drawing.Point(0, 0);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.Size = new System.Drawing.Size(652, 561);
            this.lsvEmployees.SmallImageList = this.imageListSmall;
            this.lsvEmployees.TabIndex = 0;
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            this.lsvEmployees.View = System.Windows.Forms.View.Details;

            
            this.colMaNV.Text = "Mã NV";
            this.colMaNV.Width = 80;

            
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 180;

            
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 150;

            
            this.colNgayVaoLam.Text = "Ngày vào làm";
            this.colNgayVaoLam.Width = 120;

            
            this.panelTop.Controls.Add(this.cboViewMode);
            this.panelTop.Controls.Add(this.lblViewMode);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 40);
            this.panelTop.TabIndex = 1;

            
            this.lblViewMode.AutoSize = true;
            this.lblViewMode.Location = new System.Drawing.Point(12, 11);
            this.lblViewMode.Name = "lblViewMode";
            this.lblViewMode.Size = new System.Drawing.Size(71, 16);
            this.lblViewMode.TabIndex = 0;
            this.lblViewMode.Text = "Chế độ xem:";

            
            this.cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewMode.FormattingEnabled = true;
            this.cboViewMode.Location = new System.Drawing.Point(89, 8);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Size = new System.Drawing.Size(150, 24);
            this.cboViewMode.TabIndex = 1;
            this.cboViewMode.SelectedIndexChanged += new System.EventHandler(this.cboViewMode_SelectedIndexChanged);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 5.4 - Quản lý tập tin chuyên nghiệp (TreeView & ListView)";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colNgayVaoLam;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblViewMode;
        private System.Windows.Forms.ComboBox cboViewMode;
    }
}