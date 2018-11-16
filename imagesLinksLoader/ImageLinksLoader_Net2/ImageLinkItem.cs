using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ImageLinksLoader_Net2
{
    class ImageLinkItem
    {
        public string Link { get; set; }
        public Bitmap LoadedImage { get; set; }
        public string ImageSize { get; set; }

    }
}
