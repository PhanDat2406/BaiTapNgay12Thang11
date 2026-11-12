namespace Bai5_4;

public partial class FrmQuanLyNhanSu
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
        pnlHeader = new Panel();
        cboViewMode = new ComboBox();
        lblViewMode = new Label();
        splitMain = new SplitContainer();
        lblTreeTitle = new Label();
        tvDepartments = new TreeView();
        imlTree = new ImageList(components);
        lblListTitle = new Label();
        lsvEmployees = new ListView();
        colMaNV = new ColumnHeader();
        colHoTen = new ColumnHeader();
        colChucVu = new ColumnHeader();
        colNgayVaoLam = new ColumnHeader();
        imlLarge = new ImageList(components);
        imlSmall = new ImageList(components);
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripStatusLabel();
        pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();

        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(cboViewMode);
        pnlHeader.Controls.Add(lblViewMode);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(920, 40);
        pnlHeader.TabIndex = 0;

        // 
        // lblViewMode
        // 
        lblViewMode.AutoSize = true;
        lblViewMode.Location = new Point(12, 12);
        lblViewMode.Name = "lblViewMode";
        lblViewMode.Size = new Size(76, 15);
        lblViewMode.TabIndex = 0;
        lblViewMode.Text = "Chế độ xem:";

        // 
        // cboViewMode
        // 
        cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cboViewMode.FormattingEnabled = true;
        cboViewMode.Location = new Point(96, 8);
        cboViewMode.Name = "cboViewMode";
        cboViewMode.Size = new Size(165, 23);
        cboViewMode.TabIndex = 1;
        cboViewMode.SelectedIndexChanged += CboViewMode_SelectedIndexChanged;

        // 
        // splitMain
        // 
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(0, 40);
        splitMain.Name = "splitMain";
        splitMain.Panel1MinSize = 200;
        splitMain.Panel2MinSize = 360;
        splitMain.Size = new Size(920, 478);
        splitMain.SplitterDistance = 260;
        splitMain.SplitterWidth = 5;
        splitMain.TabIndex = 1;

        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(tvDepartments);
        splitMain.Panel1.Controls.Add(lblTreeTitle);
        splitMain.Panel1.Padding = new Padding(12, 4, 4, 8);

        // 
        // lblTreeTitle
        // 
        lblTreeTitle.Dock = DockStyle.Top;
        lblTreeTitle.Location = new Point(12, 4);
        lblTreeTitle.Name = "lblTreeTitle";
        lblTreeTitle.Size = new Size(244, 22);
        lblTreeTitle.TabIndex = 0;
        lblTreeTitle.Text = "Cơ cấu tổ chức (TreeView)";

        // 
        // tvDepartments
        // 
        tvDepartments.Dock = DockStyle.Fill;
        tvDepartments.HideSelection = false;
        tvDepartments.ImageIndex = 0;
        tvDepartments.ImageList = imlTree;
        tvDepartments.ItemHeight = 22;
        tvDepartments.Location = new Point(12, 26);
        tvDepartments.Name = "tvDepartments";
        tvDepartments.SelectedImageIndex = 0;
        tvDepartments.Size = new Size(244, 444);
        tvDepartments.TabIndex = 1;
        tvDepartments.AfterSelect += TvDepartments_AfterSelect;

        // 
        // imlTree
        // 
        imlTree.ColorDepth = ColorDepth.Depth32Bit;
        imlTree.ImageSize = new Size(16, 16);
        imlTree.TransparentColor = Color.Transparent;

        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.Controls.Add(lsvEmployees);
        splitMain.Panel2.Controls.Add(lblListTitle);
        splitMain.Panel2.Padding = new Padding(4, 4, 12, 8);

        // 
        // lblListTitle
        // 
        lblListTitle.Dock = DockStyle.Top;
        lblListTitle.Location = new Point(4, 4);
        lblListTitle.Name = "lblListTitle";
        lblListTitle.Size = new Size(639, 22);
        lblListTitle.TabIndex = 0;
        lblListTitle.Text = "Danh sách nhân viên (ListView)";

        // 
        // lsvEmployees
        // 
        lsvEmployees.Columns.AddRange([colMaNV, colHoTen, colChucVu, colNgayVaoLam]);
        lsvEmployees.Dock = DockStyle.Fill;
        lsvEmployees.FullRowSelect = true;
        lsvEmployees.GridLines = true;
        lsvEmployees.HideSelection = false;
        lsvEmployees.LargeImageList = imlLarge;
        lsvEmployees.Location = new Point(4, 26);
        lsvEmployees.MultiSelect = false;
        lsvEmployees.Name = "lsvEmployees";
        lsvEmployees.ShowItemToolTips = true;
        lsvEmployees.Size = new Size(639, 444);
        lsvEmployees.SmallImageList = imlSmall;
        lsvEmployees.TabIndex = 1;
        lsvEmployees.TileSize = new Size(235, 64);
        lsvEmployees.UseCompatibleStateImageBehavior = false;
        lsvEmployees.View = View.Details;
        lsvEmployees.DoubleClick += LsvEmployees_DoubleClick;

        // 
        // colMaNV
        // 
        colMaNV.Text = "Mã NV";
        colMaNV.Width = 90;

        // 
        // colHoTen
        // 
        colHoTen.Text = "Họ Tên";
        colHoTen.Width = 195;

        // 
        // colChucVu
        // 
        colChucVu.Text = "Chức vụ";
        colChucVu.Width = 220;

        // 
        // colNgayVaoLam
        // 
        colNgayVaoLam.Text = "Ngày vào làm";
        colNgayVaoLam.Width = 115;

        // 
        // imlLarge
        // 
        imlLarge.ColorDepth = ColorDepth.Depth32Bit;
        imlLarge.ImageSize = new Size(48, 48);
        imlLarge.TransparentColor = Color.Transparent;

        // 
        // imlSmall
        // 
        imlSmall.ColorDepth = ColorDepth.Depth32Bit;
        imlSmall.ImageSize = new Size(16, 16);
        imlSmall.TransparentColor = Color.Transparent;

        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange([lblStatus]);
        statusStrip1.Location = new Point(0, 518);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(920, 22);
        statusStrip1.TabIndex = 2;

        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(52, 17);
        lblStatus.Text = "Sẵn sàng";

        // 
        // FrmQuanLyNhanSu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(920, 540);
        Controls.Add(splitMain);
        Controls.Add(statusStrip1);
        Controls.Add(pnlHeader);
        MinimumSize = new Size(800, 460);
        Name = "FrmQuanLyNhanSu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5.4 - Quản Lý Tổ Chức & Nhân Sự (TreeView & ListView)";
        Load += FrmQuanLyNhanSu_Load;
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pnlHeader = null!;
    private Label lblViewMode = null!;
    private ComboBox cboViewMode = null!;
    private SplitContainer splitMain = null!;
    private Label lblTreeTitle = null!;
    private TreeView tvDepartments = null!;
    private ImageList imlTree = null!;
    private Label lblListTitle = null!;
    private ListView lsvEmployees = null!;
    private ColumnHeader colMaNV = null!;
    private ColumnHeader colHoTen = null!;
    private ColumnHeader colChucVu = null!;
    private ColumnHeader colNgayVaoLam = null!;
    private ImageList imlLarge = null!;
    private ImageList imlSmall = null!;
    private StatusStrip statusStrip1 = null!;
    private ToolStripStatusLabel lblStatus = null!;
}
