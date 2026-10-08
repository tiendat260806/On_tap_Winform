using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình ListView
            lsvVatTu.View = View.Details;
            lsvVatTu.FullRowSelect = true;
            lsvVatTu.GridLines = true;
            lsvVatTu.MultiSelect = false;

            // Nạp danh sách đơn vị tính
            cboDonViTinh.Items.Clear();
            cboDonViTinh.Items.AddRange(new string[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonViTinh.SelectedIndex = 0;
        }

        // 2. Chức năng "Thêm mới"
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal donGia)) return;

            string maVT = txtMaVT.Text.Trim();

            // Kiểm tra trùng Mã VT trong ListView
            if (KiemTraTrungMa(maVT))
            {
                MessageBox.Show($"Mã vật tư '{maVT}' đã tồn tại trong danh sách!", "Cảnh báo trùng lặp",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            // Tạo ListViewItem mới với cột đầu tiên là Mã VT
            ListViewItem item = new ListViewItem(maVT);
            item.SubItems.Add(txtTenVT.Text.Trim());
            item.SubItems.Add(cboDonViTinh.SelectedItem.ToString());
            item.SubItems.Add(donGia.ToString("N0"));

            lsvVatTu.Items.Add(item);
            XoaKhungNhapLieu();
        }

        // 3. Sự kiện Chọn (Select) 1 dòng trong ListView
        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvVatTu.SelectedItems[0];

                txtMaVT.Text = item.SubItems[0].Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDonViTinh.SelectedItem = item.SubItems[2].Text;

                // Loại bỏ dấu phân cách hàng nghìn khi đưa lại vào TextBox Đơn giá
                string donGiaStr = item.SubItems[3].Text.Replace(",", "").Replace(".", "");
                txtDonGia.Text = donGiaStr;

                // Khóa ô Mã VT không cho chỉnh sửa khi đang cập nhật
                txtMaVT.Enabled = false;
            }
        }

        // 4. Chức năng "Cập nhật"
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trong danh sách để cập nhật!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(out decimal donGia)) return;

            ListViewItem item = lsvVatTu.SelectedItems[0];
            item.SubItems[1].Text = txtTenVT.Text.Trim();
            item.SubItems[2].Text = cboDonViTinh.SelectedItem.ToString();
            item.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thông tin vật tư thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            XoaKhungNhapLieu();
        }

        // 5. Chức năng "Xóa dòng"
        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư đang chọn?", "Xác nhận xóa",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Remove(lsvVatTu.SelectedItems[0]);
                XoaKhungNhapLieu();
            }
        }

        // 6. Chức năng "Xóa toàn bộ"
        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.Items.Count == 0) return;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn XÓA TẤT CẢ danh mục vật tư?", "Xác nhận xóa toàn bộ",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Clear();
                XoaKhungNhapLieu();
            }
        }

        #region Các hàm bổ trợ (Helper Methods)

        private bool KiemTraTrungMa(string maVT)
        {
            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateInput(out decimal donGia)
        {
            donGia = 0;

            if (string.IsNullOrWhiteSpace(txtMaVT.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã vật tư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên vật tư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số hợp lệ (>= 0)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void XoaKhungNhapLieu()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            if (cboDonViTinh.Items.Count > 0) cboDonViTinh.SelectedIndex = 0;

            txtMaVT.Enabled = true;
            txtMaVT.Focus();
        }

        #endregion
    }
}