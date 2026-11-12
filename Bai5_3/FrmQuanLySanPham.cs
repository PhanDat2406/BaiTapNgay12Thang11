using System.Globalization;

namespace Bai5_3;

public partial class FrmQuanLySanPham : Form
{
    private readonly List<Product> _products = [];
    private Product? _selectedProduct;

    public FrmQuanLySanPham()
    {
        InitializeComponent();
    }

    private void FrmQuanLySanPham_Load(object? sender, EventArgs e)
    {
        LoadCategories();
        SeedSampleProducts();
        BindProductList(_products);
        ClearInputs();
    }

    private void LoadCategories()
    {
        cboCategory.Items.Clear();
        cboCategory.Items.AddRange(
        [
            "Điện thoại",
            "Laptop",
            "Máy tính bảng",
            "Phụ kiện",
            "Màn hình & Thiết bị"
        ]);
        if (cboCategory.Items.Count > 0)
        {
            cboCategory.SelectedIndex = 0;
        }
    }

    private void SeedSampleProducts()
    {
        _products.Clear();
        _products.AddRange(
        [
            new Product { ProductId = "SP001", ProductName = "iPhone 16 Pro 256GB", UnitPrice = 28_990_000m, Quantity = 12, Category = "Điện thoại" },
            new Product { ProductId = "SP002", ProductName = "Laptop Dell XPS 13", UnitPrice = 34_500_000m, Quantity = 6, Category = "Laptop" },
            new Product { ProductId = "SP003", ProductName = "Chuột Logitech MX Master 3S", UnitPrice = 2_350_000m, Quantity = 25, Category = "Phụ kiện" },
            new Product { ProductId = "SP004", ProductName = "Bàn phím cơ Keychron K2", UnitPrice = 1_950_000m, Quantity = 18, Category = "Phụ kiện" },
            new Product { ProductId = "SP005", ProductName = "iPad Air M2 11 inch", UnitPrice = 16_990_000m, Quantity = 9, Category = "Máy tính bảng" },
            new Product { ProductId = "SP006", ProductName = "Màn hình LG UltraWide 29 inch", UnitPrice = 5_490_000m, Quantity = 14, Category = "Màn hình & Thiết bị" }
        ]);
    }

