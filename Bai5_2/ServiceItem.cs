namespace Bai5_2;

/// <summary>
/// Đại diện cho một dịch vụ y tế có mã, tên, phân loại và đơn giá.
/// </summary>
public class ServiceItem
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public override string ToString() => $"{Name} - {Price:N0} VNĐ";
}
