namespace Bai5_1;

public partial class FrmDangKy
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
        grpThongTinCaNhan = new GroupBox();
        txtConfirmPassword = new TextBox();
        lblConfirmPassword = new Label();
        txtPassword = new TextBox();
        lblPassword = new Label();
        txtUsername = new TextBox();
        lblUsername = new Label();
        grpThongTinBoSung = new GroupBox();
        chkAgree = new CheckBox();
        rdoOther = new RadioButton();
        rdoFemale = new RadioButton();
        rdoMale = new RadioButton();
        lblGender = new Label();
        dtpBirthDate = new DateTimePicker();
        lblBirthDate = new Label();
        btnRegister = new Button();
        btnReset = new Button();
        epCheck = new ErrorProvider(components);
        grpThongTinCaNhan.SuspendLayout();
        grpThongTinBoSung.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
        SuspendLayout();

        // 
        // grpThongTinCaNhan
        // 
        grpThongTinCaNhan.Controls.Add(txtConfirmPassword);
        grpThongTinCaNhan.Controls.Add(lblConfirmPassword);
        grpThongTinCaNhan.Controls.Add(txtPassword);
        grpThongTinCaNhan.Controls.Add(lblPassword);
        grpThongTinCaNhan.Controls.Add(txtUsername);
        grpThongTinCaNhan.Controls.Add(lblUsername);
        grpThongTinCaNhan.Location = new Point(12, 12);
        grpThongTinCaNhan.Name = "grpThongTinCaNhan";
        grpThongTinCaNhan.Size = new Size(460, 144);
        grpThongTinCaNhan.TabIndex = 0;
        grpThongTinCaNhan.TabStop = false;
        grpThongTinCaNhan.Text = "Thông tin cá nhân";

        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(16, 28);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(88, 15);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Tên đăng nhập:";

        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(155, 25);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(262, 23);
        txtUsername.TabIndex = 1;
        txtUsername.TextChanged += InputControl_Changed;

        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(16, 66);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(60, 15);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Mật khẩu:";

        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(155, 63);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(262, 23);
        txtPassword.TabIndex = 3;
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.TextChanged += InputControl_Changed;

        // 
        // lblConfirmPassword
        // 
        lblConfirmPassword.AutoSize = true;
        lblConfirmPassword.Location = new Point(16, 104);
        lblConfirmPassword.Name = "lblConfirmPassword";
        lblConfirmPassword.Size = new Size(111, 15);
        lblConfirmPassword.TabIndex = 4;
        lblConfirmPassword.Text = "Xác nhận mật khẩu:";

        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.Location = new Point(155, 101);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.Size = new Size(262, 23);
        txtConfirmPassword.TabIndex = 5;
        txtConfirmPassword.UseSystemPasswordChar = true;
        txtConfirmPassword.TextChanged += InputControl_Changed;

        // 
        // grpThongTinBoSung
        // 
        grpThongTinBoSung.Controls.Add(chkAgree);
        grpThongTinBoSung.Controls.Add(rdoOther);
        grpThongTinBoSung.Controls.Add(rdoFemale);
        grpThongTinBoSung.Controls.Add(rdoMale);
        grpThongTinBoSung.Controls.Add(lblGender);
        grpThongTinBoSung.Controls.Add(dtpBirthDate);
        grpThongTinBoSung.Controls.Add(lblBirthDate);
        grpThongTinBoSung.Location = new Point(12, 168);
        grpThongTinBoSung.Name = "grpThongTinBoSung";
        grpThongTinBoSung.Size = new Size(460, 136);
        grpThongTinBoSung.TabIndex = 1;
        grpThongTinBoSung.TabStop = false;
        grpThongTinBoSung.Text = "Thông tin bổ sung";

        // 
        // lblBirthDate
        // 
        lblBirthDate.AutoSize = true;
        lblBirthDate.Location = new Point(16, 28);
        lblBirthDate.Name = "lblBirthDate";
        lblBirthDate.Size = new Size(63, 15);
        lblBirthDate.TabIndex = 0;
        lblBirthDate.Text = "Ngày sinh:";

        // 
        // dtpBirthDate
        // 
        dtpBirthDate.CustomFormat = "dd/MM/yyyy";
        dtpBirthDate.Format = DateTimePickerFormat.Custom;
        dtpBirthDate.Location = new Point(155, 24);
        dtpBirthDate.Name = "dtpBirthDate";
        dtpBirthDate.Size = new Size(262, 23);
        dtpBirthDate.TabIndex = 1;
        dtpBirthDate.ValueChanged += InputControl_Changed;

        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Location = new Point(16, 65);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(57, 15);
        lblGender.TabIndex = 2;
        lblGender.Text = "Giới tính:";

        // 
        // rdoMale
        // 
        rdoMale.AutoSize = true;
        rdoMale.Checked = true;
        rdoMale.Location = new Point(155, 63);
        rdoMale.Name = "rdoMale";
        rdoMale.Size = new Size(51, 19);
        rdoMale.TabIndex = 3;
        rdoMale.TabStop = true;
        rdoMale.Text = "Nam";
        rdoMale.UseVisualStyleBackColor = true;

        // 
        // rdoFemale
        // 
        rdoFemale.AutoSize = true;
        rdoFemale.Location = new Point(232, 63);
        rdoFemale.Name = "rdoFemale";
        rdoFemale.Size = new Size(41, 19);
        rdoFemale.TabIndex = 4;
        rdoFemale.Text = "Nữ";
        rdoFemale.UseVisualStyleBackColor = true;

        // 
        // rdoOther
        // 
        rdoOther.AutoSize = true;
        rdoOther.Location = new Point(304, 63);
        rdoOther.Name = "rdoOther";
        rdoOther.Size = new Size(50, 19);
        rdoOther.TabIndex = 5;
        rdoOther.Text = "Khác";
        rdoOther.UseVisualStyleBackColor = true;

        // 
        // chkAgree
        // 
        chkAgree.AutoSize = true;
        chkAgree.Location = new Point(155, 100);
        chkAgree.Name = "chkAgree";
        chkAgree.Size = new Size(205, 19);
        chkAgree.TabIndex = 6;
        chkAgree.Text = "Tôi đồng ý với Điều khoản dịch vụ";
        chkAgree.UseVisualStyleBackColor = true;
        chkAgree.CheckedChanged += InputControl_Changed;

        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(132, 318);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(105, 32);
        btnRegister.TabIndex = 2;
        btnRegister.Text = "Đăng Ký";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += BtnRegister_Click;

        // 
        // btnReset
        // 
        btnReset.Location = new Point(252, 318);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(105, 32);
        btnReset.TabIndex = 3;
        btnReset.Text = "Làm Mới";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += BtnReset_Click;

        // 
        // epCheck
        // 
        epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        epCheck.ContainerControl = this;

        // 
        // FrmDangKy
        // 
        AcceptButton = btnRegister;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 366);
        Controls.Add(btnReset);
        Controls.Add(btnRegister);
        Controls.Add(grpThongTinBoSung);
        Controls.Add(grpThongTinCaNhan);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmDangKy";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.1 - Đăng Ký Tài Khoản (ErrorProvider)";
        Load += FrmDangKy_Load;
        grpThongTinCaNhan.ResumeLayout(false);
        grpThongTinCaNhan.PerformLayout();
        grpThongTinBoSung.ResumeLayout(false);
        grpThongTinBoSung.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpThongTinCaNhan = null!;
    private Label lblUsername = null!;
    private TextBox txtUsername = null!;
    private Label lblPassword = null!;
    private TextBox txtPassword = null!;
    private Label lblConfirmPassword = null!;
    private TextBox txtConfirmPassword = null!;
    private GroupBox grpThongTinBoSung = null!;
    private Label lblBirthDate = null!;
    private DateTimePicker dtpBirthDate = null!;
    private Label lblGender = null!;
    private RadioButton rdoMale = null!;
    private RadioButton rdoFemale = null!;
    private RadioButton rdoOther = null!;
    private CheckBox chkAgree = null!;
    private Button btnRegister = null!;
    private Button btnReset = null!;
    private ErrorProvider epCheck = null!;
}
