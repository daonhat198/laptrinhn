using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TH5_11
{
    public partial class Form1 : Form
    {
        private const bool V = true;
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        private List<DichVu> danhSachDichVu = new List<DichVu>();
        private List<HoaDon> danhSachHoaDon = new List<HoaDon>();
        private int maKhachHangCounter = 1;
        private int maHoaDonCounter = 1;
        private List<DichVu> dichVuChon = new List<DichVu>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            BindDataToGridViews();
            this.tbKhachHang.SelectionChanged += new System.EventHandler(this.tbKhachHang_SelectionChanged);

        }

        private void LoadData()
        {
            // Tạo dữ liệu mẫu cho khách hàng và dịch vụ
            danhSachKhachHang.Add(new KhachHang { MaKH = 1, TenKH = "Dao Dinh Nhat", SoDT = "0983385873", DiaChi = "75 Ho Tung Mau" });
            danhSachKhachHang.Add(new KhachHang { MaKH = 2, TenKH = "Nguyen Anh Tuan", SoDT = "0123456789", DiaChi = "175 Co Nhue 2" });
            danhSachDichVu.Add(new DichVu { MaDV = 1, TenDV = "Dich vu 1", GiaTien = 100000 });
            danhSachDichVu.Add(new DichVu { MaDV = 2, TenDV = "Dich vu 2", GiaTien = 150000 });
            danhSachDichVu.Add(new DichVu { MaDV = 3, TenDV = "Dich vu 3", GiaTien = 2000000 });
        }

        private void BindDataToGridViews()
        {
            // Gắn dữ liệu vào DataGridView
            tbKhachHang.DataSource = null;
            tbKhachHang.DataSource = danhSachKhachHang;

            tbDichVu.DataSource = null;
            tbDichVu.DataSource = danhSachDichVu;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KhachHang khachHangMoi = new KhachHang
            {
                MaKH = danhSachKhachHang.Count + 1,
                TenKH = txtID.Text,
                SoDT = txtPhone.Text,
                DiaChi = txtAddress.Text
            };

            danhSachKhachHang.Add(khachHangMoi);
            BindDataToGridViews();
            txtID.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbKhachHang.SelectedRows.Count > 0)
            {
                int selectedIndex = tbKhachHang.SelectedRows[0].Index;
                KhachHang khachHang = danhSachKhachHang[selectedIndex];

                // Cập nhật thông tin khách hàng
                khachHang.TenKH = txtID.Text;
                khachHang.SoDT = txtPhone.Text;
                khachHang.DiaChi = txtAddress.Text;

                BindDataToGridViews();
                txtID.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbKhachHang.SelectedRows.Count > 0)
            {
                int selectedIndex = tbKhachHang.SelectedRows[0].Index;
                danhSachKhachHang.RemoveAt(selectedIndex);
                BindDataToGridViews();
            }
        }

        private void btnTaohoadon_Click(object sender, EventArgs e)
        {
            if (tbKhachHang.SelectedRows.Count > 0)
            {
                dichVuChon.Clear(); // Xóa danh sách dịch vụ đã chọn trước đó

                int selectedIndex = tbKhachHang.SelectedRows[0].Index;
                KhachHang khachHang = danhSachKhachHang[selectedIndex];

                // Lấy các dịch vụ đã chọn
                foreach (DataGridViewRow row in tbDichVu.SelectedRows)
                {
                    int maDV = (int)row.Cells["MaDV"].Value;
                    DichVu dv = danhSachDichVu.FirstOrDefault(d => d.MaDV == maDV);
                    if (dv != null) dichVuChon.Add(dv);
                }

                // Tạo hóa đơn mới
                HoaDon hoaDonMoi = new HoaDon
                {
                    MaHD = danhSachHoaDon.Count + 1,
                    KhachHang = khachHang,
                    DichVus = dichVuChon
                };

                danhSachHoaDon.Add(hoaDonMoi);

                // Thêm thông tin hóa đơn vào ListBox mà không xóa các mục cũ
                tbListDichVu.Items.Add($"Hóa đơn #{hoaDonMoi.MaHD} cho {khachHang.TenKH}");

                // Thêm chi tiết dịch vụ vào ListBox
                foreach (var dv in dichVuChon)
                {
                    tbListDichVu.Items.Add($"  {dv.TenDV} - {dv.GiaTien:C}");
                }

                // Hiển thị thông báo hóa đơn thành công
                MessageBox.Show($"Hóa đơn được tạo thành công!\nTổng tiền: {hoaDonMoi.TongTien:C}");

                // Làm trống các TextBox sau khi tạo hóa đơn
                txtID.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
            }
        }

        private void tbKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (tbKhachHang.SelectedRows.Count > 0)
            {
                int selectedIndex = tbKhachHang.SelectedRows[0].Index; // Lấy chỉ số hàng được chọn
                KhachHang khachHang = danhSachKhachHang[selectedIndex]; // Lấy khách hàng tương ứng từ danh sách

                // Hiển thị thông tin khách hàng lên các TextBox
                txtID.Text = khachHang.TenKH;
                txtPhone.Text = khachHang.SoDT;
                txtAddress.Text = khachHang.DiaChi;
            }
        }

        private void tbListDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbListDichVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbListDichVu.SelectionMode = SelectionMode.MultiSimple;
            tbListDichVu.HorizontalScrollbar = true;

            // Thêm nhiều mục vào ListBox
            tbListDichVu.Items.Clear();
            foreach (var dv in dichVuChon)
            {
                tbListDichVu.Items.Add($"{dv.TenDV} - {dv.GiaTien:C}");
            }

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
    }
}
