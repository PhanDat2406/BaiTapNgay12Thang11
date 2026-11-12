namespace Bai5_1;

public partial class FrmDangKy : Form
{
    private const int MinimumRegistrationAge = 18;

    public FrmDangKy()
    {
        InitializeComponent();
    }

    private void FrmDangKy_Load(object? sender, EventArgs e)
    {
        ResetFormState();
    }

    /// <summary>
    /// Tính tuổi chính xác theo ngày/tháng/năm sinh tính đến ngày tham chiếu.
    /// </summary>
    public static int CalculateAge(DateTime birthDate, DateTime referenceDate)
    {
        DateTime dob = birthDate.Date;
        DateTime today = referenceDate.Date;
        int age = today.Year - dob.Year;
        if (dob > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }

    private void BtnRegister_Click(object? sender, EventArgs e)
    {
        if (!ValidateRegistrationInputs(out Control? firstInvalidControl))
        {
            firstInvalidControl?.Focus();
            return;
        }

        string gender = GetSelectedGender();
        int age = CalculateAge(dtpBirthDate.Value, DateTime.Today);

        string message =
            $"Đăng ký tài khoản thành công!\n\n" +
            $"- Tên đăng nhập: {txtUsername.Text.Trim()}\n" +
            $"- Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy} ({age} tuổi)\n" +
            $"- Giới tính: {gender}";

        MessageBox.Show(
            message,
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private bool ValidateRegistrationInputs(out Control? firstInvalidControl)
    {
        epCheck.Clear();
        Control? firstInvalid = null;

        void MarkError(Control control, string message)
        {
            epCheck.SetError(control, message);
            firstInvalid ??= control;
        }

        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            MarkError(txtUsername, "Tên đăng nhập không được để trống.");
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            MarkError(txtPassword, "Mật khẩu không được để trống.");
        }

        if (string.IsNullOrEmpty(txtConfirmPassword.Text))
        {
            MarkError(txtConfirmPassword, "Vui lòng nhập xác nhận mật khẩu.");
        }
        else if (txtConfirmPassword.Text != txtPassword.Text)
        {
            MarkError(txtConfirmPassword, "Mật khẩu nhập lại không khớp với mật khẩu ban đầu.");
        }

        int age = CalculateAge(dtpBirthDate.Value, DateTime.Today);
        if (age < MinimumRegistrationAge)
        {
            MarkError(dtpBirthDate, $"Độ tuổi phải từ {MinimumRegistrationAge} tuổi trở lên (hiện tại: {age} tuổi).");
        }

        if (!chkAgree.Checked)
        {
            MarkError(chkAgree, "Bạn phải đồng ý với Điều khoản dịch vụ.");
        }

        firstInvalidControl = firstInvalid;
        return firstInvalidControl is null;
    }

    private string GetSelectedGender()
    {
        if (rdoMale.Checked)
        {
            return "Nam";
        }
        if (rdoFemale.Checked)
        {
            return "Nữ";
        }
        return "Khác";
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        ResetFormState();
    }

    private void ResetFormState()
    {
        epCheck.Clear();
        txtUsername.Clear();
        txtPassword.Clear();
        txtConfirmPassword.Clear();
        dtpBirthDate.Value = DateTime.Today;
        rdoMale.Checked = true;
        chkAgree.Checked = false;
        txtUsername.Focus();
    }

    private void InputControl_Changed(object? sender, EventArgs e)
    {
        if (sender is Control control)
        {
            epCheck.SetError(control, string.Empty);
        }
    }
}
