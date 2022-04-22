
namespace Thuchanh
{
    partial class HDN
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
            this.txtNgaynhap = new System.Windows.Forms.MaskedTextBox();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.labelNN = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.labelTenNCC = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(141, 363);
            this.txtNgaynhap.Mask = "00/00/0000";
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(86, 22);
            this.txtNgaynhap.TabIndex = 36;
            this.txtNgaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(426, 459);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 35;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click_1);
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.Location = new System.Drawing.Point(626, 414);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(178, 54);
            this.btnBaocao.TabIndex = 34;
            this.btnBaocao.Text = "In báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = false;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(141, 313);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(243, 24);
            this.cbNV.TabIndex = 33;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(141, 406);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(243, 22);
            this.txtTenNCC.TabIndex = 30;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(426, 313);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(61, 313);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(56, 17);
            this.labelMaNV.TabIndex = 31;
            this.labelMaNV.Text = "Tên NV";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(426, 363);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelNN
            // 
            this.labelNN.AutoSize = true;
            this.labelNN.Location = new System.Drawing.Point(61, 363);
            this.labelNN.Name = "labelNN";
            this.labelNN.Size = new System.Drawing.Size(77, 17);
            this.labelNN.TabIndex = 28;
            this.labelNN.Text = "Ngày nhập";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(426, 405);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // labelTenNCC
            // 
            this.labelTenNCC.AutoSize = true;
            this.labelTenNCC.Location = new System.Drawing.Point(61, 409);
            this.labelTenNCC.Name = "labelTenNCC";
            this.labelTenNCC.Size = new System.Drawing.Size(65, 17);
            this.labelTenNCC.TabIndex = 26;
            this.labelTenNCC.Text = "Tên NCC";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(141, 262);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(243, 22);
            this.txtMaHD.TabIndex = 25;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(426, 265);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelMaHD
            // 
            this.labelMaHD.AutoSize = true;
            this.labelMaHD.Location = new System.Drawing.Point(61, 265);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(51, 17);
            this.labelMaHD.TabIndex = 23;
            this.labelMaHD.Text = "Mã HD";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 249);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn nhập";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(10, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(832, 220);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaHDN";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dNgayNhap";
            this.Column3.HeaderText = "Ngày lập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sTenNCC";
            this.Column4.HeaderText = "Tên NCC";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fTongtien";
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // HDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 499);
            this.Controls.Add(this.txtNgaynhap);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.labelNN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.labelTenNCC);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelMaHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "HDN";
            this.Text = "HDN";
            this.Load += new System.EventHandler(this.HDN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNgaynhap;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label labelNN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label labelTenNCC;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}