namespace Bai5_2;

public partial class FrmTinhTienDichVu : Form
{
    private static readonly Dictionary<string, decimal> PromoCodes = new(StringComparer.OrdinalIgnoreCase)
    {
        ["GIAM10"] = 10m,
        ["GIAM20"] = 20m,
        ["VIP30"] = 30m
    };

    private readonly List<ServiceItem> _allServices = [];

    public FrmTinhTienDichVu()
    {
        InitializeComponent();
    }

    private void FrmTinhTienDichVu_Load(object? sender, EventArgs e)
    {
        SeedServices();
        LoadCategories();
        RecalculateTotals();
    }

    private void SeedServices()
    {
        _allServices.Clear();
        _allServices.AddRange(
        [
            // Khám bệnh
            new ServiceItem { Id = "KB01", Name = "Khám tổng quát", Category = "Khám bệnh", Price = 150_000m },
            new ServiceItem { Id = "KB02", Name = "Khám chuyên khoa Nội", Category = "Khám bệnh", Price = 200_000m },
            new ServiceItem { Id = "KB03", Name = "Khám Tai Mũi Họng", Category = "Khám bệnh", Price = 180_000m },
            new ServiceItem { Id = "KB04", Name = "Khám Răng Hàm Mặt", Category = "Khám bệnh", Price = 220_000m },
            new ServiceItem { Id = "KB05", Name = "Khám mắt chuyên sâu", Category = "Khám bệnh", Price = 170_000m },

            // Xét nghiệm
            new ServiceItem { Id = "XN01", Name = "Xét nghiệm công thức máu", Category = "Xét nghiệm", Price = 120_000m },
            new ServiceItem { Id = "XN02", Name = "Xét nghiệm sinh hóa máu", Category = "Xét nghiệm", Price = 250_000m },
            new ServiceItem { Id = "XN03", Name = "Xét nghiệm đường huyết", Category = "Xét nghiệm", Price = 90_000m },
            new ServiceItem { Id = "XN04", Name = "Xét nghiệm chức năng gan, thận", Category = "Xét nghiệm", Price = 320_000m },
            new ServiceItem { Id = "XN05", Name = "Tổng phân tích nước tiểu", Category = "Xét nghiệm", Price = 100_000m },

            // Chụp X-Quang
            new ServiceItem { Id = "XQ01", Name = "Chụp X-Quang tim phổi thẳng", Category = "Chụp X-Quang", Price = 200_000m },
            new ServiceItem { Id = "XQ02", Name = "Chụp X-Quang cột sống", Category = "Chụp X-Quang", Price = 280_000m },
            new ServiceItem { Id = "XQ03", Name = "Chụp X-Quang xương khớp", Category = "Chụp X-Quang", Price = 240_000m },
            new ServiceItem { Id = "XQ04", Name = "Chụp X-Quang răng toàn cảnh", Category = "Chụp X-Quang", Price = 350_000m },

            // Vắc-xin
            new ServiceItem { Id = "VX01", Name = "Vắc-xin Cúm mùa", Category = "Vắc-xin", Price = 350_000m },
            new ServiceItem { Id = "VX02", Name = "Vắc-xin Viêm gan B", Category = "Vắc-xin", Price = 250_000m },
            new ServiceItem { Id = "VX03", Name = "Vắc-xin HPV (Gardasil)", Category = "Vắc-xin", Price = 1_800_000m },
            new ServiceItem { Id = "VX04", Name = "Vắc-xin Phế cầu", Category = "Vắc-xin", Price = 1_290_000m },
            new ServiceItem { Id = "VX05", Name = "Vắc-xin Uốn ván", Category = "Vắc-xin", Price = 180_000m }
        ]);
    }

    private void LoadCategories()
    {
        cboCategory.Items.Clear();
        cboCategory.Items.AddRange(["Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin"]);
        if (cboCategory.Items.Count > 0)
        {
            cboCategory.SelectedIndex = 0;
        }
    }

    private void CboCategory_SelectedIndexChanged(object? sender, EventArgs e)
    {
        RefreshAvailableServices();
    }

    private void RefreshAvailableServices()
    {
        if (cboCategory.SelectedItem is not string selectedCategory)
        {
            return;
        }

        var selectedIds = lstSelectedServices.Items
            .OfType<ServiceItem>()
            .Select(s => s.Id)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        lstAvailableServices.BeginUpdate();
        try
        {
            lstAvailableServices.Items.Clear();
            foreach (ServiceItem item in _allServices.Where(s =>
                         s.Category == selectedCategory && !selectedIds.Contains(s.Id)))
            {
                lstAvailableServices.Items.Add(item);
            }
        }
        finally
        {
            lstAvailableServices.EndUpdate();
        }
    }

