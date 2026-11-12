namespace Bai5_3;

/// <summary>
/// Lớp đối tượng sản phẩm lưu trữ trong bộ nhớ.
/// </summary>
public class Product
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; } = string.Empty;
}
