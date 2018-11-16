using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Windows.Forms;

using mshtml;

namespace ImageLinksLoader_Net2
{
    public partial class LinksListForm : Form
    {
        public delegate void SetLinkListEventHandler(object sender, LinksListEventArg e);
        public event SetLinkListEventHandler SetLinksList;

        public LinksListForm()
        {
            InitializeComponent();
            //selectAll_cbx.CheckedChanged += new EventHandler(selectAll_cbx_CheckedChanged);
            //this.FormClosing += new FormClosingEventHandler(LinksListForm_FormClosing);
        }

        void LinksListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            selectAll_cbx.CheckedChanged -= selectAll_cbx_CheckedChanged;
            this.FormClosing -= LinksListForm_FormClosing;
            //links_listView.SelectedIndexChanged -= links_listView_SelectedIndexChanged;
            links_listView.ItemChecked -= links_listView_ItemChecked;
            links_listView.ItemSelectionChanged -= links_listView_ItemSelectionChanged;
        }

        //public LinksListForm(string[] imagesLinks)
        //    : this()
        //{

        //}

        private void InitControls()
        {

            toFind_tbx.Text = "";
            path_tbx.Text = "";
            replaceTo_tbx.Text = "";
            saveDisk_progressBar.Value = 0;
        }

        internal void InitImagesLinks(string[] imagesLinks)
        {
            InitControls();

            selectAll_cbx.CheckedChanged += new EventHandler(selectAll_cbx_CheckedChanged);
            this.FormClosing += new FormClosingEventHandler(LinksListForm_FormClosing);
            //links_listView.SelectedIndexChanged += new EventHandler(links_listView_SelectedIndexChanged);
            links_listView.ItemChecked += new ItemCheckedEventHandler(links_listView_ItemChecked);
            links_listView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(links_listView_ItemSelectionChanged);
            links_listView.ItemCheck += new ItemCheckEventHandler(links_listView_ItemCheck);

            if (links_listView.Items.Count > 0)
            {
                links_listView.Items.Clear();
            }

            Bitmap image = null;
            int k = 0;
            links_listView.LargeImageList = new ImageList();
            for (int i = 0; i < imagesLinks.Length; i++)
            {
                if (imagesLinks[i] != null)
                {
                    image = null;
                    //TextBox tb = new TextBox();
                    //tb.Text = imagesLinks[i];
                    //ListViewItem lvi = new ListViewItem(imagesLinks[i]);
                    //lvi.Tag = imagesLinks[i];
                    ListViewItem lvi = new ListViewItem(imagesLinks[i]);
                    //lvi.Text = imagesLinks[i];
                    //links_listView.LargeImageList.Images.Add(GetImage(lvi.Text));
                    //image = GetImage(lvi.Text);
                    if (image != null)
                    {
                        links_listView.LargeImageList.Images.Add(image);
                        lvi.ImageIndex = k;
                        k++;
                        //lvi.ImageList.Images.Add(image);
                        lvi.SubItems.Add(image.Size.Width.ToString() + "x" + image.Size.Height.ToString());
                    }
                    links_listView.Items.Add(lvi);
                }
            }
        }

