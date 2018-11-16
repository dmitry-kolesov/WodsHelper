using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace ImageLinksLoader_Net2
{
    class ImageConverter
    {
        public static Bitmap ResizeImage(Bitmap img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.DrawImage(img, 0, 0, width, height);
            }

            return b;
        }

        public static void SaveImage(Bitmap bmpChanged, FileInfo fi, DirectoryInfo dir2)
        {
            var myImageCodecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(o => o.MimeType.Equals("image/jpeg"));
            var myEncoder = System.Drawing.Imaging.Encoder.Quality;
            var myEncoderParameter = new EncoderParameter(myEncoder, 90L);

            var myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = myEncoderParameter;

            bmpChanged.Save(Path.Combine(dir2.FullName, fi.Name), myImageCodecInfo, myEncoderParameters);
        }

        public static void ResizeAllFilesInDirectory(string path, 
                                                        string folderSource, 
                                                        string folderDestinition,
                                                        ResizeFormResult resizeResult)
        {
            var sourceDirPath = Path.Combine(path, folderSource);
            DirectoryInfo dir = new DirectoryInfo(sourceDirPath);
            var files = dir.GetFiles("*.jpg");
            if (files.Length > 0)
            {
                var dirSource = Directory.CreateDirectory(sourceDirPath);
                var dirDestinition = Directory.CreateDirectory(Path.Combine(path, folderDestinition));
                foreach (var fi in files)
                {
                    try
                    {
                        Bitmap bmpImage = new Bitmap(fi.FullName);

                        var oldWidth = bmpImage.Width;
                        var oldHeight = bmpImage.Height;

                        var newWidth = oldWidth;
                        var newHeight = oldHeight;
                        if (resizeResult.IsByPercintage != null)
                        {
                            if (resizeResult.IsByPercintage ?? false)
                            {
                                newWidth = (int)(oldWidth * resizeResult.Size / 100);
                                newHeight = (int)(oldHeight * resizeResult.Size / 100);
                            }
                            else
                            {
                                newWidth = (int)resizeResult.Size;
                                newHeight = (int)(resizeResult.Size * ((decimal)oldHeight / oldWidth));
                            }
                        }

                        var resizedImage = ImageConverter.ResizeImage(bmpImage, newWidth, newHeight);
                        ImageConverter.SaveImage(resizedImage, fi, dirDestinition);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
    }
}
