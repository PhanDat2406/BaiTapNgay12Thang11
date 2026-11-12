namespace Bai5_3;

public partial class FrmQuanLySanPham
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
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle priceCellStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle qtyCellStyle = new DataGridViewCellStyle();
        grpProductInfo = new GroupBox();
        cboCategory = new ComboBox();
        lblCategory = new Label();
        txtQuantity = new TextBox();
        lblQuantity = new Label();
        txtUnitPrice = new TextBox();
        lblUnitPrice = new Label();
        txtProductName = new TextBox();
        lblProductName = new Label();
        txtProductId = new TextBox();
        lblProductId = new Label();
        grpActions = new GroupBox();
        btnReset = new Button();
        btnSearch = new Button();
        txtSearch = new TextBox();
        lblSearch = new Label();
        btnDelete = new Button();
        btnEdit = new Button();
        btnAdd = new Button();
        grpList = new GroupBox();
        dgvProducts = new DataGridView();
        colProductId = new DataGridViewTextBoxColumn();
        colProductName = new DataGridViewTextBoxColumn();
        colUnitPrice = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        bsProducts = new BindingSource(components);
        lblStatus = new Label();
        grpProductInfo.SuspendLayout();
        grpActions.SuspendLayout();
        grpList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bsProducts).BeginInit();
        SuspendLayout();

        // 
        // grpProductInfo
        // 
        grpProductInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpProductInfo.Controls.Add(cboCategory);
        grpProductInfo.Controls.Add(lblCategory);
        grpProductInfo.Controls.Add(txtQuantity);
        grpProductInfo.Controls.Add(lblQuantity);
        grpProductInfo.Controls.Add(txtUnitPrice);
        grpProductInfo.Controls.Add(lblUnitPrice);
        grpProductInfo.Controls.Add(txtProductName);
        grpProductInfo.Controls.Add(lblProductName);
        grpProductInfo.Controls.Add(txtProductId);
        grpProductInfo.Controls.Add(lblProductId);
        grpProductInfo.Location = new Point(12, 12);
        grpProductInfo.Name = "grpProductInfo";
        grpProductInfo.Size = new Size(860, 134);
        grpProductInfo.TabIndex = 0;
        grpProductInfo.TabStop = false;
        grpProductInfo.Text = "Thông tin sản phẩm";

        // 
        // lblProductId
        // 
        lblProductId.AutoSize = true;
        lblProductId.Location = new Point(16, 28);
        lblProductId.Name = "lblProductId";
        lblProductId.Size = new Size(46, 15);
        lblProductId.TabIndex = 0;
        lblProductId.Text = "Mã SP:";

        // 
        // txtProductId
        // 
        txtProductId.Location = new Point(100, 25);
        txtProductId.Name = "txtProductId";
        txtProductId.PlaceholderText = "VD: SP007";
        txtProductId.Size = new Size(295, 23);
        txtProductId.TabIndex = 1;

        // 
        // lblProductName
        // 
        lblProductName.AutoSize = true;
        lblProductName.Location = new Point(16, 63);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(49, 15);
        lblProductName.TabIndex = 2;
        lblProductName.Text = "Tên SP:";

        // 
        // txtProductName
        // 
        txtProductName.Location = new Point(100, 60);
        txtProductName.Name = "txtProductName";
        txtProductName.PlaceholderText = "Nhập tên sản phẩm";
        txtProductName.Size = new Size(295, 23);
        txtProductName.TabIndex = 3;

        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(16, 98);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(64, 15);
        lblCategory.TabIndex = 4;
        lblCategory.Text = "Danh mục:";

        // 
        // cboCategory
        // 
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new Point(100, 95);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(295, 23);
        cboCategory.TabIndex = 5;

        // 
        // lblUnitPrice
        // 
        lblUnitPrice.AutoSize = true;
        lblUnitPrice.Location = new Point(455, 28);
        lblUnitPrice.Name = "lblUnitPrice";
        lblUnitPrice.Size = new Size(56, 15);
        lblUnitPrice.TabIndex = 6;
        lblUnitPrice.Text = "Đơn giá:";

        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(540, 25);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.PlaceholderText = "VD: 15000000";
        txtUnitPrice.Size = new Size(295, 23);
        txtUnitPrice.TabIndex = 7;

        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Location = new Point(455, 63);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(59, 15);
        lblQuantity.TabIndex = 8;
        lblQuantity.Text = "Số lượng:";

        // 
        // txtQuantity
        // 
        txtQuantity.Location = new Point(540, 60);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.PlaceholderText = "VD: 10";
        txtQuantity.Size = new Size(295, 23);
        txtQuantity.TabIndex = 9;

        // 
        // grpActions
        // 
        grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpActions.Controls.Add(btnReset);
        grpActions.Controls.Add(btnSearch);
        grpActions.Controls.Add(txtSearch);
        grpActions.Controls.Add(lblSearch);
        grpActions.Controls.Add(btnDelete);
        grpActions.Controls.Add(btnEdit);
        grpActions.Controls.Add(btnAdd);
        grpActions.Location = new Point(12, 154);
        grpActions.Name = "grpActions";
        grpActions.Size = new Size(860, 66);
        grpActions.TabIndex = 1;
        grpActions.TabStop = false;
        grpActions.Text = "Chức năng";

        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(16, 23);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(88, 30);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += BtnAdd_Click;

        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(114, 23);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(88, 30);
        btnEdit.TabIndex = 1;
        btnEdit.Text = "Sửa";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += BtnEdit_Click;

        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(212, 23);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(88, 30);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += BtnDelete_Click;

        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(360, 30);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(55, 15);
        lblSearch.TabIndex = 3;
        lblSearch.Text = "Tìm tên:";

        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(422, 26);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Nhập Tên SP cần tìm...";
        txtSearch.Size = new Size(220, 23);
        txtSearch.TabIndex = 4;
        txtSearch.KeyDown += TxtSearch_KeyDown;

        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(652, 23);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(92, 30);
        btnSearch.TabIndex = 5;
        btnSearch.Text = "Tìm kiếm";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += BtnSearch_Click;

        // 
        // btnReset
        // 
        btnReset.Location = new Point(754, 23);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(88, 30);
        btnReset.TabIndex = 6;
        btnReset.Text = "Làm mới";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += BtnReset_Click;

        // 
        // grpList
        // 
        grpList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpList.Controls.Add(dgvProducts);
        grpList.Location = new Point(12, 228);
        grpList.Name = "grpList";
        grpList.Padding = new Padding(8, 10, 8, 8);
        grpList.Size = new Size(860, 268);
        grpList.TabIndex = 2;
        grpList.TabStop = false;
        grpList.Text = "Danh sách hiển thị (DataGridView)";

        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.AutoGenerateColumns = false;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Columns.AddRange([colProductId, colProductName, colUnitPrice, colQuantity, colCategory]);
        dgvProducts.DataSource = bsProducts;
        dgvProducts.Dock = DockStyle.Fill;
        dgvProducts.Location = new Point(8, 24);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersVisible = false;
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new Size(844, 236);
        dgvProducts.TabIndex = 0;
        dgvProducts.CellClick += DgvProducts_CellClick;

        // 
        // colProductId
        // 
        colProductId.DataPropertyName = "ProductId";
        colProductId.FillWeight = 60F;
        colProductId.HeaderText = "Mã SP";
        colProductId.Name = "colProductId";
        colProductId.ReadOnly = true;

        // 
        // colProductName
        // 
        colProductName.DataPropertyName = "ProductName";
        colProductName.FillWeight = 150F;
        colProductName.HeaderText = "Tên sản phẩm";
        colProductName.Name = "colProductName";
        colProductName.ReadOnly = true;

        // 
        // colUnitPrice
        // 
        colUnitPrice.DataPropertyName = "UnitPrice";
        priceCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        priceCellStyle.Format = "N0";
        colUnitPrice.DefaultCellStyle = priceCellStyle;
        colUnitPrice.FillWeight = 90F;
        colUnitPrice.HeaderText = "Đơn giá (VNĐ)";
        colUnitPrice.Name = "colUnitPrice";
        colUnitPrice.ReadOnly = true;

        // 
        // colQuantity
        // 
        colQuantity.DataPropertyName = "Quantity";
        qtyCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        colQuantity.DefaultCellStyle = qtyCellStyle;
        colQuantity.FillWeight = 60F;
        colQuantity.HeaderText = "Số lượng";
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;

        // 
        // colCategory
        // 
        colCategory.DataPropertyName = "Category";
        colCategory.FillWeight = 100F;
        colCategory.HeaderText = "Danh mục";
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;

        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblStatus.Location = new Point(12, 502);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(860, 20);
        lblStatus.TabIndex = 3;
        lblStatus.Text = "Tổng số sản phẩm: 0";

        // 
        // FrmQuanLySanPham
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(884, 530);
        Controls.Add(lblStatus);
        Controls.Add(grpList);
        Controls.Add(grpActions);
        Controls.Add(grpProductInfo);
        MinimumSize = new Size(860, 480);
        Name = "FrmQuanLySanPham";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.3 - Quản Lý Sản Phẩm Trong Bộ Nhớ (DataGridView)";
        Load += FrmQuanLySanPham_Load;
        grpProductInfo.ResumeLayout(false);
        grpProductInfo.PerformLayout();
        grpActions.ResumeLayout(false);
        grpActions.PerformLayout();
        grpList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)bsProducts).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpProductInfo = null!;
    private Label lblProductId = null!;
    private TextBox txtProductId = null!;
    private Label lblProductName = null!;
    private TextBox txtProductName = null!;
    private Label lblCategory = null!;
    private ComboBox cboCategory = null!;
    private Label lblUnitPrice = null!;
    private TextBox txtUnitPrice = null!;
    private Label lblQuantity = null!;
    private TextBox txtQuantity = null!;
    private GroupBox grpActions = null!;
    private Button btnAdd = null!;
    private Button btnEdit = null!;
    private Button btnDelete = null!;
    private Label lblSearch = null!;
    private TextBox txtSearch = null!;
    private Button btnSearch = null!;
    private Button btnReset = null!;
    private GroupBox grpList = null!;
    private DataGridView dgvProducts = null!;
    private DataGridViewTextBoxColumn colProductId = null!;
    private DataGridViewTextBoxColumn colProductName = null!;
    private DataGridViewTextBoxColumn colUnitPrice = null!;
    private DataGridViewTextBoxColumn colQuantity = null!;
    private DataGridViewTextBoxColumn colCategory = null!;
    private BindingSource bsProducts = null!;
    private Label lblStatus = null!;
}
