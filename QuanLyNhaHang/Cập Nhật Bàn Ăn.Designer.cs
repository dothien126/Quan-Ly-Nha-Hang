namespace QuanLyNhaHang
{
    partial class frmCapNhatBanAn
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
            this.lblCapNhatBanAn = new System.Windows.Forms.Label();
            this.btnLuuCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnHuyCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.dgvCapNhatBanAn = new System.Windows.Forms.DataGridView();
            this.txtMaPhieuYC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMaBa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTang = new System.Windows.Forms.ComboBox();
            this.cbxKieuBan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatBanAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapNhatBanAn
            // 
            this.lblCapNhatBanAn.AutoSize = true;
            this.lblCapNhatBanAn.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatBanAn.Location = new System.Drawing.Point(291, 9);
            this.lblCapNhatBanAn.Name = "lblCapNhatBanAn";
            this.lblCapNhatBanAn.Size = new System.Drawing.Size(252, 39);
            this.lblCapNhatBanAn.TabIndex = 0;
            this.lblCapNhatBanAn.Text = "Cập Nhật Bàn Ăn";
            // 
            // btnLuuCapNhatBanAn
            // 
            this.btnLuuCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnLuuCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Save_278762;
            this.btnLuuCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatBanAn.Location = new System.Drawing.Point(484, 82);
            this.btnLuuCapNhatBanAn.Name = "btnLuuCapNhatBanAn";
            this.btnLuuCapNhatBanAn.Size = new System.Drawing.Size(85, 40);
            this.btnLuuCapNhatBanAn.TabIndex = 7;
            this.btnLuuCapNhatBanAn.Text = "Lưu";
            this.btnLuuCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatBanAn.UseVisualStyleBackColor = false;
            // 
            // btnHuyCapNhatBanAn
            // 
            this.btnHuyCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnHuyCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btnHuyCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatBanAn.Location = new System.Drawing.Point(632, 82);
            this.btnHuyCapNhatBanAn.Name = "btnHuyCapNhatBanAn";
            this.btnHuyCapNhatBanAn.Size = new System.Drawing.Size(85, 40);
            this.btnHuyCapNhatBanAn.TabIndex = 8;
            this.btnHuyCapNhatBanAn.Text = "Sửa";
            this.btnHuyCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatBanAn.UseVisualStyleBackColor = false;
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.Lime;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(12, 9);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(94, 33);
            this.btnTroVeCuaQLNV.TabIndex = 9;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.BtnTroVeCuaQLNV_Click);
            // 
            // dgvCapNhatBanAn
            // 
            this.dgvCapNhatBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatBanAn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatBanAn.Location = new System.Drawing.Point(149, 232);
            this.dgvCapNhatBanAn.Name = "dgvCapNhatBanAn";
            this.dgvCapNhatBanAn.ReadOnly = true;
            this.dgvCapNhatBanAn.RowHeadersWidth = 51;
            this.dgvCapNhatBanAn.Size = new System.Drawing.Size(568, 136);
            this.dgvCapNhatBanAn.TabIndex = 10;
            // 
            // txtMaPhieuYC
            // 
            this.txtMaPhieuYC.Location = new System.Drawing.Point(296, 188);
            this.txtMaPhieuYC.Name = "txtMaPhieuYC";
            this.txtMaPhieuYC.Size = new System.Drawing.Size(124, 20);
            this.txtMaPhieuYC.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "Mã Phiếu Yêu Cầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 53;
            this.label9.Text = "Kiểu Bàn";
            // 
            // textMaBa
            // 
            this.textMaBa.Location = new System.Drawing.Point(297, 82);
            this.textMaBa.Name = "textMaBa";
            this.textMaBa.Size = new System.Drawing.Size(124, 20);
            this.textMaBa.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tầng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 49;
            this.label11.Text = "Mã Bàn Ăn";
            // 
            // cbxTang
            // 
            this.cbxTang.FormattingEnabled = true;
            this.cbxTang.Location = new System.Drawing.Point(298, 115);
            this.cbxTang.Name = "cbxTang";
            this.cbxTang.Size = new System.Drawing.Size(121, 21);
            this.cbxTang.TabIndex = 57;
            this.cbxTang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxKieuBan
            // 
            this.cbxKieuBan.FormattingEnabled = true;
            this.cbxKieuBan.Location = new System.Drawing.Point(297, 151);
            this.cbxKieuBan.Name = "cbxKieuBan";
            this.cbxKieuBan.Size = new System.Drawing.Size(121, 21);
            this.cbxKieuBan.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(484, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 59;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Synchronize_2788321;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(632, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 40);
            this.button2.TabIndex = 60;
            this.button2.Text = "Reset";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmCapNhatBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxKieuBan);
            this.Controls.Add(this.cbxTang);
            this.Controls.Add(this.txtMaPhieuYC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textMaBa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCapNhatBanAn);
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.btnHuyCapNhatBanAn);
            this.Controls.Add(this.btnLuuCapNhatBanAn);
            this.Controls.Add(this.lblCapNhatBanAn);
            this.Name = "frmCapNhatBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Bàn Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatBanAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapNhatBanAn;
        private System.Windows.Forms.Button btnLuuCapNhatBanAn;
        private System.Windows.Forms.Button btnHuyCapNhatBanAn;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
        private System.Windows.Forms.DataGridView dgvCapNhatBanAn;
        private System.Windows.Forms.TextBox txtMaPhieuYC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMaBa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTang;
        private System.Windows.Forms.ComboBox cbxKieuBan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}