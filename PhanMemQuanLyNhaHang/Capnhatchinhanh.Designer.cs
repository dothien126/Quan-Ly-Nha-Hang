namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatChiNhanh
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
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnSuaChiNhanh = new System.Windows.Forms.Button();
            this.btnXoaChiNhanh = new System.Windows.Forms.Button();
            this.btnThemChiNhanh = new System.Windows.Forms.Button();
            this.btnTroVeCuaCapNhatLichLamViec = new System.Windows.Forms.Button();
            this.dgvCapNhatChiNhanh = new System.Windows.Forms.DataGridView();
            this.tb_tenChiNhanh = new System.Windows.Forms.TextBox();
            this.tb_maChiNhanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_diaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.lblChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(270, 15);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(472, 44);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Các Chi Nhánh Của Nhà Hàng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1458, 255);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(244, 292);
            this.txtGhiChu.TabIndex = 14;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(1545, 221);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 22);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // btnSuaChiNhanh
            // 
            this.btnSuaChiNhanh.BackColor = System.Drawing.Color.White;
            this.btnSuaChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiNhanh.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Save_2787623;
            this.btnSuaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaChiNhanh.Location = new System.Drawing.Point(473, 93);
            this.btnSuaChiNhanh.Name = "btnSuaChiNhanh";
            this.btnSuaChiNhanh.Size = new System.Drawing.Size(84, 35);
            this.btnSuaChiNhanh.TabIndex = 13;
            this.btnSuaChiNhanh.Text = "Sửa ";
            this.btnSuaChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaChiNhanh.UseVisualStyleBackColor = false;
            this.btnSuaChiNhanh.Click += new System.EventHandler(this.btnSuaChiNhanh_Click);
            // 
            // btnXoaChiNhanh
            // 
            this.btnXoaChiNhanh.BackColor = System.Drawing.Color.White;
            this.btnXoaChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiNhanh.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Remove_2787425;
            this.btnXoaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaChiNhanh.Location = new System.Drawing.Point(473, 155);
            this.btnXoaChiNhanh.Name = "btnXoaChiNhanh";
            this.btnXoaChiNhanh.Size = new System.Drawing.Size(83, 34);
            this.btnXoaChiNhanh.TabIndex = 12;
            this.btnXoaChiNhanh.Text = "Xóa ";
            this.btnXoaChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaChiNhanh.UseVisualStyleBackColor = false;
            this.btnXoaChiNhanh.Click += new System.EventHandler(this.btnXoaChiNhanh_Click);
            // 
            // btnThemChiNhanh
            // 
            this.btnThemChiNhanh.BackColor = System.Drawing.Color.White;
            this.btnThemChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiNhanh.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Stock_Index_Up_2788124;
            this.btnThemChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemChiNhanh.Location = new System.Drawing.Point(619, 93);
            this.btnThemChiNhanh.Name = "btnThemChiNhanh";
            this.btnThemChiNhanh.Size = new System.Drawing.Size(83, 35);
            this.btnThemChiNhanh.TabIndex = 11;
            this.btnThemChiNhanh.Text = "Thêm ";
            this.btnThemChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemChiNhanh.UseVisualStyleBackColor = false;
            this.btnThemChiNhanh.Click += new System.EventHandler(this.btnThemChiNhanh_Click);
            // 
            // btnTroVeCuaCapNhatLichLamViec
            // 
            this.btnTroVeCuaCapNhatLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTroVeCuaCapNhatLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCapNhatLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaCapNhatLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCapNhatLichLamViec.Location = new System.Drawing.Point(12, 15);
            this.btnTroVeCuaCapNhatLichLamViec.Name = "btnTroVeCuaCapNhatLichLamViec";
            this.btnTroVeCuaCapNhatLichLamViec.Size = new System.Drawing.Size(101, 45);
            this.btnTroVeCuaCapNhatLichLamViec.TabIndex = 10;
            this.btnTroVeCuaCapNhatLichLamViec.Text = "Trở về";
            this.btnTroVeCuaCapNhatLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCapNhatLichLamViec.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCapNhatLichLamViec.Click += new System.EventHandler(this.btnTroVeCuaCapNhatLichLamViec_Click);
            // 
            // dgvCapNhatChiNhanh
            // 
            this.dgvCapNhatChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatChiNhanh.Location = new System.Drawing.Point(171, 234);
            this.dgvCapNhatChiNhanh.Name = "dgvCapNhatChiNhanh";
            this.dgvCapNhatChiNhanh.RowHeadersWidth = 51;
            this.dgvCapNhatChiNhanh.Size = new System.Drawing.Size(541, 200);
            this.dgvCapNhatChiNhanh.TabIndex = 16;
            this.dgvCapNhatChiNhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapNhatChiNhanh_CellContentClick);
            // 
            // tb_tenChiNhanh
            // 
            this.tb_tenChiNhanh.Location = new System.Drawing.Point(286, 134);
            this.tb_tenChiNhanh.Name = "tb_tenChiNhanh";
            this.tb_tenChiNhanh.Size = new System.Drawing.Size(124, 20);
            this.tb_tenChiNhanh.TabIndex = 30;
            // 
            // tb_maChiNhanh
            // 
            this.tb_maChiNhanh.Location = new System.Drawing.Point(287, 96);
            this.tb_maChiNhanh.Name = "tb_maChiNhanh";
            this.tb_maChiNhanh.Size = new System.Drawing.Size(124, 20);
            this.tb_maChiNhanh.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Chi Nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã Chi Nhánh";
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.Location = new System.Drawing.Point(287, 169);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.Size = new System.Drawing.Size(124, 20);
            this.tb_diaChi.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Địa chỉ";
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.White;
            this.btHuy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Synchronize_2788322;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(618, 155);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(84, 34);
            this.btHuy.TabIndex = 33;
            this.btHuy.Text = "Reset";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // frmCapNhatChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 475);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.tb_diaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tenChiNhanh);
            this.Controls.Add(this.tb_maChiNhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCapNhatChiNhanh);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnSuaChiNhanh);
            this.Controls.Add(this.btnXoaChiNhanh);
            this.Controls.Add(this.btnThemChiNhanh);
            this.Controls.Add(this.btnTroVeCuaCapNhatLichLamViec);
            this.Controls.Add(this.lblChiNhanh);
            this.Name = "frmCapNhatChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Chi Nhánh Nhà Hàng";
            this.Load += new System.EventHandler(this.frmCapNhatChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatChiNhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.Button btnTroVeCuaCapNhatLichLamViec;
        private System.Windows.Forms.Button btnThemChiNhanh;
        private System.Windows.Forms.Button btnSuaChiNhanh;
        private System.Windows.Forms.Button btnXoaChiNhanh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DataGridView dgvCapNhatChiNhanh;
        private System.Windows.Forms.TextBox tb_tenChiNhanh;
        private System.Windows.Forms.TextBox tb_maChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_diaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
    }
}