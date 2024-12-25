namespace DinhCongDanh_98711
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSanPhamTK = new System.Windows.Forms.TextBox();
            this.txtTenSanPhamTK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNCCTK = new System.Windows.Forms.ComboBox();
            this.cbNSXTK = new System.Windows.Forms.ComboBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.checkMa = new System.Windows.Forms.CheckBox();
            this.checkTen = new System.Windows.Forms.CheckBox();
            this.checkNCC = new System.Windows.Forms.CheckBox();
            this.checkNSX = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.checkNSX);
            this.groupBox1.Controls.Add(this.checkNCC);
            this.groupBox1.Controls.Add(this.checkTen);
            this.groupBox1.Controls.Add(this.checkMa);
            this.groupBox1.Controls.Add(this.txtTenSanPhamTK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbNSXTK);
            this.groupBox1.Controls.Add(this.cbNCCTK);
            this.groupBox1.Controls.Add(this.txtMaSanPhamTK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.cbNSX);
            this.groupBox2.Controls.Add(this.cbNCC);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.txtMaSanPham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(331, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(331, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 301);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhà sản xuất";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(271, 27);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(100, 22);
            this.txtMaSanPham.TabIndex = 1;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(271, 86);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(100, 22);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // cbNCC
            // 
            this.cbNCC.DisplayMember = "TenNhaCungCap";
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(613, 27);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(121, 24);
            this.cbNCC.TabIndex = 2;
            this.cbNCC.ValueMember = "MaNhaCungCap";
            // 
            // cbNSX
            // 
            this.cbNSX.DisplayMember = "TenNhaSanXuat";
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(613, 84);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(121, 24);
            this.cbNSX.TabIndex = 2;
            this.cbNSX.ValueMember = "MaNhaSanXuat";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(187, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(646, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSanPham,
            this.clTenSanPham,
            this.clTenNhaCungCap,
            this.clTenNhaSanXuat});
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // txtMaSanPhamTK
            // 
            this.txtMaSanPhamTK.Location = new System.Drawing.Point(154, 49);
            this.txtMaSanPhamTK.Name = "txtMaSanPhamTK";
            this.txtMaSanPhamTK.Size = new System.Drawing.Size(100, 22);
            this.txtMaSanPhamTK.TabIndex = 1;
            // 
            // txtTenSanPhamTK
            // 
            this.txtTenSanPhamTK.Location = new System.Drawing.Point(154, 160);
            this.txtTenSanPhamTK.Name = "txtTenSanPhamTK";
            this.txtTenSanPhamTK.Size = new System.Drawing.Size(100, 22);
            this.txtTenSanPhamTK.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nhà sản xuất";
            // 
            // cbNCCTK
            // 
            this.cbNCCTK.DisplayMember = "TenNhaCungCap";
            this.cbNCCTK.FormattingEnabled = true;
            this.cbNCCTK.Location = new System.Drawing.Point(154, 268);
            this.cbNCCTK.Name = "cbNCCTK";
            this.cbNCCTK.Size = new System.Drawing.Size(121, 24);
            this.cbNCCTK.TabIndex = 2;
            this.cbNCCTK.ValueMember = "MaNhaCungCap";
            // 
            // cbNSXTK
            // 
            this.cbNSXTK.DisplayMember = "TenNhaSanXuat";
            this.cbNSXTK.FormattingEnabled = true;
            this.cbNSXTK.Location = new System.Drawing.Point(154, 374);
            this.cbNSXTK.Name = "cbNSXTK";
            this.cbNSXTK.Size = new System.Drawing.Size(121, 24);
            this.cbNSXTK.TabIndex = 2;
            this.cbNSXTK.ValueMember = "MaNhaSanXuat";
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(53, 461);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // checkMa
            // 
            this.checkMa.AutoSize = true;
            this.checkMa.Location = new System.Drawing.Point(36, 22);
            this.checkMa.Name = "checkMa";
            this.checkMa.Size = new System.Drawing.Size(110, 20);
            this.checkMa.TabIndex = 4;
            this.checkMa.Text = "Mã sản phẩm";
            this.checkMa.UseVisualStyleBackColor = true;
            // 
            // checkTen
            // 
            this.checkTen.AutoSize = true;
            this.checkTen.Location = new System.Drawing.Point(37, 132);
            this.checkTen.Name = "checkTen";
            this.checkTen.Size = new System.Drawing.Size(115, 20);
            this.checkTen.TabIndex = 4;
            this.checkTen.Text = "Tên sản phẩm";
            this.checkTen.UseVisualStyleBackColor = true;
            // 
            // checkNCC
            // 
            this.checkNCC.AutoSize = true;
            this.checkNCC.Location = new System.Drawing.Point(32, 232);
            this.checkNCC.Name = "checkNCC";
            this.checkNCC.Size = new System.Drawing.Size(112, 20);
            this.checkNCC.TabIndex = 4;
            this.checkNCC.Text = "Nhà cung cấp";
            this.checkNCC.UseVisualStyleBackColor = true;
            // 
            // checkNSX
            // 
            this.checkNSX.AutoSize = true;
            this.checkNSX.Location = new System.Drawing.Point(32, 345);
            this.checkNSX.Name = "checkNSX";
            this.checkNSX.Size = new System.Drawing.Size(106, 20);
            this.checkNSX.TabIndex = 4;
            this.checkNSX.Text = "Nhà sản xuất";
            this.checkNSX.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.DataPropertyName = "MaSanPham";
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.MinimumWidth = 6;
            this.clMaSanPham.Name = "clMaSanPham";
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.DataPropertyName = "TenSanPham";
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.MinimumWidth = 6;
            this.clTenSanPham.Name = "clTenSanPham";
            // 
            // clTenNhaCungCap
            // 
            this.clTenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.clTenNhaCungCap.HeaderText = "Tên nhà CC";
            this.clTenNhaCungCap.MinimumWidth = 6;
            this.clTenNhaCungCap.Name = "clTenNhaCungCap";
            // 
            // clTenNhaSanXuat
            // 
            this.clTenNhaSanXuat.DataPropertyName = "TenNhaSanXuat";
            this.clTenNhaSanXuat.HeaderText = "Tên nhà sản xuất";
            this.clTenNhaSanXuat.MinimumWidth = 6;
            this.clTenNhaSanXuat.Name = "clTenNhaSanXuat";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(191, 461);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenSanPhamTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNSXTK;
        private System.Windows.Forms.ComboBox cbNCCTK;
        private System.Windows.Forms.TextBox txtMaSanPhamTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.CheckBox checkNSX;
        private System.Windows.Forms.CheckBox checkNCC;
        private System.Windows.Forms.CheckBox checkTen;
        private System.Windows.Forms.CheckBox checkMa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhaSanXuat;
        private System.Windows.Forms.Button btnReset;
    }
}

