namespace ThuatToanDijkstra
{
    partial class fDijkstra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDijkstra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachDiem = new System.Windows.Forms.ListView();
            this.cbbDiemDau = new System.Windows.Forms.ComboBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btMoFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTinhDuongDi = new System.Windows.Forms.Button();
            this.cbbDiemCuoi = new System.Windows.Forms.ComboBox();
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDanhSachDiem);
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ma Trận Trọng Số";
            // 
            // lvDanhSachDiem
            // 
            this.lvDanhSachDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachDiem.GridLines = true;
            this.lvDanhSachDiem.Location = new System.Drawing.Point(12, 19);
            this.lvDanhSachDiem.Name = "lvDanhSachDiem";
            this.lvDanhSachDiem.Size = new System.Drawing.Size(439, 159);
            this.lvDanhSachDiem.TabIndex = 6;
            this.lvDanhSachDiem.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachDiem.View = System.Windows.Forms.View.Details;
            // 
            // cbbDiemDau
            // 
            this.cbbDiemDau.FormattingEnabled = true;
            this.cbbDiemDau.Location = new System.Drawing.Point(12, 21);
            this.cbbDiemDau.Name = "cbbDiemDau";
            this.cbbDiemDau.Size = new System.Drawing.Size(121, 21);
            this.cbbDiemDau.TabIndex = 5;
            // 
            // tbFile
            // 
            this.tbFile.Enabled = false;
            this.tbFile.Location = new System.Drawing.Point(29, 26);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(341, 20);
            this.tbFile.TabIndex = 7;
            // 
            // btMoFile
            // 
            this.btMoFile.Location = new System.Drawing.Point(384, 24);
            this.btMoFile.Name = "btMoFile";
            this.btMoFile.Size = new System.Drawing.Size(75, 23);
            this.btMoFile.TabIndex = 8;
            this.btMoFile.Text = ".........";
            this.btMoFile.UseVisualStyleBackColor = true;
            this.btMoFile.Click += new System.EventHandler(this.btMoFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTinhDuongDi);
            this.groupBox2.Controls.Add(this.cbbDiemCuoi);
            this.groupBox2.Controls.Add(this.cbbDiemDau);
            this.groupBox2.Location = new System.Drawing.Point(6, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 57);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính Đường Đi";
            // 
            // btTinhDuongDi
            // 
            this.btTinhDuongDi.Location = new System.Drawing.Point(376, 19);
            this.btTinhDuongDi.Name = "btTinhDuongDi";
            this.btTinhDuongDi.Size = new System.Drawing.Size(75, 23);
            this.btTinhDuongDi.TabIndex = 12;
            this.btTinhDuongDi.Text = "Tính";
            this.btTinhDuongDi.UseVisualStyleBackColor = true;
            this.btTinhDuongDi.Click += new System.EventHandler(this.btTinhDuongDi_Click);
            // 
            // cbbDiemCuoi
            // 
            this.cbbDiemCuoi.FormattingEnabled = true;
            this.cbbDiemCuoi.Location = new System.Drawing.Point(193, 21);
            this.cbbDiemCuoi.Name = "cbbDiemCuoi";
            this.cbbDiemCuoi.Size = new System.Drawing.Size(121, 21);
            this.cbbDiemCuoi.TabIndex = 6;
            // 
            // mnMenu
            // 
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(469, 24);
            this.mnMenu.TabIndex = 11;
            this.mnMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDữLiệuToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // xóaDữLiệuToolStripMenuItem
            // 
            this.xóaDữLiệuToolStripMenuItem.Name = "xóaDữLiệuToolStripMenuItem";
            this.xóaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.xóaDữLiệuToolStripMenuItem.Text = "Xóa Dữ Liệu";
            this.xóaDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbLog);
            this.groupBox3.Location = new System.Drawing.Point(6, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 147);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 19);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(439, 122);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Copyrights: 2017";
            // 
            // fDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMoFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDijkstra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật Toán Dijkstra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDiemDau;
        private System.Windows.Forms.ListView lvDanhSachDiem;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btMoFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTinhDuongDi;
        private System.Windows.Forms.ComboBox cbbDiemCuoi;
        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

