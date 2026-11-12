namespace Bai5_2;

public partial class FrmTinhTienDichVu
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
        lblCategory = new Label();
        cboCategory = new ComboBox();
        lblAvailable = new Label();
        lstAvailableServices = new ListBox();
        lblSelected = new Label();
        lstSelectedServices = new ListBox();
        btnSelect = new Button();
        btnRemove = new Button();
        btnClearAll = new Button();
        grpBilling = new GroupBox();
        btnPay = new Button();
        lblPromoHint = new Label();
        btnApplyPromo = new Button();
        txtPromoCode = new TextBox();
        lblPromoCode = new Label();
        txtFinalTotal = new TextBox();
        lblFinalTotal = new Label();
        nudDiscount = new NumericUpDown();
        lblDiscount = new Label();
        txtSubTotal = new TextBox();
        lblSubTotal = new Label();
        grpBilling.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
        SuspendLayout();

        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(12, 18);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(76, 15);
        lblCategory.TabIndex = 0;
        lblCategory.Text = "Loại dịch vụ:";

        // 
        // cboCategory
        // 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new Point(100, 14);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(242, 23);
        cboCategory.TabIndex = 1;
        cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;

        // 
        // lblAvailable
        // 
        lblAvailable.AutoSize = true;
        lblAvailable.Location = new Point(12, 52);
        lblAvailable.Name = "lblAvailable";
        lblAvailable.Size = new Size(192, 15);
        lblAvailable.TabIndex = 2;
        lblAvailable.Text = "Danh sách dịch vụ (Double-click):";

        // 
        // lstAvailableServices
        // 
        lstAvailableServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lstAvailableServices.FormattingEnabled = true;
        lstAvailableServices.HorizontalScrollbar = true;
        lstAvailableServices.ItemHeight = 15;
        lstAvailableServices.Location = new Point(12, 72);
        lstAvailableServices.Name = "lstAvailableServices";
        lstAvailableServices.Size = new Size(330, 244);
        lstAvailableServices.TabIndex = 3;
        lstAvailableServices.DoubleClick += LstAvailableServices_DoubleClick;

        // 
        // btnSelect
        // 
        btnSelect.Location = new Point(360, 126);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(76, 32);
        btnSelect.TabIndex = 4;
        btnSelect.Text = ">";
        btnSelect.UseVisualStyleBackColor = true;
        btnSelect.Click += BtnSelect_Click;

        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(360, 170);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(76, 32);
        btnRemove.TabIndex = 5;
        btnRemove.Text = "<";
        btnRemove.UseVisualStyleBackColor = true;
        btnRemove.Click += BtnRemove_Click;

        // 
        // btnClearAll
        // 
        btnClearAll.Location = new Point(360, 214);
        btnClearAll.Name = "btnClearAll";
        btnClearAll.Size = new Size(76, 32);
        btnClearAll.TabIndex = 6;
        btnClearAll.Text = "<<";
        btnClearAll.UseVisualStyleBackColor = true;
        btnClearAll.Click += BtnClearAll_Click;

        // 
        // lblSelected
        // 
        lblSelected.AutoSize = true;
        lblSelected.Location = new Point(454, 52);
        lblSelected.Name = "lblSelected";
        lblSelected.Size = new Size(105, 15);
        lblSelected.TabIndex = 7;
        lblSelected.Text = "Dịch vụ đã chọn:";

        // 
        // lstSelectedServices
        // 
        lstSelectedServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lstSelectedServices.FormattingEnabled = true;
        lstSelectedServices.HorizontalScrollbar = true;
        lstSelectedServices.ItemHeight = 15;
        lstSelectedServices.Location = new Point(454, 72);
        lstSelectedServices.Name = "lstSelectedServices";
        lstSelectedServices.Size = new Size(334, 244);
        lstSelectedServices.TabIndex = 8;
        lstSelectedServices.DoubleClick += LstSelectedServices_DoubleClick;

        // 
        // grpBilling
        // 
        grpBilling.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpBilling.Controls.Add(btnPay);
        grpBilling.Controls.Add(lblPromoHint);
        grpBilling.Controls.Add(btnApplyPromo);
        grpBilling.Controls.Add(txtPromoCode);
        grpBilling.Controls.Add(lblPromoCode);
        grpBilling.Controls.Add(txtFinalTotal);
        grpBilling.Controls.Add(lblFinalTotal);
        grpBilling.Controls.Add(nudDiscount);
        grpBilling.Controls.Add(lblDiscount);
        grpBilling.Controls.Add(txtSubTotal);
        grpBilling.Controls.Add(lblSubTotal);
        grpBilling.Location = new Point(12, 330);
        grpBilling.Name = "grpBilling";
        grpBilling.Size = new Size(776, 156);
        grpBilling.TabIndex = 9;
        grpBilling.TabStop = false;
        grpBilling.Text = "Thông tin tính tiền && Chiết khấu";

        // 
        // lblPromoCode
        // 
        lblPromoCode.AutoSize = true;
        lblPromoCode.Location = new Point(16, 30);
        lblPromoCode.Name = "lblPromoCode";
        lblPromoCode.Size = new Size(80, 15);
        lblPromoCode.TabIndex = 0;
        lblPromoCode.Text = "Mã giảm giá:";

        // 
        // txtPromoCode
        // 
        txtPromoCode.CharacterCasing = CharacterCasing.Upper;
        txtPromoCode.Location = new Point(110, 27);
        txtPromoCode.Name = "txtPromoCode";
        txtPromoCode.PlaceholderText = "VD: GIAM10";
        txtPromoCode.Size = new Size(135, 23);
        txtPromoCode.TabIndex = 1;

        // 
        // btnApplyPromo
        // 
        btnApplyPromo.Location = new Point(255, 26);
        btnApplyPromo.Name = "btnApplyPromo";
        btnApplyPromo.Size = new Size(85, 25);
        btnApplyPromo.TabIndex = 2;
        btnApplyPromo.Text = "Áp dụng";
        btnApplyPromo.UseVisualStyleBackColor = true;
        btnApplyPromo.Click += BtnApplyPromo_Click;

        // 
        // lblPromoHint
        // 
        lblPromoHint.AutoSize = true;
        lblPromoHint.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
        lblPromoHint.Location = new Point(16, 62);
        lblPromoHint.Name = "lblPromoHint";
        lblPromoHint.Size = new Size(295, 15);
        lblPromoHint.TabIndex = 3;
        lblPromoHint.Text = "Mã hợp lệ: GIAM10 (10%), GIAM20 (20%), VIP30 (30%)";

        // 
        // btnPay
        // 
        btnPay.Location = new Point(16, 100);
        btnPay.Name = "btnPay";
        btnPay.Size = new Size(135, 34);
        btnPay.TabIndex = 4;
        btnPay.Text = "Thanh toán";
        btnPay.UseVisualStyleBackColor = true;
        btnPay.Click += BtnPay_Click;

        // 
        // lblSubTotal
        // 
        lblSubTotal.AutoSize = true;
        lblSubTotal.Location = new Point(404, 30);
        lblSubTotal.Name = "lblSubTotal";
        lblSubTotal.Size = new Size(121, 15);
        lblSubTotal.TabIndex = 5;
        lblSubTotal.Text = "Tổng tiền chưa giảm:";

        // 
        // txtSubTotal
        // 
        txtSubTotal.Location = new Point(558, 27);
        txtSubTotal.Name = "txtSubTotal";
        txtSubTotal.ReadOnly = true;
        txtSubTotal.Size = new Size(198, 23);
        txtSubTotal.TabIndex = 6;
        txtSubTotal.Text = "0 VNĐ";
        txtSubTotal.TextAlign = HorizontalAlignment.Right;

        // 
        // lblDiscount
        // 
        lblDiscount.AutoSize = true;
        lblDiscount.Location = new Point(404, 68);
        lblDiscount.Name = "lblDiscount";
        lblDiscount.Size = new Size(112, 15);
        lblDiscount.TabIndex = 7;
        lblDiscount.Text = "Tỷ lệ chiết khấu (%):";

        // 
        // nudDiscount
        // 
        nudDiscount.Location = new Point(558, 65);
        nudDiscount.Name = "nudDiscount";
        nudDiscount.Size = new Size(198, 23);
        nudDiscount.TabIndex = 8;
        nudDiscount.TextAlign = HorizontalAlignment.Right;
        nudDiscount.ValueChanged += NudDiscount_ValueChanged;

        // 
        // lblFinalTotal
        // 
        lblFinalTotal.AutoSize = true;
        lblFinalTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFinalTotal.Location = new Point(404, 108);
        lblFinalTotal.Name = "lblFinalTotal";
        lblFinalTotal.Size = new Size(136, 15);
        lblFinalTotal.TabIndex = 9;
        lblFinalTotal.Text = "Thành tiền thanh toán:";

        // 
        // txtFinalTotal
        // 
        txtFinalTotal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        txtFinalTotal.Location = new Point(558, 104);
        txtFinalTotal.Name = "txtFinalTotal";
        txtFinalTotal.ReadOnly = true;
        txtFinalTotal.Size = new Size(198, 24);
        txtFinalTotal.TabIndex = 10;
        txtFinalTotal.Text = "0 VNĐ";
        txtFinalTotal.TextAlign = HorizontalAlignment.Right;

        // 
        // FrmTinhTienDichVu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 498);
        Controls.Add(grpBilling);
        Controls.Add(lstSelectedServices);
        Controls.Add(lblSelected);
        Controls.Add(btnClearAll);
        Controls.Add(btnRemove);
        Controls.Add(btnSelect);
        Controls.Add(lstAvailableServices);
        Controls.Add(lblAvailable);
        Controls.Add(cboCategory);
        Controls.Add(lblCategory);
        MinimumSize = new Size(780, 480);
        Name = "FrmTinhTienDichVu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.2 - Bảng Tính Tiền Dịch Vụ & Chiết Khấu";
        Load += FrmTinhTienDichVu_Load;
        grpBilling.ResumeLayout(false);
        grpBilling.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblCategory = null!;
    private ComboBox cboCategory = null!;
    private Label lblAvailable = null!;
    private ListBox lstAvailableServices = null!;
    private Label lblSelected = null!;
    private ListBox lstSelectedServices = null!;
    private Button btnSelect = null!;
    private Button btnRemove = null!;
    private Button btnClearAll = null!;
    private GroupBox grpBilling = null!;
    private Label lblSubTotal = null!;
    private TextBox txtSubTotal = null!;
    private Label lblDiscount = null!;
    private NumericUpDown nudDiscount = null!;
    private Label lblFinalTotal = null!;
    private TextBox txtFinalTotal = null!;
    private Label lblPromoCode = null!;
    private TextBox txtPromoCode = null!;
    private Button btnApplyPromo = null!;
    private Label lblPromoHint = null!;
    private Button btnPay = null!;
}
