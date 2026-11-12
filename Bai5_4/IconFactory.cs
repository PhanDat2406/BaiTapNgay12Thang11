using System.Drawing.Drawing2D;

namespace Bai5_4;

/// <summary>
/// Tạo các biểu tượng sắc nét bằng GDI+ cho TreeView và ListView ImageList.
/// </summary>
internal static class IconFactory
{
    public static void PopulateTreeIcons(ImageList imageList)
    {
        imageList.Images.Clear();
        imageList.Images.Add(CreateBuildingIcon(16, Color.FromArgb(24, 90, 157)));   // 0: Công ty
        imageList.Images.Add(CreateFolderIcon(16, Color.FromArgb(217, 119, 6)));    // 1: Phòng ban
        imageList.Images.Add(CreateGroupIcon(16, Color.FromArgb(16, 124, 65)));     // 2: Nhóm
    }

    public static void PopulateEmployeeIcons(ImageList smallList, ImageList largeList)
    {
        smallList.Images.Clear();
        largeList.Images.Clear();

        Color[] roleColors =
        [
            Color.FromArgb(180, 83, 9),    // 0: Quản lý / Trưởng nhóm
            Color.FromArgb(24, 90, 157),   // 1: Kỹ thuật
            Color.FromArgb(16, 124, 65),   // 2: Kinh doanh
            Color.FromArgb(109, 40, 217)   // 3: Nhân sự / Hành chính
        ];

        foreach (Color color in roleColors)
        {
            smallList.Images.Add(CreateUserBadgeIcon(16, color));
            largeList.Images.Add(CreateUserBadgeIcon(48, color));
        }
    }

    private static Bitmap CreateBuildingIcon(int size, Color accent)
    {
        var bmp = new Bitmap(size, size);
        using Graphics g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);

        using var brush = new SolidBrush(accent);
        g.FillRectangle(brush, 3, 2, 10, 12);

        using var winBrush = new SolidBrush(Color.White);
        g.FillRectangle(winBrush, 5, 4, 2, 2);
        g.FillRectangle(winBrush, 9, 4, 2, 2);
        g.FillRectangle(winBrush, 5, 8, 2, 2);
        g.FillRectangle(winBrush, 9, 8, 2, 2);
        g.FillRectangle(winBrush, 7, 11, 2, 3);
        return bmp;
    }

    private static Bitmap CreateFolderIcon(int size, Color accent)
    {
        var bmp = new Bitmap(size, size);
        using Graphics g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);

        using var tabBrush = new SolidBrush(ControlPaint.Dark(accent, 0.1f));
        g.FillRectangle(tabBrush, 1, 3, 6, 3);

        using var bodyBrush = new SolidBrush(accent);
        g.FillRectangle(bodyBrush, 1, 5, 14, 9);
        return bmp;
    }

    private static Bitmap CreateGroupIcon(int size, Color accent)
    {
        var bmp = new Bitmap(size, size);
        using Graphics g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);

        using var brush = new SolidBrush(accent);
        g.FillEllipse(brush, 3, 3, 4, 4);
        g.FillEllipse(brush, 9, 3, 4, 4);
        g.FillPie(brush, 1, 8, 8, 8, 180, 180);
        g.FillPie(brush, 7, 8, 8, 8, 180, 180);
        return bmp;
    }

    private static Bitmap CreateUserBadgeIcon(int size, Color accent)
    {
        var bmp = new Bitmap(size, size);
        using Graphics g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);

        float margin = size >= 32 ? 3f : 1f;
        float diameter = size - margin * 2f;

        using var bgBrush = new SolidBrush(accent);
        g.FillEllipse(bgBrush, margin, margin, diameter, diameter);

        using var fgBrush = new SolidBrush(Color.White);
        float headSize = diameter * 0.34f;
        float headX = (size - headSize) / 2f;
        float headY = margin + diameter * 0.18f;
        g.FillEllipse(fgBrush, headX, headY, headSize, headSize);

        float bodyWidth = diameter * 0.62f;
        float bodyHeight = diameter * 0.44f;
        float bodyX = (size - bodyWidth) / 2f;
        float bodyY = headY + headSize + diameter * 0.06f;
        g.FillPie(fgBrush, bodyX, bodyY, bodyWidth, bodyHeight, 180, 180);

        return bmp;
    }
}
