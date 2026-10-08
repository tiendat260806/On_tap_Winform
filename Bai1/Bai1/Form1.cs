using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // 1. Validation: Kiểm tra dữ liệu nhập liệu
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ là một số hợp lệ (>= 0)!",
                                "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách là số nguyên lớn hơn 0!",
                                "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // Nếu người dùng không nhập % giảm giá, mặc định coi là 0%
            string giamGiaText = txtGiamGia.Text.Trim();
            if (string.IsNullOrEmpty(giamGiaText))
            {
                giamGiaText = "0";
            }

            if (!decimal.TryParse(giamGiaText, out decimal phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
            {
                MessageBox.Show("Mã giảm giá phải là số nằm trong khoảng từ 0% đến 100%!",
                                "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return;
            }

            // 2. Tính toán theo công thức:
            // TongTien = (DonGia * SoLuong) * (100 - %Giam) / 100
            decimal tongTien = (donGia * soLuong) * (100 - phanTramGiam) / 100m;

            // 3. Hiển thị kết quả ra Label (định dạng theo tiền tệ Việt Nam)
            lblTongTien.Text = $"Tổng tiền thanh toán: {tongTien:N0} VNĐ";
        }

        // Sự kiện Click của nút "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Text = "0";
            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";

            // Đưa con trỏ chuột về ô nhập liệu đầu tiên
            txtDonGia.Focus();
        }
    }
}
