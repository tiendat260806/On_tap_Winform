using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi Form vừa load
        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboLoaiSuCo.Items.Count == 0)
            {
                cboLoaiSuCo.Items.AddRange(new string[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            }
            cboLoaiSuCo.SelectedIndex = 0;
            rdoTrungBinh.Checked = true;
        }

        // 2. Xử lý nút "Tải ảnh lỗi"
        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh chụp lỗi sự cố";
                openFileDialog.Filter = "Tệp hình ảnh (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        // 3. Xử lý nút "Gửi yêu cầu"
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên người yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            // Lấy mức độ ưu tiên
            string mucDoUuTien = "Thấp";
            if (rdoTrungBinh.Checked) mucDoUuTien = "Trung bình";
            else if (rdoKhanCap.Checked) mucDoUuTien = "Khẩn cấp";

            // Lấy danh sách thiết bị ảnh hưởng
            List<string> thietBiList = new List<string>();
            if (chkMayTinhBan.Checked) thietBiList.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBiList.Add("Laptop");
            if (chkMayIn.Checked) thietBiList.Add("Máy in");
            if (chkDienThoai.Checked) thietBiList.Add("Điện thoại");

            string danhSachThietBi = thietBiList.Count > 0
                ? string.Join(", ", thietBiList)
                : "Không chọn";

            string trangThaiAnh = picAnhLoi.Image != null ? "Đã đính kèm" : "Chưa có ảnh";

            string tongHop = $"--- THÔNG TIN PHIẾU YÊU CẦU IT ---\n\n" +
                             $"• Mã phiếu: {txtMaPhieu.Text.Trim()}\n" +
                             $"• Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}\n" +
                             $"• Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}\n" +
                             $"• Mức độ ưu tiên: {mucDoUuTien}\n" +
                             $"• Loại sự cố: {cboLoaiSuCo.SelectedItem}\n" +
                             $"• Thiết bị ảnh hưởng: {danhSachThietBi}\n" +
                             $"• Ảnh lỗi: {trangThaiAnh}";

            MessageBox.Show(tongHop, "Xác nhận gửi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 4. Xử lý nút "Nhập lại"
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;

            rdoTrungBinh.Checked = true;
            if (cboLoaiSuCo.Items.Count > 0) cboLoaiSuCo.SelectedIndex = 0;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }

            txtMaPhieu.Focus();
        }
    }
}