    private void BtnSelect_Click(object? sender, EventArgs e)
    {
        if (lstAvailableServices.SelectedItem is not ServiceItem item)
        {
            MessageBox.Show(
                "Vui lòng chọn một dịch vụ trong danh sách bên trái để thêm.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        MoveServiceToSelected(item);
    }

    private void LstAvailableServices_DoubleClick(object? sender, EventArgs e)
    {
        if (lstAvailableServices.SelectedItem is ServiceItem item)
        {
            MoveServiceToSelected(item);
        }
    }

    private void MoveServiceToSelected(ServiceItem item)
    {
        lstAvailableServices.Items.Remove(item);
        lstSelectedServices.Items.Add(item);
        RecalculateTotals();
    }

    private void BtnRemove_Click(object? sender, EventArgs e)
    {
        if (lstSelectedServices.SelectedItem is not ServiceItem item)
        {
            MessageBox.Show(
                "Vui lòng chọn một dịch vụ trong danh sách đã chọn để bỏ.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        RemoveServiceFromSelected(item);
    }

    private void LstSelectedServices_DoubleClick(object? sender, EventArgs e)
    {
        if (lstSelectedServices.SelectedItem is ServiceItem item)
        {
            RemoveServiceFromSelected(item);
        }
    }

    private void RemoveServiceFromSelected(ServiceItem item)
    {
        lstSelectedServices.Items.Remove(item);
        RefreshAvailableServices();
        RecalculateTotals();
    }

    private void BtnClearAll_Click(object? sender, EventArgs e)
    {
        if (lstSelectedServices.Items.Count == 0)
        {
            return;
        }

        lstSelectedServices.Items.Clear();
        RefreshAvailableServices();
        RecalculateTotals();
    }

    private void BtnApplyPromo_Click(object? sender, EventArgs e)
    {
        string code = txtPromoCode.Text.Trim();
        if (string.IsNullOrEmpty(code))
        {
            nudDiscount.Value = 0m;
            MessageBox.Show(
                "Đã đặt lại tỷ lệ chiết khấu về 0%.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        if (PromoCodes.TryGetValue(code, out decimal percent))
        {
            nudDiscount.Value = percent;
            MessageBox.Show(
                $"Áp dụng mã \"{code.ToUpperInvariant()}\" thành công! Giảm {percent:0}%.",
                "Áp dụng mã giảm giá",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(
                "Mã giảm giá không hợp lệ. Vui lòng thử: GIAM10, GIAM20 hoặc VIP30.",
                "Lỗi mã giảm giá",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtPromoCode.Focus();
            txtPromoCode.SelectAll();
        }
    }

    private void NudDiscount_ValueChanged(object? sender, EventArgs e)
    {
        RecalculateTotals();
    }

    /// <summary>
    /// Tính tổng tiền chưa giảm và thành tiền sau khi áp dụng tỷ lệ chiết khấu (%).
    /// </summary>
    public static (decimal SubTotal, decimal FinalTotal) CalculateTotals(
        IEnumerable<ServiceItem> selectedServices,
        decimal discountPercent)
    {
        decimal subTotal = selectedServices.Sum(s => s.Price);
        decimal clampedDiscount = Math.Clamp(discountPercent, 0m, 100m);
        decimal finalTotal = subTotal * (1m - clampedDiscount / 100m);
        return (subTotal, finalTotal);
    }

    private void RecalculateTotals()
    {
        var selected = lstSelectedServices.Items.OfType<ServiceItem>();
        var (subTotal, finalTotal) = CalculateTotals(selected, nudDiscount.Value);

        txtSubTotal.Text = $"{subTotal:N0} VNĐ";
        txtFinalTotal.Text = $"{finalTotal:N0} VNĐ";
    }

    private void BtnPay_Click(object? sender, EventArgs e)
    {
        var selected = lstSelectedServices.Items.OfType<ServiceItem>().ToList();
        if (selected.Count == 0)
        {
            MessageBox.Show(
                "Chưa có dịch vụ nào được chọn để thanh toán!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var (subTotal, finalTotal) = CalculateTotals(selected, nudDiscount.Value);
        string serviceLines = string.Join("\n", selected.Select((s, i) => $"  {i + 1}. {s.Name}: {s.Price:N0} VNĐ"));

        string summary =
            $"HÓA ĐƠN DỊCH VỤ\n\n" +
            $"{serviceLines}\n\n" +
            $"Tổng tiền chưa giảm: {subTotal:N0} VNĐ\n" +
            $"Chiết khấu: {nudDiscount.Value:0}%\n" +
            $"Thành tiền thanh toán: {finalTotal:N0} VNĐ";

        MessageBox.Show(summary, "Xác nhận thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
