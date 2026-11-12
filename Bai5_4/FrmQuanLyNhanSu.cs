namespace Bai5_4;

public partial class FrmQuanLyNhanSu : Form
{
    private readonly List<Employee> _employees = [];

    public FrmQuanLyNhanSu()
    {
        InitializeComponent();
    }

    private void FrmQuanLyNhanSu_Load(object? sender, EventArgs e)
    {
        IconFactory.PopulateTreeIcons(imlTree);
        IconFactory.PopulateEmployeeIcons(imlSmall, imlLarge);

        LoadViewModes();
        SeedEmployees();
        BuildOrganizationTree();
    }

    private void LoadViewModes()
    {
        cboViewMode.Items.Clear();
        cboViewMode.Items.AddRange(
        [
            View.Details,
            View.LargeIcon,
            View.SmallIcon,
            View.List,
            View.Tile
        ]);
        cboViewMode.SelectedItem = View.Details;
    }

    private void SeedEmployees()
    {
        _employees.Clear();
        _employees.AddRange(
        [
            // Phòng Kỹ thuật - Nhóm Backend
            new Employee
            {
                EmployeeId = "NV001", FullName = "Nguyễn Văn An", Position = "Trưởng nhóm Backend",
                HireDate = new DateTime(2020, 3, 15), Department = "Phòng Kỹ thuật", Team = "Nhóm Backend", IconIndex = 0
            },
            new Employee
            {
                EmployeeId = "NV002", FullName = "Trần Minh Quân", Position = "Lập trình viên .NET Senior",
                HireDate = new DateTime(2021, 7, 1), Department = "Phòng Kỹ thuật", Team = "Nhóm Backend", IconIndex = 1
            },
            new Employee
            {
                EmployeeId = "NV003", FullName = "Lê Hoàng Nam", Position = "Lập trình viên Backend",
                HireDate = new DateTime(2023, 2, 20), Department = "Phòng Kỹ thuật", Team = "Nhóm Backend", IconIndex = 1
            },

            // Phòng Kỹ thuật - Nhóm Frontend
            new Employee
            {
                EmployeeId = "NV004", FullName = "Phạm Thị Thu Hà", Position = "Trưởng nhóm Frontend",
                HireDate = new DateTime(2020, 11, 10), Department = "Phòng Kỹ thuật", Team = "Nhóm Frontend", IconIndex = 0
            },
            new Employee
            {
                EmployeeId = "NV005", FullName = "Võ Quốc Bảo", Position = "Lập trình viên React/UI",
                HireDate = new DateTime(2022, 5, 18), Department = "Phòng Kỹ thuật", Team = "Nhóm Frontend", IconIndex = 1
            },

            // Phòng Kỹ thuật - Nhóm QA
            new Employee
            {
                EmployeeId = "NV006", FullName = "Đặng Ngọc Mai", Position = "Chuyên viên Kiểm thử (QA)",
                HireDate = new DateTime(2022, 9, 5), Department = "Phòng Kỹ thuật", Team = "Nhóm QA / Kiểm thử", IconIndex = 1
            },
            new Employee
            {
                EmployeeId = "NV007", FullName = "Bùi Thanh Tùng", Position = "Kỹ sư Automation Test",
                HireDate = new DateTime(2024, 1, 8), Department = "Phòng Kỹ thuật", Team = "Nhóm QA / Kiểm thử", IconIndex = 1
            },

            // Phòng Kinh doanh - Nhóm Bán hàng
            new Employee
            {
                EmployeeId = "NV008", FullName = "Hoàng Anh Tuấn", Position = "Trưởng phòng Kinh doanh",
                HireDate = new DateTime(2019, 6, 12), Department = "Phòng Kinh doanh", Team = "Nhóm Bán hàng", IconIndex = 0
            },
            new Employee
            {
                EmployeeId = "NV009", FullName = "Nguyễn Thị Lan Anh", Position = "Chuyên viên Tư vấn B2B",
                HireDate = new DateTime(2022, 4, 4), Department = "Phòng Kinh doanh", Team = "Nhóm Bán hàng", IconIndex = 2
            },

            // Phòng Kinh doanh - Nhóm Marketing
            new Employee
            {
                EmployeeId = "NV010", FullName = "Trương Gia Huy", Position = "Trưởng nhóm Marketing",
                HireDate = new DateTime(2021, 8, 23), Department = "Phòng Kinh doanh", Team = "Nhóm Marketing", IconIndex = 0
            },
            new Employee
            {
                EmployeeId = "NV011", FullName = "Đỗ Phương Thảo", Position = "Chuyên viên Digital Marketing",
                HireDate = new DateTime(2023, 10, 14), Department = "Phòng Kinh doanh", Team = "Nhóm Marketing", IconIndex = 2
            },

            // Phòng Nhân sự - Nhóm Tuyển dụng
            new Employee
            {
                EmployeeId = "NV012", FullName = "Lý Hồng Nhung", Position = "Trưởng phòng Nhân sự",
                HireDate = new DateTime(2019, 1, 21), Department = "Phòng Nhân sự", Team = "Nhóm Tuyển dụng", IconIndex = 0
            },
            new Employee
            {
                EmployeeId = "NV013", FullName = "Phan Thị Ngọc Bích", Position = "Chuyên viên Tuyển dụng IT",
                HireDate = new DateTime(2023, 3, 27), Department = "Phòng Nhân sự", Team = "Nhóm Tuyển dụng", IconIndex = 3
            },

            // Phòng Nhân sự - Nhóm Hành chính - Kế toán
            new Employee
            {
                EmployeeId = "NV014", FullName = "Vũ Đình Khôi", Position = "Kế toán tổng hợp",
                HireDate = new DateTime(2021, 12, 6), Department = "Phòng Nhân sự", Team = "Nhóm Hành chính - Kế toán", IconIndex = 3
            },
            new Employee
            {
                EmployeeId = "NV015", FullName = "Ngô Thanh Tâm", Position = "Chuyên viên Hành chính",
                HireDate = new DateTime(2024, 5, 2), Department = "Phòng Nhân sự", Team = "Nhóm Hành chính - Kế toán", IconIndex = 3
            }
        ]);
    }

