using System.Drawing;

namespace ImageLinksLoader_Net2
{
    public class ResizeFormResult
    {
        public bool? IsByPercintage { get; set; }

        public bool IsCropBorders { get; set; }

        public int Size { get; set; }

        public Rectangle Rect { get; set; }
        public RectangleF RectF { get; set; }
    }
}
