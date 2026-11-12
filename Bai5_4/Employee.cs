namespace Bai5_4;

/// <summary>
/// Thông tin nhân viên thuộc phòng ban và nhóm.
/// </summary>
public class Employee
{
    public string EmployeeId { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public string Department { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public int IconIndex { get; set; }
}

public enum OrganizationNodeLevel
{
    Company,
    Department,
    Team
}

/// <summary>
/// Siêu dữ liệu gắn vào Tag của từng TreeNode để lọc nhân viên chính xác.
/// </summary>
public sealed record OrganizationNodeTag(
    OrganizationNodeLevel Level,
    string DisplayPath,
    string? Department = null,
    string? Team = null);
