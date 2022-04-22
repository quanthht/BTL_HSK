
namespace Thuchanh
{
    partial class frSanPham
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
            this.tbDonGiaNhap = new System.Windows.Forms.MaskedTextBox();
            this.tbNamSX = new System.Windows.Forms.MaskedTextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbDonGiaXuat = new System.Windows.Forms.TextBox();
            this.fDonGiaXuat = new System.Windows.Forms.Label();
            this.fDonGiaNhap = new System.Windows.Forms.Label();
            this.iNamSX = new System.Windows.Forms.Label();
            this.tbHangSX = new System.Windows.Forms.TextBox();
            this.sHangSX = new System.Windows.Forms.Label();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.sTenSP = new System.Windows.Forms.Label();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.sMaSP = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.errorProviderSP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDonGiaNhap
            // 
            this.tbDonGiaNhap.Location = new System.Drawing.Point(1067, 107);
            this.tbDonGiaNhap.Mask = "999999999999";
            this.tbDonGiaNhap.Name = "tbDonGiaNhap";
            this.tbDonGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.tbDonGiaNhap.TabIndex = 65;
            // 
            // tbNamSX
            // 
            this.tbNamSX.Location = new System.Drawing.Point(1068, 72);
            this.tbNamSX.Mask = "9999";
            this.tbNamSX.Name = "tbNamSX";
            this.tbNamSX.Size = new System.Drawing.Size(100, 20);
            this.tbNamSX.TabIndex = 64;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(1092, 321);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 75;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(773, 324);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(283, 21);
            this.cbFilter.TabIndex = 74;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1092, 266);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(773, 266);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(283, 20);
            this.tbSearch.TabIndex = 72;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearch_Validating);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1092, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 71;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(931, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 70;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(773, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbDonGiaXuat
            // 
            this.tbDonGiaXuat.Location = new System.Drawing.Point(1067, 145);
            this.tbDonGiaXuat.Name = "tbDonGiaXuat";
            this.tbDonGiaXuat.Size = new System.Drawing.Size(100, 20);
            this.tbDonGiaXuat.TabIndex = 68;
            // 
            // fDonGiaXuat
            // 
            this.fDonGiaXuat.AutoSize = true;
            this.fDonGiaXuat.Location = new System.Drawing.Point(989, 153);
            this.fDonGiaXuat.Name = "fDonGiaXuat";
            this.fDonGiaXuat.Size = new System.Drawing.Size(67, 13);
            this.fDonGiaXuat.TabIndex = 67;
            this.fDonGiaXuat.Text = "Đơn giá xuất";
            // 
            // fDonGiaNhap
            // 
            this.fDonGiaNhap.AutoSize = true;
            this.fDonGiaNhap.Location = new System.Drawing.Point(989, 115);
            this.fDonGiaNhap.Name = "fDonGiaNhap";
            this.fDonGiaNhap.Size = new System.Drawing.Size(71, 13);
            this.fDonGiaNhap.TabIndex = 66;
            this.fDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // iNamSX
            // 
            this.iNamSX.AutoSize = true;
            this.iNamSX.Location = new System.Drawing.Point(989, 80);
            this.iNamSX.Name = "iNamSX";
            this.iNamSX.Size = new System.Drawing.Size(72, 13);
            this.iNamSX.TabIndex = 65;
            this.iNamSX.Text = "Năm sản xuất";
            // 
            // tbHangSX
            // 
            this.tbHangSX.Location = new System.Drawing.Point(848, 145);
            this.tbHangSX.Name = "tbHangSX";
            this.tbHangSX.Size = new System.Drawing.Size(100, 20);
            this.tbHangSX.TabIndex = 63;
            // 
            // sHangSX
            // 
            this.sHangSX.AutoSize = true;
            this.sHangSX.Location = new System.Drawing.Point(770, 153);
            this.sHangSX.Name = "sHangSX";
            this.sHangSX.Size = new System.Drawing.Size(76, 13);
            this.sHangSX.TabIndex = 62;
            this.sHangSX.Text = "Hãng sản xuất";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(848, 107);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(100, 20);
            this.tbTenSP.TabIndex = 61;
            // 
            // sTenSP
            // 
            this.sTenSP.AutoSize = true;
            this.sTenSP.Location = new System.Drawing.Point(770, 115);
            this.sTenSP.Name = "sTenSP";
            this.sTenSP.Size = new System.Drawing.Size(75, 13);
            this.sTenSP.TabIndex = 60;
            this.sTenSP.Text = "Tên sản phẩm";
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(848, 72);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(100, 20);
            this.tbMaSP.TabIndex = 59;
            this.tbMaSP.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaSP_Validating);
            // 
            // sMaSP
            // 
            this.sMaSP.AutoSize = true;
            this.sMaSP.Location = new System.Drawing.Point(770, 80);
            this.sMaSP.Name = "sMaSP";
            this.sMaSP.Size = new System.Drawing.Size(71, 13);
            this.sMaSP.TabIndex = 58;
            this.sMaSP.Text = "Mã sản phẩm";
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToOrderColumns = true;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(12, 63);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.Size = new System.Drawing.Size(661, 311);
            this.dgvSP.TabIndex = 57;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            this.dgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsSP_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(93, 16);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 55;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 16);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 54;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // errorProviderSP
            // 
            this.errorProviderSP.ContainerControl = this;
            // 
            // frSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 405);
            this.Controls.Add(this.tbDonGiaNhap);
            this.Controls.Add(this.tbNamSX);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbDonGiaXuat);
            this.Controls.Add(this.fDonGiaXuat);
            this.Controls.Add(this.fDonGiaNhap);
            this.Controls.Add(this.iNamSX);
            this.Controls.Add(this.tbHangSX);
            this.Controls.Add(this.sHangSX);
            this.Controls.Add(this.tbTenSP);
            this.Controls.Add(this.sTenSP);
            this.Controls.Add(this.tbMaSP);
            this.Controls.Add(this.sMaSP);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frSanPham";
            this.Text = "frSanPham";
            this.Load += new System.EventHandler(this.frSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbDonGiaNhap;
        private System.Windows.Forms.MaskedTextBox tbNamSX;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbDonGiaXuat;
        private System.Windows.Forms.Label fDonGiaXuat;
        private System.Windows.Forms.Label fDonGiaNhap;
        private System.Windows.Forms.Label iNamSX;
        private System.Windows.Forms.TextBox tbHangSX;
        private System.Windows.Forms.Label sHangSX;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.Label sTenSP;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.Label sMaSP;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ErrorProvider errorProviderSP;
    }
}