        void links_listView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Unchecked)
            //{
            //    ;
            //    //links_listView.SelectedIndices.Remove(e.Index);
            //}
        }

        void links_listView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //if (e.Item.Checked)
            //{
            //    //links_listView.SelectedIndices.Add(e.Item.Index);
            //}
            //else
            //{
            //    links_listView.SelectedIndices.Remove(e.Item.Index);
            //}

            //for (int i = 0; i < links_listView.CheckedIndices.Count; i++)
            //{
            //    links_listView.SelectedIndices.Add(links_listView.CheckedIndices[i]);
            //}
        }

        void links_listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //if (e.IsSelected) 
            //{
            //e.Item.Checked = e.IsSelected;
            //}
        }

        //void links_listView_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < links_listView.SelectedIndices.Count; i++)
        //    {

        //        links_listView.Items[links_listView.SelectedIndices[i]].Checked = true;
        //    }
        //}

        void selectAll_cbx_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < links_listView.Items.Count; i++)
            {
                links_listView.Items[i].Checked = selectAll_cbx.Checked;
            }
        }

        private void saveLinks_btn_Click(object sender, EventArgs e)
        {
            string[] arrRes = new string[links_listView.CheckedItems.Count];
            for (int i = 0; i < links_listView.CheckedItems.Count; i++)
            {
                arrRes[i] = links_listView.CheckedItems[i].Text;
            }

            if (SetLinksList != null)
                SetLinksList(this, new LinksListEventArg(arrRes));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        void copy_menuItem_Click(object sender, System.EventArgs e)
        {
            if (links_listView.SelectedItems.Count > 0)
                Clipboard.SetText(links_listView.SelectedItems[0].Text);
        }

        private void edit_menuItem_Click(object sender, EventArgs e)
        {
            if (links_listView.SelectedItems.Count > 0)
            {
                links_listView.SelectedItems[0].BeginEdit();
            }
        }

        private void findReplace_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < links_listView.Items.Count; i++)
            {
                links_listView.Items[i].Text = links_listView.Items[i].Text.Replace(toFind_tbx.Text, replaceTo_tbx.Text);
            }
        }

        private void saveToDisk_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string dirPath = Utils.Instance.GetAndCreateDirectoryPath();
                //if ((links_listView.SelectedItems.Count > 0)
                //    && (links_listView.SelectedItems[0].Text.ToLower().Contains("holidaylettings.co.uk")))
                //{
                //    if (SetLinksList != null)
                //    {
                //        var outList = new List<string>();
                //        foreach (ListViewItem str in links_listView.SelectedItems)
                //        {
                //            outList.Add(str.Text);
                //        }

                //        SetLinksList(this, new LinksListEventArg(outList.ToArray(), true));
                //    }
                //    saveDisk_progressBar.Value = saveDisk_progressBar.Maximum;
                //}
                //else
                {
                    saveDisk_progressBar.Maximum = links_listView.CheckedItems.Count;
                    saveDisk_progressBar.Value = 0;

                    path_tbx.Text = "";

                    WebClient wc = new WebClient();
                    string url = "";
                    byte[] bytes;
                    Bitmap bmp;

                    for (int i = 0; i < links_listView.CheckedItems.Count; i++)
                    {
                        try
                        {
                            url = links_listView.CheckedItems[i].Text;
                            if (url.Length < 5)
                                continue;
                            string namePath = i.ToString();
                            if (url.ToLower().Substring(url.Length - 5).Contains(".gif"))
                            {
                                namePath += ".gif";
                            }
                            else
                            {
                                namePath += ".jpg";
                            }
                            namePath = Path.Combine(dirPath, namePath);

                            //if (url.ToLower().Contains("www.holidaylettings.co.uk"))
                            //{
                            //    //wc.DownloadFile(url, namePath);
                            //}
                            //else
                            {
                                //
                                try
                                {
                                    wc.Headers.Add("user-agent", "Only a test!;");
                                    wc.DownloadFile(url, Path.Combine(dirPath, namePath));
                                }
                                catch (Exception ex)
                                {
                                    //wc.Headers.Add("user-agent", "Only a test!");

                                    wc.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";
                                    wc.Headers["Connection"] = "Keep - Alive";
                                    //wc.Headers["Host"] = "www.clubvillamar.ru";
                                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | System.Net.SecurityProtocolType.Tls
                               | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

                                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                                    ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                                    //wc.Encoding = System.Text.Encoding.UTF8;

                                    //var enc = Encoding.GetEncoding(1251);
                                    //var url1 = "http://xn----gtbnaarq0ag5ao9c4c.xn--p1ai/" +
                                    //          System.Web.HttpUtility.UrlEncode(url);

                                    //wc.DownloadFile(url, Path.Combine(dirPath, namePath));

                                    //var cookie = new Cookie("test_cookie", "test_value", "/", ".xn----7sbcca6bi0ak9b0a6f.xn--p1ai");
                                    //var container = new CookieContainer().Add(cookie);

                                    bytes = wc.DownloadData(url);
                                    //var image = Image.FromStream(new MemoryStream(bytes), false);
                                    //if (image != null)
                                    //    image.Save(Path.Combine(dirPath, namePath));

                                    bmp = new Bitmap(new MemoryStream(bytes), false);
                                    System.Threading.Thread.Sleep(20);
                                    if //(
                                            (bmp != null)
                                    //&&(bmp.Size.Width >= 50)
                                    //&& (bmp.Size.Height >= 50))
                                    {
                                        //string namePath = img.nameProp.ToLower().Replace(".jpg", "") + ".jpg";
                                        bmp.Save(Path.Combine(dirPath, namePath.Replace(".jpg", "-1.jpg")));//, bmp.RawFormat
                                    }
                                }

                            }


                            saveDisk_progressBar.Value = i + 1;
                        }
                        catch (Exception ex)
                        {
                            var res = MessageBox.Show("Do you want to continue? Cant save to disk: " + Environment.NewLine + url + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace,
                                                    "Warning", MessageBoxButtons.YesNo);
                            if (res == System.Windows.Forms.DialogResult.No)
                                break;
                        }
                    }
                }
                path_tbx.Text = dirPath;
                path_tbx.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant save to disk: " + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        void duplicate_menuItem_Click(object sender, System.EventArgs e)
        {
            SimpleInput si = new SimpleInput();
            if (si.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (links_listView.SelectedItems.Count > 0)
                {
                    var url = links_listView.SelectedItems[0].Text;
                    var parts = url.Split('.');
                    if (parts.Length > 0)
                    {
                        var prefixInd = url.LastIndexOf('/');
                        string prefix = url.Substring(0, prefixInd);
                        for (int i = 1; i < si.Count + 1; i++)
                        {
                            var newItemText = prefix + "/" + i.ToString("d2") + "." + parts[parts.Length - 1];
                            bool toAdd = true;
                            foreach (ListViewItem item in links_listView.Items)
                                if (item.Text == newItemText)
                                    toAdd = false;
                            if (toAdd)
                                links_listView.Items.Add(new ListViewItem(newItemText));
                        }
                    }
                }
            }
        }

        private void reverse_btn_Click(object sender, EventArgs e)
        {
            if (links_listView.SelectedItems.Count > 0)
            {
                var selList = links_listView.CheckedItems;
                int start = links_listView.CheckedItems[0].Index;
                int end = links_listView.CheckedItems[links_listView.CheckedItems.Count - 1].Index;
                int i = 0;
                foreach (ListViewItem item in links_listView.CheckedItems)
                {
                    links_listView.Items.Remove(item);
                    links_listView.Items.Insert(end - i, item);
                    i++;
                }
            }
        }

        private void saveAndCrop_btn_Click(object sender, EventArgs e)
        {
            saveToDisk_btn_Click(null, null);
            if (!string.IsNullOrEmpty(path_tbx.Text))
            {
                DirectoryInfo dir = new DirectoryInfo(path_tbx.Text);
                var files = dir.GetFiles("*.jpg");
                if (files.Length > 0)
                {
                    var cropForm = new CropImageForm(files);
                    if ((cropForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        && (cropForm.ResizeResult.Rect != null))
                    {
                        var resizeResult = cropForm.ResizeResult;
                        if (!cropForm.ResizeResult.IsCropBorders)
                        {
                            var rect = cropForm.ResizeResult.Rect;
                            //new Rectangle(point, size);
                            //var formRect = cropForm.Rect;
                            //var size = cropForm.Rect.Size;//new Size(Math.Abs(cropForm.Points[1].X - cropForm.Points[0].X), Math.Abs(cropForm.Points[1].Y - cropForm.Points[0].Y));
                            //var point = new Point(cropForm.Rect)//new Point(Math.Min(cropForm.Points[1].X, cropForm.Points[0].X), Math.Min(cropForm.Points[1].Y, cropForm.Points[0].Y));

                            var dir2 = Directory.CreateDirectory(Path.Combine(files[0].DirectoryName, "Cropped"));
                            foreach (var fi in files)
                            {
                                Bitmap bmpImage = new Bitmap(fi.FullName);
                                if ((bmpImage.Size.Width >= rect.Size.Width)
                                    && (bmpImage.Size.Height >= rect.Size.Height))
                                {
                                    Bitmap bmpCrop = bmpImage.Clone(rect, bmpImage.PixelFormat);
                                    var myImageCodecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(o => o.MimeType.Equals("image/jpeg"));
                                    var myEncoder = System.Drawing.Imaging.Encoder.Quality;
                                    var myEncoderParameter = new EncoderParameter(myEncoder, 90L);

                                    var myEncoderParameters = new EncoderParameters(1);
                                    myEncoderParameters.Param[0] = myEncoderParameter;

                                    bmpCrop.Save(Path.Combine(dir2.FullName, "Cropped - " + fi.Name), myImageCodecInfo, myEncoderParameters);
                                }
                            }

                            if (resizeResult.IsByPercintage != null)
                            {
                                ImageConverter.ResizeAllFilesInDirectory(files[0].DirectoryName, "Cropped", "CroppedResized", resizeResult);
                            }
                        }
                        else
                        {
                            var bordersRect = cropForm.ResizeResult.RectF;
                            var dir2 = Directory.CreateDirectory(Path.Combine(files[0].DirectoryName, "CroppedBorders"));
                            foreach (var fi in files)
                            {
                                Bitmap bmpImage = new Bitmap(fi.FullName);
                                var rect = new Rectangle((int)(bordersRect.X * bmpImage.Width),
                                                            (int)(bordersRect.Y * bmpImage.Height),
                                                            (int)(bmpImage.Width * bordersRect.Width),
                                                            (int)(bmpImage.Height * bordersRect.Height));

                                rect = new Rectangle(rect.X, rect.Y, rect.Width - rect.X, rect.Height - rect.Y);
                                if (rect.Size.Width < 0 || rect.Size.Height < 0)
                                {
                                    continue;
                                }

                                if ((bmpImage.Size.Width >= rect.Size.Width)
                                    && (bmpImage.Size.Height >= rect.Size.Height))
                                {
                                    Bitmap bmpCrop = bmpImage.Clone(rect, bmpImage.PixelFormat);
                                    var myImageCodecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(o => o.MimeType.Equals("image/jpeg"));
                                    var myEncoder = System.Drawing.Imaging.Encoder.Quality;
                                    var myEncoderParameter = new EncoderParameter(myEncoder, 90L);

                                    var myEncoderParameters = new EncoderParameters(1);
                                    myEncoderParameters.Param[0] = myEncoderParameter;

                                    bmpCrop.Save(Path.Combine(dir2.FullName, "Cropped - " + fi.Name), myImageCodecInfo, myEncoderParameters);
                                }
                            }
                        }
                    }
                }
            }
        }
        
        private void byPersintageRbtn_CheckedChanged(object sender, EventArgs e)
        {
            newSizeNumeric.Maximum = 100;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            newSizeNumeric.Maximum = 1500;
        }

        private void resizeAndSaveLinks_btn_Click(object sender, EventArgs e)
        {
            saveToDisk_btn_Click(null, null);
            if (!string.IsNullOrEmpty(path_tbx.Text))
            {
                DirectoryInfo dir = new DirectoryInfo(path_tbx.Text);
                var files = dir.GetFiles("*.jpg");
                if (files.Length > 0)
                {
                    var dir2 = Directory.CreateDirectory(Path.Combine(files[0].DirectoryName, "Resized"));
                    foreach (var fi in files)
                    {
                        try
                        {
                            Bitmap bmpImage = new Bitmap(fi.FullName);

                            var oldWidth = bmpImage.Width;
                            var oldHeight = bmpImage.Height;

                            var newWidth = oldWidth;
                            var newHeight = oldHeight;
                            if (byPersintageRbtn.Checked)
                            {
                                newWidth = (int)(oldWidth * newSizeNumeric.Value / 100);
                                newHeight = (int)(oldHeight * newSizeNumeric.Value / 100);
                            }
                            else if (newWidthBtn.Checked)
                            {
                                newWidth = (int)newSizeNumeric.Value;
                                newHeight = (int)(newSizeNumeric.Value * ((decimal)oldHeight / oldWidth));
                            }

                            var resizedImage = ImageConverter.ResizeImage(bmpImage, newWidth, newHeight);
                            ImageConverter.SaveImage(resizedImage, fi, dir2);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
        }


        //private Bitmap GetImage(string url)
        //{
        //    IHTMLDocument2 doc = (IHTMLDocument2)webBrowser1.Document.DomDocument;
        //    IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)doc.body).createControlRange();

        //    foreach (IHTMLImgElement img in doc.images)
        //    {
        //        imgRange.add((IHTMLControlElement)img);

        //        imgRange.execCommand("Copy", false, null);

        //        using (Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
        //        {
        //            return bmp;//bmp.Save(@"C:\" + img.nameProp);
        //        }
        //    }
        //    return null;
        //    //WebClient wc = new WebClient();
        //    //byte[] bytes = wc.DownloadData(url);
        //    //Bitmap b = new Bitmap(new MemoryStream(bytes));
        //    //return b;
        //}

    }

}
