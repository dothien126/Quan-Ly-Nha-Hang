namespace QuanLyNhaHang
{
    partial class frmNhaCungCap
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTroVeCuaThongKe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCapNhatNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnSuaCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnLuuCapNhatBanAn = new System.Windows.Forms.Button();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Nhà Cung Cấp";
            // 
            // btnTroVeCuaThongKe
            // 
            this.btnTroVeCuaThongKe.BackColor = System.Drawing.Color.Lime;
            this.btnTroVeCuaThongKe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaThongKe.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaThongKe.Location = new System.Drawing.Point(12, 11);
            this.btnTroVeCuaThongKe.Name = "btnTroVeCuaThongKe";
            this.btnTroVeCuaThongKe.Size = new System.Drawing.Size(101, 37);
            this.btnTroVeCuaThongKe.TabIndex = 10;
            this.btnTroVeCuaThongKe.Text = "Trở về";
            this.btnTroVeCuaThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaThongKe.UseVisualStyleBackColor = false;
            this.btnTroVeCuaThongKe.Click += new System.EventHandler(this.btnTroVeCuaThongKe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "Địa Chỉ";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(292, 89);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(124, 20);
            this.txtMaNCC.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tên Nhà Cung Cấp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(139, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 22);
            this.label11.TabIndex = 62;
            this.label11.Text = "Mã Nhà Cung Cấp";
            // 
            // dgvCapNhatNhaCungCap
            // 
            this.dgvCapNhatNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatNhaCungCap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatNhaCungCap.Location = new System.Drawing.Point(132, 225);
            this.dgvCapNhatNhaCungCap.Name = "dgvCapNhatNhaCungCap";
            this.dgvCapNhatNhaCungCap.ReadOnly = true;
            this.dgvCapNhatNhaCungCap.Size = new System.Drawing.Size(535, 132);
            this.dgvCapNhatNhaCungCap.TabIndex = 61;
            // 
            // btnSuaCapNhatBanAn
            // 
            this.btnSuaCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnSuaCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btnSuaCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCapNhatBanAn.Location = new System.Drawing.Point(582, 89);
            this.btnSuaCapNhatBanAn.Name = "btnSuaCapNhatBanAn";
            this.btnSuaCapNhatBanAn.Size = new System.Drawing.Size(85, 40);
            this.btnSuaCapNhatBanAn.TabIndex = 60;
            this.btnSuaCapNhatBanAn.Text = "Sửa";
            this.btnSuaCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCapNhatBanAn.UseVisualStyleBackColor = false;
            // 
            // btnLuuCapNhatBanAn
            // 
            this.btnLuuCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnLuuCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Save_278762;
            this.btnLuuCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatBanAn.Location = new System.Drawing.Point(451, 89);
            this.btnLuuCapNhatBanAn.Name = "btnLuuCapNhatBanAn";
            this.btnLuuCapNhatBanAn.Size = new System.Drawing.Size(85, 40);
            this.btnLuuCapNhatBanAn.TabIndex = 59;
            this.btnLuuCapNhatBanAn.Text = "Lưu";
            this.btnLuuCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatBanAn.UseVisualStyleBackColor = false;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(291, 130);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(124, 20);
            this.txtTenNCC.TabIndex = 66;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(291, 172);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(124, 20);
            this.txtDiachi.TabIndex = 67;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(451, 149);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 40);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Synchronize_2788321;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(582, 149);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 69;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCapNhatNhaCungCap);
            this.Controls.Add(this.btnSuaCapNhatBanAn);
            this.Controls.Add(this.btnLuuCapNhatBanAn);
            this.Controls.Add(this.btnTroVeCuaThongKe);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTroVeCuaThongKe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCapNhatNhaCungCap;
        private System.Windows.Forms.Button btnSuaCapNhatBanAn;
        private System.Windows.Forms.Button btnLuuCapNhatBanAn;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReset;
    }
}