    private void BindProductList(List<Product> list)
    {
        bsProducts.DataSource = null;
        bsProducts.DataSource = list;
        bsProducts.ResetBindings(false);
        dgvProducts.ClearSelection();
        lblStatus.Text = $"Đang hiển thị {list.Count} / {_products.Count} sản phẩm.";
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (!TryReadValidatedInputs(out Product? inputProduct, out string errorMessage))
        {
            MessageBox.Show(errorMessage, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool duplicateExists = _products.Any(p =>
            string.Equals(p.ProductId, inputProduct!.ProductId, StringComparison.OrdinalIgnoreCase));

        if (duplicateExists)
        {
            MessageBox.Show(
                $"Mã sản phẩm \"{inputProduct!.ProductId}\" đã tồn tại!",
                "Trùng mã sản phẩm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtProductId.Focus();
            txtProductId.SelectAll();
            return;
        }

        _products.Add(inputProduct!);
        txtSearch.Clear();
        BindProductList(_products);
        ClearInputs();

        MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void DgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        if (dgvProducts.Rows[e.RowIndex].DataBoundItem is Product product)
        {
            _selectedProduct = product;
            PopulateInputsFromProduct(product);
        }
    }

    private void PopulateInputsFromProduct(Product product)
    {
        txtProductId.Text = product.ProductId;
        txtProductName.Text = product.ProductName;
        txtUnitPrice.Text = product.UnitPrice.ToString("0.##", CultureInfo.InvariantCulture);
        txtQuantity.Text = product.Quantity.ToString(CultureInfo.InvariantCulture);
        cboCategory.Text = product.Category;
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        Product? target = _selectedProduct ?? dgvProducts.CurrentRow?.DataBoundItem as Product;
        if (target is null)
        {
            MessageBox.Show(
                "Vui lòng click chọn một sản phẩm trong bảng để sửa!",
                "Chưa chọn sản phẩm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        if (!TryReadValidatedInputs(out Product? updated, out string errorMessage))
        {
            MessageBox.Show(errorMessage, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool idConflictsWithOther = _products.Any(p =>
            !ReferenceEquals(p, target) &&
            string.Equals(p.ProductId, updated!.ProductId, StringComparison.OrdinalIgnoreCase));

        if (idConflictsWithOther)
        {
            MessageBox.Show(
                $"Mã sản phẩm \"{updated!.ProductId}\" đã thuộc về một sản phẩm khác!",
                "Trùng mã sản phẩm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtProductId.Focus();
            return;
        }

        target.ProductId = updated!.ProductId;
        target.ProductName = updated.ProductName;
        target.UnitPrice = updated.UnitPrice;
        target.Quantity = updated.Quantity;
        target.Category = updated.Category;

        ApplyCurrentSearchFilter();
        MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        Product? target = _selectedProduct ?? dgvProducts.CurrentRow?.DataBoundItem as Product;
        if (target is null)
        {
            MessageBox.Show(
                "Vui lòng click chọn một sản phẩm trong bảng để xóa!",
                "Chưa chọn sản phẩm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        DialogResult confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa sản phẩm \"{target.ProductName}\" (Mã: {target.ProductId})?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        _products.Remove(target);
        _selectedProduct = null;
        ApplyCurrentSearchFilter();
        ClearInputs();

        MessageBox.Show("Đã xóa sản phẩm khỏi danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnSearch_Click(object? sender, EventArgs e)
    {
        ApplyCurrentSearchFilter();
    }

    private void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            ApplyCurrentSearchFilter();
        }
    }

    private void ApplyCurrentSearchFilter()
    {
        string keyword = txtSearch.Text.Trim();
        if (string.IsNullOrEmpty(keyword))
        {
            BindProductList(_products);
            return;
        }

        List<Product> filtered = _products
            .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();

        BindProductList(filtered);
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        txtSearch.Clear();
        ClearInputs();
        BindProductList(_products);
    }

    private void ClearInputs()
    {
        _selectedProduct = null;
        txtProductId.Clear();
        txtProductName.Clear();
        txtUnitPrice.Clear();
        txtQuantity.Clear();
        if (cboCategory.Items.Count > 0)
        {
            cboCategory.SelectedIndex = 0;
        }
        dgvProducts.ClearSelection();
        txtProductId.Focus();
    }

    private bool TryReadValidatedInputs(out Product? product, out string errorMessage)
    {
        product = null;
        string id = txtProductId.Text.Trim();
        string name = txtProductName.Text.Trim();
        string category = cboCategory.Text.Trim();

        if (string.IsNullOrEmpty(id))
        {
            errorMessage = "Mã SP không được để trống.";
            txtProductId.Focus();
            return false;
        }

        if (string.IsNullOrEmpty(name))
        {
            errorMessage = "Tên SP không được để trống.";
            txtProductName.Focus();
            return false;
        }

        if (!TryParseDecimalFlexible(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0m)
        {
            errorMessage = "Đơn giá phải là số hợp lệ lớn hơn hoặc bằng 0.";
            txtUnitPrice.Focus();
            txtUnitPrice.SelectAll();
            return false;
        }

        if (!int.TryParse(txtQuantity.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int quantity) || quantity < 0)
        {
            errorMessage = "Số lượng phải là số nguyên không âm.";
            txtQuantity.Focus();
            txtQuantity.SelectAll();
            return false;
        }

        if (string.IsNullOrEmpty(category))
        {
            errorMessage = "Vui lòng chọn hoặc nhập Danh mục sản phẩm.";
            cboCategory.Focus();
            return false;
        }

        product = new Product
        {
            ProductId = id,
            ProductName = name,
            UnitPrice = unitPrice,
            Quantity = quantity,
            Category = category
        };

        errorMessage = string.Empty;
        return true;
    }

    /// <summary>
    /// Phân tích chuỗi số đơn giá linh hoạt (hỗ trợ cả nhập số liền hoặc có dấu phân tách).
    /// </summary>
    public static bool TryParseDecimalFlexible(string rawText, out decimal value)
    {
        string trimmed = rawText.Trim();
        if (decimal.TryParse(trimmed, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
        {
            return true;
        }
        return decimal.TryParse(trimmed, NumberStyles.Number, CultureInfo.CurrentCulture, out value);
    }
}
