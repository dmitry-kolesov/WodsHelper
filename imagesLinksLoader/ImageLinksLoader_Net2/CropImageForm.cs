using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ImageLinksLoader_Net2
{
    public partial class CropImageForm : Form
    {
        private FileInfo[] _paths;
        private int currentInd = 0;
        private Point startPoint;
        private Point endPoint;

        //private Point[] Points { get; set; }

        public ResizeFormResult ResizeResult { get; set; }

        public CropImageForm(FileInfo[] paths)
        {
            InitializeComponent();
            right_num.TextChanged += right_tbx_TextChanged;
            left_num.TextChanged += right_tbx_TextChanged;
            top_num.TextChanged += right_tbx_TextChanged;
            bottom_num.TextChanged += right_tbx_TextChanged;
            right_num.Maximum = left_num.Maximum = top_num.Maximum = bottom_num.Maximum = 2000;

            pbx.MouseDown += new MouseEventHandler(pbx_MouseDown);
            pbx.MouseUp += new MouseEventHandler(pbx_MouseUp);
            pbx.Paint += new PaintEventHandler(pbx_Paint);
            pbx.MouseMove += new MouseEventHandler(pbx_MouseMove);
            pbx.SizeMode = PictureBoxSizeMode.Zoom;

            if (paths.Length > 0 && !string.IsNullOrEmpty(paths[0].FullName))
            {
                _paths = paths;
                currentInd = -1;
                SetCurrentImage();
            }
        }

        bool isNeedRedraw = false;
        void right_tbx_TextChanged(object sender, EventArgs e)
        {
            if (isNeedRedraw)
            {
                _selection = new Rectangle((int)left_num.Value, (int)top_num.Value, (int)Math.Abs(right_num.Value - left_num.Value), (int)Math.Abs(bottom_num.Value - top_num.Value));
                _selecting = true;
                pbx.Refresh();
                _selecting = false;

                startPoint = new Point((int)left_num.Value, (int)top_num.Value);
                endPoint = new Point((int)right_num.Value, (int)bottom_num.Value);
            }
            //Points = new Point[] { startPoint, endPoint };         
        }


        void pbx_Paint(object sender, PaintEventArgs e)
        {
            if (_selecting)
            {
                // Draw a rectangle displaying the current selection
                Pen pen = Pens.GreenYellow;
                var rect = _selection;
                if (_selection.Width < 0)
                {
                    rect.X = _selection.X + _selection.Width;
                    rect.Width = -_selection.Width;
                }
                if (_selection.Height < 0)
                {
                    rect.Y = _selection.Y + _selection.Height;
                    rect.Height = -_selection.Height;
                }
                e.Graphics.DrawRectangle(pen, rect);

                // pen = Pens.Red;
                // rect = _selection;
                //e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private bool _selecting;
        private Rectangle _selection;

        void pbx_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
            isNeedRedraw = false;
            left_num.Value = Math.Max(Math.Min(startPoint.X, endPoint.X), 0);
            right_num.Value = Math.Max(startPoint.X, endPoint.X);//endPoint.X.ToString();
            top_num.Value = Math.Max(Math.Min(startPoint.Y, endPoint.Y), 0); //startPoint.Y.ToString();
            bottom_num.Value = Math.Max(startPoint.Y, endPoint.Y);//endPoint.Y.ToString();
            isNeedRedraw = true;

            //var maxPnt = new Point(Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y));
            //startPoint.X = (int)((double)startPoint.X / maxPnt.X) * pbx.Image.Size.Width;
            //startPoint.Y = (int)((double)startPoint.Y / maxPnt.Y) * pbx.Image.Size.Height;
            //endPoint.X = (int)((double)endPoint.X / maxPnt.X) * pbx.Image.Size.Width;
            //endPoint.Y = (int)((double)endPoint.Y / maxPnt.Y) * pbx.Image.Size.Height;

            _selecting = false;

            //_selection.Width = e.X - _selection.X;
            //_selection.Height = e.Y - _selection.Y;

            //Points = new Point[] { startPoint, endPoint };
        }

        void pbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = new Point(e.X, e.Y);
                _selecting = true;
                _selection = new Rectangle(new Point(e.X, e.Y), new Size());
            }
        }

        private void pbx_MouseMove(object sender, MouseEventArgs e)
        {
            // Update the actual size of the selection:
            if (_selecting)
            {
                _selection.Width = (e.X - _selection.X);
                _selection.Height = (e.Y - _selection.Y);

                // Redraw the picturebox:
                pbx.Refresh();
            }
        }

        private void saveSize_btn_Click(object sender, EventArgs e)
        {
            var res = resizeControl1.GetResizeFormResult();
            ResizeResult = new ResizeFormResult { IsByPercintage = res.IsByPercintage, Size = res.Size, Rect = GetRectangleFromSelection() };

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            SetCurrentImage();
        }

        private void SetCurrentImage()
        {
            currentInd++;
            if (currentInd >= _paths.Length)
                currentInd = 0;

            Bitmap bmp = new Bitmap(_paths[currentInd].FullName);
            pbx.Image = bmp;
        }

        private void perviousBtn_Click(object sender, EventArgs e)
        {
            currentInd--;
            if (currentInd < 0)
                currentInd = _paths.Length - 1;
            //if (currentInd < _paths.Length)

            Bitmap bmp = new Bitmap(_paths[currentInd].FullName);
            pbx.Image = bmp;
        }

        private void cropBannerBtn_Click(object sender, EventArgs e)
        {
            PropertyInfo pInfo = pbx.GetType().GetProperty("ImageRectangle",
                                                               System.Reflection.BindingFlags.Public |
                                                               System.Reflection.BindingFlags.NonPublic |
                                                               System.Reflection.BindingFlags.Instance);

            Rectangle rectangle = (Rectangle)pInfo.GetValue(pbx, null);

            var w = (float) rectangle.Width - rectangle.X;
            var h = (float) rectangle.Height;

            RectangleF selection2 = new RectangleF();
            selection2.X = Math.Abs((_selection.X) / w);
            selection2.Y = Math.Abs((_selection.Y - rectangle.Y) / h);
            selection2.Width = Math.Min(1, Math.Abs((_selection.Width + _selection.X - rectangle.X) / w));
            selection2.Height = Math.Min(1, Math.Abs((_selection.Height + _selection.Y - rectangle.Y) / h));

            ResizeResult = new ResizeFormResult { IsCropBorders = true, RectF = selection2 };
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private Rectangle GetRectangleFromSelection(Rectangle? selection = null)
        {
            if (selection == null)
            {
                _selection = new Rectangle((int)left_num.Value,
                                           (int)top_num.Value,
                                           (int)(right_num.Value - left_num.Value),
                                           (int)(bottom_num.Value - top_num.Value));
            }
            else
            {
                _selection = selection.Value;
            }

            PropertyInfo pInfo = pbx.GetType().GetProperty("ImageRectangle",
                                                               System.Reflection.BindingFlags.Public |
                                                               System.Reflection.BindingFlags.NonPublic |
                                                               System.Reflection.BindingFlags.Instance);

            Rectangle rectangle = (Rectangle)pInfo.GetValue(pbx, null);

            var w = (float)pbx.Image.Width / rectangle.Width;
            var h = (float)pbx.Image.Height / rectangle.Height;

            _selection.X = Math.Max((int)((_selection.X - rectangle.X) * w), 0);
            _selection.Y = Math.Max((int)((_selection.Y - rectangle.Y) * h), 0);
            _selection.Height = Math.Min((int)(Math.Min(_selection.Height, pbx.Height - (int)top_num.Value) * h), pbx.Image.Height - _selection.Y);
            _selection.Width = Math.Min((int)(Math.Min(_selection.Width, pbx.Width - (int)left_num.Value) * w), pbx.Image.Width - _selection.X);

            var rect = _selection;
            return rect;
        }
    }
}
