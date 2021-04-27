namespace QuanLyNhaHang
{
    partial class frmCapNhatMonAn
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
            this.lblDichVuKhachSan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoatCapNhatDichVu = new System.Windows.Forms.Button();
            this.dgvCapNhatMonAn = new System.Windows.Forms.DataGridView();
            this.textTT = new System.Windows.Forms.TextBox();
            this.textMNMA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textGB = new System.Windows.Forms.TextBox();
            this.textDVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textTTP = new System.Windows.Forms.TextBox();
            this.textMTP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXoaMonAn = new System.Windows.Forms.Button();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.btnLuuCapNhatMonAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDichVuKhachSan
            // 
            this.lblDichVuKhachSan.AutoSize = true;
            this.lblDichVuKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVuKhachSan.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuKhachSan.Location = new System.Drawing.Point(296, 10);
            this.lblDichVuKhachSan.Name = "lblDichVuKhachSan";
            this.lblDichVuKhachSan.Size = new System.Drawing.Size(325, 47);
            this.lblDichVuKhachSan.TabIndex = 0;
            this.lblDichVuKhachSan.Text = "Món Ăn Nhà Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnThoatCapNhatDichVu
            // 
            this.btnThoatCapNhatDichVu.BackColor = System.Drawing.Color.Lime;
            this.btnThoatCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatDichVu.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnThoatCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatDichVu.Location = new System.Drawing.Point(12, 11);
            this.btnThoatCapNhatDichVu.Name = "btnThoatCapNhatDichVu";
            this.btnThoatCapNhatDichVu.Size = new System.Drawing.Size(101, 45);
            this.btnThoatCapNhatDichVu.TabIndex = 2;
            this.btnThoatCapNhatDichVu.Text = "Trở Về";
            this.btnThoatCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnThoatCapNhatDichVu.Click += new System.EventHandler(this.btnThoatCapNhatDichVu_Click);
            // 
            // dgvCapNhatMonAn
            // 
            this.dgvCapNhatMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatMonAn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatMonAn.Location = new System.Drawing.Point(132, 216);
            this.dgvCapNhatMonAn.Name = "dgvCapNhatMonAn";
            this.dgvCapNhatMonAn.ReadOnly = true;
            this.dgvCapNhatMonAn.RowHeadersWidth = 51;
            this.dgvCapNhatMonAn.Size = new System.Drawing.Size(589, 140);
            this.dgvCapNhatMonAn.TabIndex = 6;
            // 
            // textTT
            // 
            this.textTT.Location = new System.Drawing.Point(597, 107);
            this.textTT.Name = "textTT";
            this.textTT.Size = new System.Drawing.Size(120, 20);
            this.textTT.TabIndex = 49;
            // 
            // textMNMA
            // 
            this.textMNMA.Location = new System.Drawing.Point(597, 73);
            this.textMNMA.Name = "textMNMA";
            this.textMNMA.Size = new System.Drawing.Size(120, 20);
            this.textMNMA.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Trạng Thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Mã Nhóm Món Ăn";
            // 
            // textGB
            // 
            this.textGB.Location = new System.Drawing.Point(283, 168);
            this.textGB.Name = "textGB";
            this.textGB.Size = new System.Drawing.Size(124, 20);
            this.textGB.TabIndex = 45;
            // 
            // textDVT
            // 
            this.textDVT.Location = new System.Drawing.Point(283, 136);
            this.textDVT.Name = "textDVT";
            this.textDVT.Size = new System.Drawing.Size(124, 20);
            this.textDVT.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "Giá Bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Đơn Vị Tính";
            // 
            // textTTP
            // 
            this.textTTP.Location = new System.Drawing.Point(283, 104);
            this.textTTP.Name = "textTTP";
            this.textTTP.Size = new System.Drawing.Size(124, 20);
            this.textTTP.TabIndex = 41;
            // 
            // textMTP
            // 
            this.textMTP.Location = new System.Drawing.Point(283, 73);
            this.textMTP.Name = "textMTP";
            this.textMTP.Size = new System.Drawing.Size(124, 20);
            this.textMTP.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tên Thực Phẩm    ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 38;
            this.label11.Text = "Mã Thực Phẩm";
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.BackColor = System.Drawing.Color.White;
            this.btnXoaMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMonAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787424;
            this.btnXoaMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMonAn.Location = new System.Drawing.Point(549, 143);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(72, 45);
            this.btnXoaMonAn.TabIndex = 37;
            this.btnXoaMonAn.Text = "Xóa ";
            this.btnXoaMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMonAn.UseVisualStyleBackColor = false;
            this.btnXoaMonAn.Click += new System.EventHandler(this.btnXoaMonAn_Click);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.BackColor = System.Drawing.Color.White;
            this.btnThemMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btnThemMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMonAn.Location = new System.Drawing.Point(446, 143);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(85, 45);
            this.btnThemMonAn.TabIndex = 36;
            this.btnThemMonAn.Text = "Thêm ";
            this.btnThemMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMonAn.UseVisualStyleBackColor = false;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // btnLuuCapNhatMonAn
            // 
            this.btnLuuCapNhatMonAn.BackColor = System.Drawing.Color.White;
            this.btnLuuCapNhatMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatMonAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Save_278762;
            this.btnLuuCapNhatMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatMonAn.Location = new System.Drawing.Point(637, 143);
            this.btnLuuCapNhatMonAn.Name = "btnLuuCapNhatMonAn";
            this.btnLuuCapNhatMonAn.Size = new System.Drawing.Size(69, 45);
            this.btnLuuCapNhatMonAn.TabIndex = 35;
            this.btnLuuCapNhatMonAn.Text = "Lưu";
            this.btnLuuCapNhatMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatMonAn.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatMonAn.Click += new System.EventHandler(this.btnLuuCapNhatMonAn_Click);
            // 
            // frmCapNhatMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 428);
            this.Controls.Add(this.textTT);
            this.Controls.Add(this.textMNMA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textGB);
            this.Controls.Add(this.textDVT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textTTP);
            this.Controls.Add(this.textMTP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnXoaMonAn);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.btnLuuCapNhatMonAn);
            this.Controls.Add(this.dgvCapNhatMonAn);
            this.Controls.Add(this.btnThoatCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDichVuKhachSan);
            this.Name = "frmCapNhatMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Món Ăn";
            this.Load += new System.EventHandler(this.frmCapNhatMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDichVuKhachSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoatCapNhatDichVu;
        private System.Windows.Forms.DataGridView dgvCapNhatMonAn;
        private System.Windows.Forms.TextBox textTT;
        private System.Windows.Forms.TextBox textMNMA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textGB;
        private System.Windows.Forms.TextBox textDVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTTP;
        private System.Windows.Forms.TextBox textMTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoaMonAn;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.Button btnLuuCapNhatMonAn;
    }
}