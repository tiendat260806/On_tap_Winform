namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.gbMucDoUuTien = new System.Windows.Forms.GroupBox();
            this.rdoKhanCap = new System.Windows.Forms.RadioButton();
            this.rdoThap = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.picAnhLoi = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.gbMucDoUuTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(123, 25);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(183, 20);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // txtNguoiYeuCau
            // 
            this.txtNguoiYeuCau.Location = new System.Drawing.Point(123, 56);
            this.txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(183, 20);
            this.txtNguoiYeuCau.TabIndex = 1;
            // 
            // dtpNgayGhiNhan
            // 
            this.dtpNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGhiNhan.Location = new System.Drawing.Point(123, 87);
            this.dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            this.dtpNgayGhiNhan.Size = new System.Drawing.Size(183, 20);
            this.dtpNgayGhiNhan.TabIndex = 2;
            // 
            // gbMucDoUuTien
            // 
            this.gbMucDoUuTien.Controls.Add(this.rdoKhanCap);
            this.gbMucDoUuTien.Controls.Add(this.rdoThap);
            this.gbMucDoUuTien.Controls.Add(this.rdoTrungBinh);
            this.gbMucDoUuTien.Location = new System.Drawing.Point(28, 131);
            this.gbMucDoUuTien.Name = "gbMucDoUuTien";
            this.gbMucDoUuTien.Size = new System.Drawing.Size(278, 47);
            this.gbMucDoUuTien.TabIndex = 3;
            this.gbMucDoUuTien.TabStop = false;
            this.gbMucDoUuTien.Text = "Mức độ ưu tiên";
            // 
            // rdoKhanCap
            // 
            this.rdoKhanCap.AutoSize = true;
            this.rdoKhanCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhanCap.Location = new System.Drawing.Point(186, 19);
            this.rdoKhanCap.Name = "rdoKhanCap";
            this.rdoKhanCap.Size = new System.Drawing.Size(79, 19);
            this.rdoKhanCap.TabIndex = 6;
            this.rdoKhanCap.TabStop = true;
            this.rdoKhanCap.Text = "Khẩn Cấp";
            this.rdoKhanCap.UseVisualStyleBackColor = true;
            // 
            // rdoThap
            // 
            this.rdoThap.AutoSize = true;
            this.rdoThap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThap.Location = new System.Drawing.Point(18, 19);
            this.rdoThap.Name = "rdoThap";
            this.rdoThap.Size = new System.Drawing.Size(53, 19);
            this.rdoThap.TabIndex = 4;
            this.rdoThap.TabStop = true;
            this.rdoThap.Text = "Thấp";
            this.rdoThap.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            this.rdoTrungBinh.AutoSize = true;
            this.rdoTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrungBinh.Location = new System.Drawing.Point(86, 19);
            this.rdoTrungBinh.Name = "rdoTrungBinh";
            this.rdoTrungBinh.Size = new System.Drawing.Size(85, 19);
            this.rdoTrungBinh.TabIndex = 5;
            this.rdoTrungBinh.TabStop = true;
            this.rdoTrungBinh.Text = "Trung Bình";
            this.rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // cboLoaiSuCo
            // 
            this.cboLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSuCo.FormattingEnabled = true;
            this.cboLoaiSuCo.Location = new System.Drawing.Point(452, 24);
            this.cboLoaiSuCo.Name = "cboLoaiSuCo";
            this.cboLoaiSuCo.Size = new System.Drawing.Size(183, 21);
            this.cboLoaiSuCo.TabIndex = 7;
            // 
            // chkMayTinhBan
            // 
            this.chkMayTinhBan.AutoSize = true;
            this.chkMayTinhBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayTinhBan.Location = new System.Drawing.Point(357, 64);
            this.chkMayTinhBan.Name = "chkMayTinhBan";
            this.chkMayTinhBan.Size = new System.Drawing.Size(96, 19);
            this.chkMayTinhBan.TabIndex = 8;
            this.chkMayTinhBan.Text = "Máy tính bàn";
            this.chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Người yêu cầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày tiếp nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại sự cố";
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLaptop.Location = new System.Drawing.Point(357, 90);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(64, 19);
            this.chkLaptop.TabIndex = 12;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            this.chkMayIn.AutoSize = true;
            this.chkMayIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayIn.Location = new System.Drawing.Point(357, 116);
            this.chkMayIn.Name = "chkMayIn";
            this.chkMayIn.Size = new System.Drawing.Size(62, 19);
            this.chkMayIn.TabIndex = 13;
            this.chkMayIn.Text = "Máy in";
            this.chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDienThoai.Location = new System.Drawing.Point(357, 142);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(82, 19);
            this.chkDienThoai.TabIndex = 14;
            this.chkDienThoai.Text = "Điện thoại";
            this.chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            this.picAnhLoi.Location = new System.Drawing.Point(473, 51);
            this.picAnhLoi.Name = "picAnhLoi";
            this.picAnhLoi.Size = new System.Drawing.Size(146, 98);
            this.picAnhLoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhLoi.TabIndex = 15;
            this.picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnh.Location = new System.Drawing.Point(502, 155);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(75, 23);
            this.btnTaiAnh.TabIndex = 16;
            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiYeuCau.Location = new System.Drawing.Point(231, 203);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(75, 23);
            this.btnGuiYeuCau.TabIndex = 17;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Location = new System.Drawing.Point(346, 203);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btnNhapLai.TabIndex = 18;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 331);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.picAnhLoi);
            this.Controls.Add(this.chkDienThoai);
            this.Controls.Add(this.gbMucDoUuTien);
            this.Controls.Add(this.chkMayIn);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.dtpNgayGhiNhan);
            this.Controls.Add(this.chkMayTinhBan);
            this.Controls.Add(this.txtNguoiYeuCau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLoaiSuCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Tiếp nhận & Phân loại sự cố IT (IT Support Ticket Form)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMucDoUuTien.ResumeLayout(false);
            this.gbMucDoUuTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.GroupBox gbMucDoUuTien;
        private System.Windows.Forms.RadioButton rdoThap;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoKhanCap;
        private System.Windows.Forms.ComboBox cboLoaiSuCo;
        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.PictureBox picAnhLoi;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnNhapLai;
    }
}