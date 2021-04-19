namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuanLyKhachHang = new System.Windows.Forms.Label();
            this.dgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.btnTroVeCuaQLKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.tb_SdtKH = new System.Windows.Forms.TextBox();
            this.tb_diaChiKH = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tb_maKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyKhachHang
            // 
            this.lblQuanLyKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyKhachHang.Name = "lblQuanLyKhachHang";
            this.lblQuanLyKhachHang.Size = new System.Drawing.Size(1018, 51);
            this.lblQuanLyKhachHang.TabIndex = 0;
            this.lblQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.lblQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQuanLyKhachHang
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuanLyKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanLyKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhachHang.Location = new System.Drawing.Point(142, 237);
            this.dgvQuanLyKhachHang.Name = "dgvQuanLyKhachHang";
            this.dgvQuanLyKhachHang.RowHeadersVisible = false;
            this.dgvQuanLyKhachHang.RowHeadersWidth = 51;
            this.dgvQuanLyKhachHang.RowTemplate.Height = 24;
            this.dgvQuanLyKhachHang.Size = new System.Drawing.Size(773, 304);
            this.dgvQuanLyKhachHang.TabIndex = 9;
            this.dgvQuanLyKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyKhachHang_CellContentClick);
            // 
            // btnTroVeCuaQLKH
            // 
            this.btnTroVeCuaQLKH.BackColor = System.Drawing.Color.Blue;
            this.btnTroVeCuaQLKH.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLKH.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLKH.Location = new System.Drawing.Point(2, 2);
            this.btnTroVeCuaQLKH.Name = "btnTroVeCuaQLKH";
            this.btnTroVeCuaQLKH.Size = new System.Drawing.Size(110, 37);
            this.btnTroVeCuaQLKH.TabIndex = 1;
            this.btnTroVeCuaQLKH.Text = "Trở về";
            this.btnTroVeCuaQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLKH.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLKH.Click += new System.EventHandler(this.btnTroVeCuaQLKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "SĐT";
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.Location = new System.Drawing.Point(379, 140);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(166, 22);
            this.tb_tenKH.TabIndex = 15;
            // 
            // tb_SdtKH
            // 
            this.tb_SdtKH.Location = new System.Drawing.Point(699, 140);
            this.tb_SdtKH.Name = "tb_SdtKH";
            this.tb_SdtKH.Size = new System.Drawing.Size(180, 22);
            this.tb_SdtKH.TabIndex = 17;
            // 
            // tb_diaChiKH
            // 
            this.tb_diaChiKH.Location = new System.Drawing.Point(699, 86);
            this.tb_diaChiKH.Name = "tb_diaChiKH";
            this.tb_diaChiKH.Size = new System.Drawing.Size(180, 22);
            this.tb_diaChiKH.TabIndex = 16;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(253, 186);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(97, 30);
            this.btThem.TabIndex = 18;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Save_278762;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(406, 186);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(97, 30);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Remove_278742;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(558, 186);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(97, 30);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btReset.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconfinder_Synchronize_278832;
            this.btReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReset.Location = new System.Drawing.Point(712, 186);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(95, 30);
            this.btReset.TabIndex = 21;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tb_maKH
            // 
            this.tb_maKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_maKH.Location = new System.Drawing.Point(379, 93);
            this.tb_maKH.Name = "tb_maKH";
            this.tb_maKH.Size = new System.Drawing.Size(166, 22);
            this.tb_maKH.TabIndex = 22;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b132;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 572);
            this.Controls.Add(this.tb_maKH);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tb_SdtKH);
            this.Controls.Add(this.tb_diaChiKH);
            this.Controls.Add(this.tb_tenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuanLyKhachHang);
            this.Controls.Add(this.btnTroVeCuaQLKH);
            this.Controls.Add(this.lblQuanLyKhachHang);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyKhachHang;
        private System.Windows.Forms.Button btnTroVeCuaQLKH;
        private System.Windows.Forms.DataGridView dgvQuanLyKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.TextBox tb_SdtKH;
        private System.Windows.Forms.TextBox tb_diaChiKH;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tb_maKH;
    }
}