namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyNhaHang
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
            this.btnCapNhatThucPham = new System.Windows.Forms.Button();
            this.btnCapNhatMonAn = new System.Windows.Forms.Button();
            this.btnCapNhatBanAn = new System.Windows.Forms.Button();
            this.lblQuanLyPhong = new System.Windows.Forms.Label();
            this.btnTroVeCuaCTPP = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.btQuanLyNhaCungCap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatThucPham
            // 
            this.btnCapNhatThucPham.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatThucPham.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThucPham.Location = new System.Drawing.Point(16, 171);
            this.btnCapNhatThucPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatThucPham.Name = "btnCapNhatThucPham";
            this.btnCapNhatThucPham.Size = new System.Drawing.Size(273, 62);
            this.btnCapNhatThucPham.TabIndex = 0;
            this.btnCapNhatThucPham.Text = "Cập Nhật Thực Phẩm";
            this.btnCapNhatThucPham.UseVisualStyleBackColor = false;
            this.btnCapNhatThucPham.Click += new System.EventHandler(this.btnCapNhatThucPham_Click);
            // 
            // btnCapNhatMonAn
            // 
            this.btnCapNhatMonAn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMonAn.Location = new System.Drawing.Point(16, 288);
            this.btnCapNhatMonAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatMonAn.Name = "btnCapNhatMonAn";
            this.btnCapNhatMonAn.Size = new System.Drawing.Size(273, 63);
            this.btnCapNhatMonAn.TabIndex = 1;
            this.btnCapNhatMonAn.Text = "Cập Nhật Món Ăn";
            this.btnCapNhatMonAn.UseVisualStyleBackColor = false;
            this.btnCapNhatMonAn.Click += new System.EventHandler(this.btnCapNhatMonAn_Click);
            // 
            // btnCapNhatBanAn
            // 
            this.btnCapNhatBanAn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatBanAn.Location = new System.Drawing.Point(16, 406);
            this.btnCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatBanAn.Name = "btnCapNhatBanAn";
            this.btnCapNhatBanAn.Size = new System.Drawing.Size(273, 60);
            this.btnCapNhatBanAn.TabIndex = 2;
            this.btnCapNhatBanAn.Text = "Cập Nhật Bàn Ăn";
            this.btnCapNhatBanAn.UseVisualStyleBackColor = false;
            this.btnCapNhatBanAn.Click += new System.EventHandler(this.btnCapNhatBanAn_Click);
            // 
            // lblQuanLyPhong
            // 
            this.lblQuanLyPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyPhong.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhong.Location = new System.Drawing.Point(633, 11);
            this.lblQuanLyPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuanLyPhong.Name = "lblQuanLyPhong";
            this.lblQuanLyPhong.Size = new System.Drawing.Size(451, 52);
            this.lblQuanLyPhong.TabIndex = 3;
            this.lblQuanLyPhong.Text = "Quản Lý Nhà Hàng";
            this.lblQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTroVeCuaCTPP
            // 
            this.btnTroVeCuaCTPP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTroVeCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCTPP.Location = new System.Drawing.Point(16, 11);
            this.btnTroVeCuaCTPP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTroVeCuaCTPP.Name = "btnTroVeCuaCTPP";
            this.btnTroVeCuaCTPP.Size = new System.Drawing.Size(127, 44);
            this.btnTroVeCuaCTPP.TabIndex = 5;
            this.btnTroVeCuaCTPP.Text = "Trở về";
            this.btnTroVeCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCTPP.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCTPP.Click += new System.EventHandler(this.btnTroVeCuaCTPP_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // btQuanLyNhaCungCap
            // 
            this.btQuanLyNhaCungCap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btQuanLyNhaCungCap.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLyNhaCungCap.Location = new System.Drawing.Point(16, 523);
            this.btQuanLyNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuanLyNhaCungCap.Name = "btQuanLyNhaCungCap";
            this.btQuanLyNhaCungCap.Size = new System.Drawing.Size(273, 60);
            this.btQuanLyNhaCungCap.TabIndex = 6;
            this.btQuanLyNhaCungCap.Text = "Cập Nhật Nhà Cung Cấp";
            this.btQuanLyNhaCungCap.UseVisualStyleBackColor = false;
            this.btQuanLyNhaCungCap.Click += new System.EventHandler(this.btQuanLyNhaCungCap_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(319, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 537);
            this.panel1.TabIndex = 7;
            // 
            // frmQuanLyNhaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1403, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btQuanLyNhaCungCap);
            this.Controls.Add(this.btnTroVeCuaCTPP);
            this.Controls.Add(this.lblQuanLyPhong);
            this.Controls.Add(this.btnCapNhatBanAn);
            this.Controls.Add(this.btnCapNhatMonAn);
            this.Controls.Add(this.btnCapNhatThucPham);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyNhaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatThucPham;
        private System.Windows.Forms.Button btnCapNhatMonAn;
        private System.Windows.Forms.Button btnCapNhatBanAn;
        private System.Windows.Forms.Label lblQuanLyPhong;
        private System.Windows.Forms.Button btnTroVeCuaCTPP;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button btQuanLyNhaCungCap;
        private System.Windows.Forms.Panel panel1;
    }
}