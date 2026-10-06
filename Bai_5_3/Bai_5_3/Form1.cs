using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bai_5_3
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();

            products = new List<Product>();

            bindingSource = new BindingSource();
            bindingSource.DataSource = products;

            dgvProducts.DataSource = bindingSource;

            CauHinhDataGridView();

            cboCategory.Items.Add("Điện thoại");
            cboCategory.Items.Add("Laptop");
            cboCategory.Items.Add("Phụ kiện");

            dgvProducts.CellClick += dgvProducts_CellClick;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnTimKiem.Click += btnTimKiem_Click;
        }

        private void CauHinhDataGridView()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect = false;

            dgvProducts.ReadOnly = true;

            dgvProducts.AllowUserToAddRows = false;

            dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
            dgvProducts.Columns["ProductName"].HeaderText = "Tên SP";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn giá";
            dgvProducts.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProducts.Columns["Category"].HeaderText = "Danh mục";

            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return;
            }

            Product product = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Category = cboCategory.Text
            };

            products.Add(product);

            bindingSource.ResetBindings(false);

            XoaTrang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!KiemTraDuLieu())
            {
                return;
            }

            Product product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product != null)
            {
                product.ProductId = txtProductId.Text.Trim();
                product.ProductName = txtProductName.Text.Trim();
                product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                product.Quantity = int.Parse(txtQuantity.Text);
                product.Category = cboCategory.Text;

                bindingSource.ResetBindings(false);

                XoaTrang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Product product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product != null)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    products.Remove(product);

                    bindingSource.ResetBindings(false);

                    XoaTrang();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtProductName.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                bindingSource.DataSource = products;
                return;
            }

            List<Product> ketQua = products
                .Where(p => p.ProductName
                .IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            bindingSource.DataSource = ketQua;
        }

        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Product product =
                dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;

            if (product != null)
            {
                txtProductId.Text = product.ProductId;
                txtProductName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantity.Text = product.Quantity.ToString();
                cboCategory.Text = product.Category;
            }
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sản phẩm."
                );

                txtProductId.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên sản phẩm."
                );

                txtProductName.Focus();

                return false;
            }

            decimal donGia;

            if (!decimal.TryParse(txtUnitPrice.Text, out donGia)
                || donGia < 0)
            {
                MessageBox.Show(
                    "Đơn giá không hợp lệ."
                );

                txtUnitPrice.Focus();

                return false;
            }

            int soLuong;

            if (!int.TryParse(txtQuantity.Text, out soLuong)
                || soLuong < 0)
            {
                MessageBox.Show(
                    "Số lượng không hợp lệ."
                );

                txtQuantity.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(cboCategory.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn danh mục."
                );

                cboCategory.Focus();

                return false;
            }

            return true;
        }

        private void XoaTrang()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();

            cboCategory.SelectedIndex = -1;

            txtProductId.Focus();
        }
    }
}