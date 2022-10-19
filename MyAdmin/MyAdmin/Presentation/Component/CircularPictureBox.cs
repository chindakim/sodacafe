using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace MyAdmin.Presentation.Component
{
    class CircularPictureBox:PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashCap borderCapStyle = DashCap.Flat;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private float gradientAngle = 50F;
        public CircularPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int BorderSize { get => borderSize; set {
                borderSize = value;
                this.Invalidate();
            } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public Color BorderColor2 { get => borderColor2; set { borderColor2 = value; this.Invalidate(); } }
        public DashStyle BorderLineStyle { get => borderLineStyle; set { borderLineStyle = value; this.Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }

        public DashCap BorderCapStyle { get => borderCapStyle; set => borderCapStyle = value; }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Field
            var graph = pe.Graphics;
            var rectContourSmoth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmoth, -borderSize, -borderSize);
            var smothSize = borderSize > 0 ? borderSize * 3 : -1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegin = new GraphicsPath())
            using (var penSmoth = new Pen(this.Parent.BackColor, smothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = BorderCapStyle;
                pathRegin.AddEllipse(rectContourSmoth);
                this.Region = new Region(pathRegin);
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                //Drawing
                graph.DrawEllipse(penSmoth, rectContourSmoth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
