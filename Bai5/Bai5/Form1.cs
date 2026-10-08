using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai5
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
            // Bật KeyPreview để Form nhận diện phím tắt hệ thống (F2, Delete)
            this.KeyPreview = true;

            // Khởi chạy Timer hiển thị thời gian hệ thống
            timerSystem.Interval = 1000;
            timerSystem.Enabled = true;
            timerSystem_Tick(null, null);

            // Nạp danh sách ComboBox Vận chuyển
            cboLoaiVanChuyen.Items.Clear();
            cboLoaiVanChuyen.Items.AddRange(new string[] { "Đường bộ", "Đường hàng không", "Chuyển phát nhanh" });
            cboLoaiVanChuyen.SelectedIndex = 0;

            // Cấu hình cột Thành tiền chỉ đọc (ReadOnly)
            if (dgvChiTiet.Columns.Contains("colThanhTien"))
            {
                dgvChiTiet.Columns["colThanhTien"].ReadOnly = true;
            }

            CapNhatStatusStrip();
        }

        // 2. Timer cập nhật đồng hồ hệ thống realtime ở StatusStrip
        private void timerSystem_Tick(object sender, EventArgs e)
        {
            lblTrangThaiThoiGian.Text = $"Thời gian: {DateTime.Now:HH:mm:ss dd/MM/yyyy}";
        }

        // 3. Tự động tính Thành tiền = Số lượng * Đơn giá & Cập nhật StatusStrip khi dữ liệu ô thay đổi
        private void dgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            // Nếu thay đổi ở cột Số lượng hoặc Đơn giá
            if (e.ColumnIndex == colSoLuong.Index || e.ColumnIndex == colDonGia.Index)
            {
                decimal.TryParse(Convert.ToString(row.Cells["colSoLuong"].Value), out decimal soLuong);
                decimal.TryParse(Convert.ToString(row.Cells["colDonGia"].Value), out decimal donGia);

                row.Cells["colThanhTien"].Value = (soLuong * donGia).ToString("N0");
            }

            CapNhatStatusStrip();
        }

        // 4. Validate Số lượng & Trọng lượng phải > 0 với ErrorProvider / StatusStrip
        private void dgvChiTiet_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvChiTiet.Rows[e.RowIndex].IsNewRow) return;

            string colName = dgvChiTiet.Columns[e.ColumnIndex].Name;

            if (colName == "colSoLuong" || colName == "colTrongLuong")
            {
                string valueStr = e.FormattedValue.ToString().Trim();

                if (string.IsNullOrEmpty(valueStr) || !decimal.TryParse(valueStr, out decimal val) || val <= 0)
                {
                    string msgLoi = colName == "colSoLuong"
                        ? "Số lượng phải là số lớn hơn 0!"
                        : "Trọng lượng phải là số lớn hơn 0!";

                    dgvChiTiet.Rows[e.RowIndex].ErrorText = msgLoi;
                    lblTrangThaiThoiGian.Text = $"[CẢNH BÁO LỖI] {msgLoi}";
                }
                else
                {
                    dgvChiTiet.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        // 5. Hàm tính toán tổng số lượng, tổng trọng lượng và tổng tiền hiển thị lên StatusStrip
        private void CapNhatStatusStrip()
        {
            int tongSoLuong = 0;
            decimal tongTrongLuong = 0m;
            decimal tongTien = 0m;

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;

                int.TryParse(Convert.ToString(row.Cells["colSoLuong"].Value), out int sl);
                decimal.TryParse(Convert.ToString(row.Cells["colTrongLuong"].Value), out decimal tl);

                string thanhTienStr = Convert.ToString(row.Cells["colThanhTien"].Value)?.Replace(",", "").Replace(".", "");
                decimal.TryParse(thanhTienStr, out decimal tt);

                tongSoLuong += sl;
                tongTrongLuong += tl;
                tongTien += tt;
            }

            lblTongSoLuong.Text = $"Tổng SL: {tongSoLuong:N0}";
            lblTongTrongLuong.Text = $"Tổng TL: {tongTrongLuong:N1} kg";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        // 6. Xử lý phím tắt F2 (Thêm dòng mới) và Delete (Xóa dòng)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn F2: Thêm dòng mới vào DataGridView
            if (e.KeyCode == Keys.F2)
            {
                // Nếu đang chỉnh sửa ô, kết thúc chỉnh sửa trước khi tạo dòng mới
                if (dgvChiTiet.IsCurrentCellInEditMode)
                {
                    dgvChiTiet.EndEdit();
                }

                dgvChiTiet.Focus();

                // Thêm một dòng mới
                int newRowIdx = dgvChiTiet.Rows.Add();

                // Đưa con trỏ nhấp nháy vào ô Tên hàng hóa
                dgvChiTiet.CurrentCell = dgvChiTiet.Rows[newRowIdx].Cells["colTenHang"];
                dgvChiTiet.BeginEdit(true);

                e.Handled = true;
            }
            // Nhấn phím Delete: Xóa dòng đang chọn
            else if (e.KeyCode == Keys.Delete && !dgvChiTiet.IsCurrentCellInEditMode)
            {
                if (dgvChiTiet.CurrentRow != null && !dgvChiTiet.CurrentRow.IsNewRow)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đang chọn?", "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dgvChiTiet.Rows.Remove(dgvChiTiet.CurrentRow);
                        CapNhatStatusStrip();
                    }
                    e.Handled = true;
                }
            }
        }

        // Sự kiện xóa dòng trực tiếp từ thao tác người dùng
        private void dgvChiTiet_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CapNhatStatusStrip();
        }

        private void lblTrangThaiThoiGian_Click(object sender, EventArgs e)
        {
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}