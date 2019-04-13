namespace QuanLyNhaHang.Views
{
    partial class uctDanhSachThucDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.IdThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThucDon);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 262);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdThucDon,
            this.TenLoaiThucDon,
            this.TenThucDon,
            this.DonViTinh,
            this.SoLuongTon,
            this.DonGiaTon,
            this.TonToiThieu,
            this.TrangThai});
            this.dgvThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvThucDon.Location = new System.Drawing.Point(6, 15);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.Size = new System.Drawing.Size(549, 238);
            this.dgvThucDon.TabIndex = 50;
            this.dgvThucDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellContentClick);
            // 
            // IdThucDon
            // 
            this.IdThucDon.DataPropertyName = "IdThucDon";
            this.IdThucDon.HeaderText = "Id Thực đơn";
            this.IdThucDon.Name = "IdThucDon";
            // 
            // TenLoaiThucDon
            // 
            this.TenLoaiThucDon.DataPropertyName = "TenLoaiThucDon";
            this.TenLoaiThucDon.HeaderText = "Tên loại thực đơn";
            this.TenLoaiThucDon.Name = "TenLoaiThucDon";
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên thực đơn";
            this.TenThucDon.Name = "TenThucDon";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng";
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGiaTon
            // 
            this.DonGiaTon.DataPropertyName = "DonGiaTon";
            this.DonGiaTon.HeaderText = "Đơn giá tiền";
            this.DonGiaTon.Name = "DonGiaTon";
            // 
            // TonToiThieu
            // 
            this.TonToiThieu.DataPropertyName = "TonToiThieu";
            this.TonToiThieu.HeaderText = "Tiền tối thiểu";
            this.TonToiThieu.Name = "TonToiThieu";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // uctDanhSachThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uctDanhSachThucDon";
            this.Size = new System.Drawing.Size(801, 334);
            this.Load += new System.EventHandler(this.uctDanhSachThucDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;

    }
}
