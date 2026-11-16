using System.Drawing.Drawing2D;
using Haruka.Arcade.SEGA835Lib.Devices;
using Haruka.Arcade.SEGA835Lib.Devices.Card;
using Haruka.Arcade.SEGA835Lib.Devices.Misc;
using Timer = System.Windows.Forms.Timer;

namespace SegaY3Tool;

public partial class FormRender : Form {
    private readonly FormControl main;
    private Timer t;

    private readonly Font font;
    private readonly Font fontSmall;
    private readonly Brush brush;

    public FormRender(FormControl formControl) {
        main = formControl;
        InitializeComponent();

        font = new Font("Arial", 14);
        fontSmall = new Font("Arial", 7);
        brush = new SolidBrush(Color.Black);

        t = new Timer() {
            Interval = 50
        };
        t.Tick += TOnTick;
        t.Start();
    }

    private void TOnTick(object sender, EventArgs e) {
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        Y3 y3 = main.Y3;
        if (y3 == null) {
            return;
        }

        if (main.Mode == FormControl.State.Cards) {
            DrawCards(y3, e.Graphics);
        } else if (main.Mode == FormControl.State.Luminance) {
            DrawLuminance(y3, e.Graphics, e.ClipRectangle);
        } else if (main.Mode == FormControl.State.Firmware) {
            DrawFirmware(y3, e.Graphics);
        }
    }

    private void DrawFirmware(Y3 y3, Graphics g) {
        Y3.FirmwareUpdateStatus fw = y3.FirmwareUpdate;
        if (fw != null) {
            g.DrawString(fw.Status + "\n" + fw.Process + "\n" + (int)(fw.Progress * 100) + "%", font, brush, 0, 0);
        } else {
            g.DrawString("NO DATA", font, brush, 0, 0);
        }
    }

    private void DrawLuminance(Y3 y3, Graphics g, Rectangle client) {
        Y3.LedCalibrationData ld = y3.LuminanceData;
        if (ld == null) {
            g.DrawString("NO DATA", font, brush, 0, 0);
            return;
        }

        g.DrawString(ld.BoardStatus + "\n" + ld.X + "/" + ld.Y, font, brush, 0, 0);
        g.DrawString(ld.IsGood ? "GOOD" : "BAD", font, ld.IsGood ? Brushes.LimeGreen : Brushes.Red, 0, 70);

        int startY = 140;
        int width = 5;
        int height = 5;
        int rectWidth = client.Width / width;
        int rectHeight = 400 / height;

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                float lum = ld.GetLuminance(x, y);
                g.FillRectangle(lum >= 0.4 && lum <= 0.75 ? Brushes.LimeGreen : Brushes.Red, x * rectWidth, startY + y * rectHeight, rectWidth, rectHeight);
                g.DrawRectangle(Pens.Black, x * rectWidth, startY + y * rectHeight, rectWidth, rectHeight);
                g.DrawString((int)(lum * 100) + "%", font, brush, x * rectWidth + rectWidth / 2F - 40, startY + y * rectHeight + rectHeight / 2F - 17);
            }
        }
    }

    private void DrawCards(Y3 y3, Graphics g) {
        DeviceStatus ret = y3.GetCards(out uint count, out Y3.CardInfo[] cards, out uint time);
        if (ret != DeviceStatus.Ok) {
            g.DrawString("Card Read Error: " + ret + "\n" + y3.GetBoardErrorCode() + " / " + y3.GetBoardErrorMessage(), font, brush, 0, 0);
            return;
        }

        g.DrawString("Cards: " + count + "\nTime [ns]: " + time, font, brush, 0, 0);

        foreach (Y3.CardInfo c in cards) {
            if (c.CardType != Y3.CardInfo.DetectionType.Invalid) {
                RectangleF r = new RectangleF(c.X / 2, c.Y / 2, 65, 103);
                RotateRectangle(g, r, c.Rotation, c.CardType == Y3.CardInfo.DetectionType.Card ? Pens.Black : Pens.Red);
                g.DrawString(c.GetIvCode() + "\n" + (int)c.X + "/" + (int)c.Y + "\n" + c.CardType + "\n" + c.UnknownType, fontSmall, brush, c.X / 2 + 3, c.Y / 2 + 3);
            }
        }
    }

    public static void RotateRectangle(Graphics g, RectangleF r, float angle, Pen pen) {
        using (Matrix m = new Matrix()) {
            m.RotateAt(angle, new PointF(r.Left + (r.Width / 2F), r.Top + (r.Height / 2F)));
            g.Transform = m;
            g.DrawRectangle(pen, r);
            g.ResetTransform();
        }
    }
}