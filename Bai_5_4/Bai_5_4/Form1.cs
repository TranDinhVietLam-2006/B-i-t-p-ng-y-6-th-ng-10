using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class Form1 : Form
    {
        
        private class NhanVien
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public string ChucVu { get; set; }
            public DateTime NgayVaoLam { get; set; }
        }

        
        private Dictionary<string, List<NhanVien>> danhSachNhanVien
            = new Dictionary<string, List<NhanVien>>();

        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            
            imageListTree.Images.Clear();
            imageListTree.Images.Add("company", TaoIcon(Color.DodgerBlue, "C"));
            imageListTree.Images.Add("department", TaoIcon(Color.SeaGreen, "P"));
            imageListTree.Images.Add("group", TaoIcon(Color.Orange, "N"));

            imageListLarge.Images.Clear();
            imageListLarge.Images.Add("employee", TaoIcon(Color.Crimson, "E"));

            imageListSmall.Images.Clear();
            imageListSmall.Images.Add("employee", TaoIcon(Color.Crimson, "e"));

            
            tvDepartments.ImageList = imageListTree;
            tvDepartments.HideSelection = false;

            
            lsvEmployees.View = View.Details;
            lsvEmployees.LargeImageList = imageListLarge;
            lsvEmployees.SmallImageList = imageListSmall;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;

            
            cboViewMode.Items.Clear();
            cboViewMode.Items.AddRange(new object[]
                { "Details", "SmallIcon", "LargeIcon", "Tile" });
            cboViewMode.SelectedIndex = 0;

            
            BuildSampleTree();
        }

        
        private Image TaoIcon(Color mauNen, string chu)
        {
            Bitmap bmp = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                using (SolidBrush br = new SolidBrush(mauNen))
                    g.FillEllipse(br, 1, 1, 30, 30);

                using (SolidBrush br = new SolidBrush(Color.White))
                using (Font f = new Font("Arial", 12, FontStyle.Bold))
                {
                    SizeF sz = g.MeasureString(chu, f);
                    g.DrawString(chu, f, br,
                        (32 - sz.Width) / 2f, (32 - sz.Height) / 2f);
                }
            }
            return bmp;
        }

       
        private void BuildSampleTree()
        {
            
            TreeNode root = new TreeNode("Công ty ABC")
            {
                ImageKey = "company",
                SelectedImageKey = "company",
                Tag = "CongTy"
            };

            
            TreeNode pkt = new TreeNode("Phòng Kỹ Thuật")
            {
                ImageKey = "department",
                SelectedImageKey = "department",
                Tag = "CongTy/PhongKyThuat"
            };

            TreeNode nhomLT = new TreeNode("Nhóm Lập Trình")
            {
                ImageKey = "group",
                SelectedImageKey = "group",
                Tag = "CongTy/PhongKyThuat/NhomLapTrinh"
            };

            TreeNode nhomKT = new TreeNode("Nhóm Kiểm Thử")
            {
                ImageKey = "group",
                SelectedImageKey = "group",
                Tag = "CongTy/PhongKyThuat/NhomKiemThu"
            };

            pkt.Nodes.Add(nhomLT);
            pkt.Nodes.Add(nhomKT);

            
            TreeNode pke = new TreeNode("Phòng Kế Toán")
            {
                ImageKey = "department",
                SelectedImageKey = "department",
                Tag = "CongTy/PhongKeToan"
            };

            TreeNode nhomLuong = new TreeNode("Nhóm Lương")
            {
                ImageKey = "group",
                SelectedImageKey = "group",
                Tag = "CongTy/PhongKeToan/NhomLuong"
            };

            pke.Nodes.Add(nhomLuong);

            
            TreeNode pns = new TreeNode("Phòng Nhân Sự")
            {
                ImageKey = "department",
                SelectedImageKey = "department",
                Tag = "CongTy/PhongNhanSu"
            };

            
            root.Nodes.Add(pkt);
            root.Nodes.Add(pke);
            root.Nodes.Add(pns);

            tvDepartments.Nodes.Add(root);
            root.Expand();

            
            danhSachNhanVien["CongTy"] = new List<NhanVien>();

            danhSachNhanVien["CongTy/PhongKyThuat"] = new List<NhanVien>
            {
                new NhanVien { MaNV="KT001", HoTen="Nguyễn Văn A", ChucVu="Trưởng phòng", NgayVaoLam=new DateTime(2018,5,10) },
                new NhanVien { MaNV="KT002", HoTen="Trần Thị B",   ChucVu="Phó phòng",    NgayVaoLam=new DateTime(2019,3,20) }
            };

            danhSachNhanVien["CongTy/PhongKyThuat/NhomLapTrinh"] = new List<NhanVien>
            {
                new NhanVien { MaNV="LT001", HoTen="Lê Văn C",    ChucVu="Lập trình viên", NgayVaoLam=new DateTime(2021,1,15) },
                new NhanVien { MaNV="LT002", HoTen="Phạm Thị D",  ChucVu="Lập trình viên", NgayVaoLam=new DateTime(2022,6,1) },
                new NhanVien { MaNV="LT003", HoTen="Hoàng Văn E", ChucVu="Senior Dev",     NgayVaoLam=new DateTime(2020,9,10) }
            };

            danhSachNhanVien["CongTy/PhongKyThuat/NhomKiemThu"] = new List<NhanVien>
            {
                new NhanVien { MaNV="KT101", HoTen="Vũ Thị F", ChucVu="Tester",      NgayVaoLam=new DateTime(2022,4,5) },
                new NhanVien { MaNV="KT102", HoTen="Đỗ Văn G", ChucVu="QA Engineer", NgayVaoLam=new DateTime(2021,11,20) }
            };

            danhSachNhanVien["CongTy/PhongKeToan"] = new List<NhanVien>
            {
                new NhanVien { MaNV="KET001", HoTen="Ngô Thị H", ChucVu="Kế toán trưởng", NgayVaoLam=new DateTime(2017,8,1) }
            };

            danhSachNhanVien["CongTy/PhongKeToan/NhomLuong"] = new List<NhanVien>
            {
                new NhanVien { MaNV="L001", HoTen="Bùi Văn I", ChucVu="Kế toán viên", NgayVaoLam=new DateTime(2020,2,12) },
                new NhanVien { MaNV="L002", HoTen="Lý Thị K",  ChucVu="Kế toán viên", NgayVaoLam=new DateTime(2023,7,3) }
            };

            danhSachNhanVien["CongTy/PhongNhanSu"] = new List<NhanVien>
            {
                new NhanVien { MaNV="NS001", HoTen="Trương Văn L", ChucVu="Trưởng phòng NS", NgayVaoLam=new DateTime(2019,10,10) },
                new NhanVien { MaNV="NS002", HoTen="Mai Thị M",    ChucVu="Chuyên viên TS",  NgayVaoLam=new DateTime(2022,1,1) }
            };

            
            foreach (var kvp in danhSachNhanVien)
            {
                if (kvp.Key == "CongTy") continue;
                danhSachNhanVien["CongTy"].AddRange(kvp.Value);
            }

           
            tvDepartments.SelectedNode = root;
        }

      
        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string key = e.Node.Tag as string;
            if (string.IsNullOrEmpty(key)) return;

            lsvEmployees.Items.Clear();

            if (!danhSachNhanVien.ContainsKey(key)) return;

            foreach (var nv in danhSachNhanVien[key])
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.ChucVu);
                item.SubItems.Add(nv.NgayVaoLam.ToString("dd/MM/yyyy"));
                item.ImageKey = "employee";

                lsvEmployees.Items.Add(item);
            }
        }

       
        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboViewMode.SelectedItem.ToString())
            {
                case "Details": lsvEmployees.View = View.Details; break;
                case "SmallIcon": lsvEmployees.View = View.SmallIcon; break;
                case "LargeIcon": lsvEmployees.View = View.LargeIcon; break;
                case "Tile": lsvEmployees.View = View.Tile; break;
            }
        }
    }
}