namespace QuanLyNhaHang.Views
{
    partial class uctGoiMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctGoiMon));
            this.lvDanhSachBan = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.pnlGoiMon = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịBanCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIểnThịBànChưaCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBànMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịTấtCảCácBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgGoiMon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGoiMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lvDanhSachBan
            // 
            this.lvDanhSachBan.Location = new System.Drawing.Point(3, 3);
            this.lvDanhSachBan.Name = "lvDanhSachBan";
            this.lvDanhSachBan.Size = new System.Drawing.Size(449, 443);
            this.lvDanhSachBan.TabIndex = 0;
            this.lvDanhSachBan.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachBan.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachBan_SelectedIndexChanged);
            this.lvDanhSachBan.Click += new System.EventHandler(this.lvDanhSachBan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền thanh toán: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(708, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 41);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(192, 16);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 13);
            this.lblTongTien.TabIndex = 6;
            // 
            // pnlGoiMon
            // 
            this.pnlGoiMon.Location = new System.Drawing.Point(454, 279);
            this.pnlGoiMon.Name = "pnlGoiMon";
            this.pnlGoiMon.Size = new System.Drawing.Size(530, 167);
            this.pnlGoiMon.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coffe_conguoi.png");
            this.imageList1.Images.SetKeyName(1, "iconcfms.png");
            this.imageList1.Images.SetKeyName(2, "21216-200.png");
            this.imageList1.Images.SetKeyName(3, "catering (1).png");
            this.imageList1.Images.SetKeyName(4, "print.png");
            this.imageList1.Images.SetKeyName(5, "round-border-menu-bar-128.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBànMớiToolStripMenuItem,
            this.hiểnThịBanCóNgườiToolStripMenuItem,
            this.hIểnThịBànChưaCóNgườiToolStripMenuItem,
            this.hiểnThịTấtCảCácBànToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 92);
            // 
            // hiểnThịBanCóNgườiToolStripMenuItem
            // 
            this.hiểnThịBanCóNgườiToolStripMenuItem.Name = "hiểnThịBanCóNgườiToolStripMenuItem";
            this.hiểnThịBanCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hiểnThịBanCóNgườiToolStripMenuItem.Text = "Hiển thị bàn có người";
            this.hiểnThịBanCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBanCóNgườiToolStripMenuItem_Click);
            // 
            // hIểnThịBànChưaCóNgườiToolStripMenuItem
            // 
            this.hIểnThịBànChưaCóNgườiToolStripMenuItem.Name = "hIểnThịBànChưaCóNgườiToolStripMenuItem";
            this.hIểnThịBànChưaCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hIểnThịBànChưaCóNgườiToolStripMenuItem.Text = "Hiển thị bàn chưa có người";
            this.hIểnThịBànChưaCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hIểnThịBànChưaCóNgườiToolStripMenuItem_Click);
            // 
            // thêmBànMớiToolStripMenuItem
            // 
            this.thêmBànMớiToolStripMenuItem.Name = "thêmBànMớiToolStripMenuItem";
            this.thêmBànMớiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thêmBànMớiToolStripMenuItem.Text = "Thêm bàn mới";
            this.thêmBànMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmBànMớiToolStripMenuItem_Click);
            // 
            // hiểnThịTấtCảCácBànToolStripMenuItem
            // 
            this.hiểnThịTấtCảCácBànToolStripMenuItem.Name = "hiểnThịTấtCảCácBànToolStripMenuItem";
            this.hiểnThịTấtCảCácBànToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hiểnThịTấtCảCácBànToolStripMenuItem.Text = "Hiển thị tất cả các bàn";
            this.hiểnThịTấtCảCácBànToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịTấtCảCácBànToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.ImageIndex = 4;
            this.btnInHoaDon.ImageList = this.imageList1;
            this.btnInHoaDon.Location = new System.Drawing.Point(834, 203);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(141, 58);
            this.btnInHoaDon.TabIndex = 8;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhTien.ImageIndex = 0;
            this.btnTinhTien.ImageList = this.imageList1;
            this.btnTinhTien.Location = new System.Drawing.Point(708, 203);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(120, 58);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoiMon.ImageIndex = 1;
            this.btnGoiMon.ImageList = this.imageList1;
            this.btnGoiMon.Location = new System.Drawing.Point(585, 203);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(120, 58);
            this.btnGoiMon.TabIndex = 6;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageIndex = 5;
            this.btnMenu.ImageList = this.imageList1;
            this.btnMenu.Location = new System.Drawing.Point(459, 203);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 58);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgGoiMon);
            this.groupBox2.Location = new System.Drawing.Point(458, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 133);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // dvgGoiMon
            // 
            this.dvgGoiMon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dvgGoiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGoiMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgGoiMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dvgGoiMon.Location = new System.Drawing.Point(3, 16);
            this.dvgGoiMon.Name = "dvgGoiMon";
            this.dvgGoiMon.Size = new System.Drawing.Size(502, 114);
            this.dvgGoiMon.TabIndex = 21;
            // 
            // uctGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnGoiMon);
            this.Controls.Add(this.pnlGoiMon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lvDanhSachBan);
            this.Name = "uctGoiMon";
            this.Size = new System.Drawing.Size(991, 452);
            this.Load += new System.EventHandler(this.uctGoiMon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGoiMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDanhSachBan;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlGoiMon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBanCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIểnThịBànChưaCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmBànMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịTấtCảCácBànToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgGoiMon;
    }
}
