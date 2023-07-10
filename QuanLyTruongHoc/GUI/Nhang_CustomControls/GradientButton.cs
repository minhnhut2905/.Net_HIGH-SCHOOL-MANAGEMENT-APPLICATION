using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI.Nhang_CustomControls
{
    [DefaultEvent("Click")]
    public partial class GradientButton : UserControl
    {
        int wh = 20; float ang=45;
        Color cl0 = Color.BlueViolet, cl1 = Color.Red;
        Timer t = new Timer();
        string text = "Nhang Gradient Button";
        
        public GradientButton()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e)=> { ang %= 360 + 1; };
            ForeColor = Color.White;
        }
        [Category("Thanks Nhang Code Advance")]
        public float Angle
        {
            get { return ang; }
            set { ang = value;  Invalidate(); }
        }
        [Category("Thanks Nhang Code Advance")]
        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }
        [Category("Thanks Nhang Code Advance")]
        public Color Cl0 { get => cl0; set { cl0 = value; Invalidate(); } }
        [Category("Thanks Nhang Code Advance")]
        public Color Cl1 { get => cl1; set { cl1 = value; Invalidate(); } }
        [Category("Thanks Nhang Code Advance")]
        public string Text1 { get => text; set => text = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh-1, 0 ,wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh-1, Height-wh-1, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh-1, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0,cl1,ang), gp);
            e.Graphics.DrawString(Text1, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }
    }
}