    private void BuildOrganizationTree()
    {
        tvDepartments.BeginUpdate();
        try
        {
            tvDepartments.Nodes.Clear();

            const string companyName = "Công ty Công nghệ ABC";
            var rootNode = new TreeNode(companyName, 0, 0)
            {
                Tag = new OrganizationNodeTag(OrganizationNodeLevel.Company, companyName)
            };

            var departments = new (string DeptName, string[] Teams)[]
            {
                ("Phòng Kỹ thuật", ["Nhóm Backend", "Nhóm Frontend", "Nhóm QA / Kiểm thử"]),
                ("Phòng Kinh doanh", ["Nhóm Bán hàng", "Nhóm Marketing"]),
                ("Phòng Nhân sự", ["Nhóm Tuyển dụng", "Nhóm Hành chính - Kế toán"])
            };

            foreach (var (deptName, teams) in departments)
            {
                var deptNode = new TreeNode(deptName, 1, 1)
                {
                    Tag = new OrganizationNodeTag(
                        OrganizationNodeLevel.Department,
                        $"{companyName} > {deptName}",
                        Department: deptName)
                };

                foreach (string teamName in teams)
                {
                    var teamNode = new TreeNode(teamName, 2, 2)
                    {
                        Tag = new OrganizationNodeTag(
                            OrganizationNodeLevel.Team,
                            $"{companyName} > {deptName} > {teamName}",
                            Department: deptName,
                            Team: teamName)
                    };
                    deptNode.Nodes.Add(teamNode);
                }

                rootNode.Nodes.Add(deptNode);
            }

            tvDepartments.Nodes.Add(rootNode);
            tvDepartments.ExpandAll();
            tvDepartments.SelectedNode = rootNode;
        }
        finally
        {
            tvDepartments.EndUpdate();
        }
    }

    /// <summary>
    /// Lọc danh sách nhân viên theo cấp Node (Công ty / Phòng ban / Nhóm).
    /// </summary>
    public static List<Employee> FilterEmployees(IEnumerable<Employee> allEmployees, OrganizationNodeTag tag)
    {
        return tag.Level switch
        {
            OrganizationNodeLevel.Company => allEmployees.ToList(),
            OrganizationNodeLevel.Department => allEmployees
                .Where(e => string.Equals(e.Department, tag.Department, StringComparison.OrdinalIgnoreCase))
                .ToList(),
            OrganizationNodeLevel.Team => allEmployees
                .Where(e =>
                    string.Equals(e.Department, tag.Department, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(e.Team, tag.Team, StringComparison.OrdinalIgnoreCase))
                .ToList(),
            _ => []
        };
    }

    private void TvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
    {
        LoadEmployeesForSelectedNode();
    }

    private void CboViewMode_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboViewMode.SelectedItem is View selectedView)
        {
            lsvEmployees.View = selectedView;
            LoadEmployeesForSelectedNode();
        }
    }

    private void LoadEmployeesForSelectedNode()
    {
        if (tvDepartments.SelectedNode?.Tag is not OrganizationNodeTag nodeTag)
        {
            return;
        }

        List<Employee> filtered = FilterEmployees(_employees, nodeTag);
        bool useCompositeItemText = lsvEmployees.View is View.LargeIcon or View.SmallIcon or View.List;

        lsvEmployees.BeginUpdate();
        try
        {
            lsvEmployees.Items.Clear();
            foreach (Employee emp in filtered)
            {
                string primaryText = useCompositeItemText
                    ? $"{emp.FullName} ({emp.EmployeeId})"
                    : emp.EmployeeId;

                var item = new ListViewItem(primaryText, emp.IconIndex)
                {
                    Tag = emp,
                    ToolTipText = $"{emp.FullName} ({emp.EmployeeId})\n{emp.Position}\n{emp.Department} - {emp.Team}\nNgày vào làm: {emp.HireDate:dd/MM/yyyy}"
                };

                item.SubItems.Add(emp.FullName);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.HireDate.ToString("dd/MM/yyyy"));

                lsvEmployees.Items.Add(item);
            }
        }
        finally
        {
            lsvEmployees.EndUpdate();
        }

        lblListTitle.Text = $"Danh sách nhân viên — {tvDepartments.SelectedNode.Text} ({filtered.Count})";
        lblStatus.Text = $"Đang xem: {nodeTag.DisplayPath} | Tổng số: {filtered.Count} nhân viên | Chế độ: {lsvEmployees.View}";
    }

    private void LsvEmployees_DoubleClick(object? sender, EventArgs e)
    {
        if (lsvEmployees.SelectedItems.Count == 0 || lsvEmployees.SelectedItems[0].Tag is not Employee emp)
        {
            return;
        }

        string details =
            $"Mã NV: {emp.EmployeeId}\n" +
            $"Họ tên: {emp.FullName}\n" +
            $"Chức vụ: {emp.Position}\n" +
            $"Phòng ban: {emp.Department}\n" +
            $"Nhóm: {emp.Team}\n" +
            $"Ngày vào làm: {emp.HireDate:dd/MM/yyyy}";

        MessageBox.Show(details, "Thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
