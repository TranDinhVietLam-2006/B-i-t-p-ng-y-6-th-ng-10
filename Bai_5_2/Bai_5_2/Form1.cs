using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_5_2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<Service>> danhSachDichVu;

        public Form1()
        {
            InitializeComponent();

            KhoiTaoDanhSach();

            cboCategory.SelectedIndexChanged +=
                cboCategory_SelectedIndexChanged;

            lstAvailableServices.DoubleClick +=
                lstAvailableServices_DoubleClick;

            btnSelect.Click += btnSelect_Click;
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Click += btnClearAll_Click;

            cboCategory.SelectedIndex = 0;
        }

        private void KhoiTaoDanhSach()
        {
            danhSachDichVu = new Dictionary<string, List<Service>>();

            danhSachDichVu["Khám bệnh"] = new List<Service>
            {
                new Service("Khám tổng quát", 200000),
                new Service("Khám chuyên khoa", 300000),
                new Service("Tái khám", 150000)
            };

            danhSachDichVu["Xét nghiệm"] = new List<Service>
            {
                new Service("Xét nghiệm máu", 100000),
                new Service("Xét nghiệm nước tiểu", 80000),
                new Service("Xét nghiệm đường huyết", 70000)
            };

            danhSachDichVu["Chụp X-Quang"] = new List<Service>
            {
                new Service("X-Quang ngực", 150000),
                new Service("X-Quang xương", 200000),
                new Service("X-Quang cột sống", 250000)
            };

            danhSachDichVu["Vắc-xin"] = new List<Service>
            {
                new Service("Vắc-xin cúm", 300000),
                new Service("Vắc-xin viêm gan B", 250000),
                new Service("Vắc-xin COVID-19", 200000)
            };
        }

        private void cboCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            string category = cboCategory.SelectedItem.ToString();

            foreach (Service service in danhSachDichVu[category])
            {
                lstAvailableServices.Items.Add(service);
            }
        }

        private void btnSelect_Click(
            object sender,
            EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                Service service =
                    (Service)lstAvailableServices.SelectedItem;

                if (!lstSelectedServices.Items.Contains(service))
                {
                    lstSelectedServices.Items.Add(service);
                    lstAvailableServices.Items.Remove(service);
                }

                TinhTien();
            }
        }

        private void lstAvailableServices_DoubleClick(
            object sender,
            EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnRemove_Click(
            object sender,
            EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                Service service =
                    (Service)lstSelectedServices.SelectedItem;

                lstSelectedServices.Items.Remove(service);

                TinhTien();
            }
        }

        private void btnClearAll_Click(
            object sender,
            EventArgs e)
        {
            lstSelectedServices.Items.Clear();

            TinhTien();
        }

        private void TinhTien()
        {
            decimal tongTien = 0;

            foreach (Service service in lstSelectedServices.Items)
            {
                tongTien += service.Gia;
            }

            decimal tyLeChietKhau = 0;

            if (tongTien >= 1000000)
            {
                tyLeChietKhau = 10;
            }
            else if (tongTien >= 500000)
            {
                tyLeChietKhau = 5;
            }

            decimal tienChietKhau =
                tongTien * tyLeChietKhau / 100;

            decimal thanhTien =
                tongTien - tienChietKhau;

            lblTotalValue.Text =
                tongTien.ToString("N0") + " VNĐ";

            lblDiscountValue.Text =
                tyLeChietKhau.ToString("0") + "%";

            lblPaymentValue.Text =
                thanhTien.ToString("N0") + " VNĐ";
        }
    }

    public class Service
    {
        public string Ten { get; set; }

        public decimal Gia { get; set; }

        public Service(string ten, decimal gia)
        {
            Ten = ten;
            Gia = gia;
        }

        public override string ToString()
        {
            return Ten + " - " + Gia.ToString("N0") + " VNĐ";
        }
    }
}