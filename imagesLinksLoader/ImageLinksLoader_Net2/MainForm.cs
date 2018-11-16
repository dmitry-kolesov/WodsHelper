using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

//using WebKit;
//using Gecko;

using mshtml;

namespace ImageLinksLoader_Net2
{
    public partial class MainForm : Form
    {
        // admin part
        // <input name="newphoto_url" type="text" id="newphoto_url" size="50">
        // <input name="save_rent" type="submit" value="Сохранить"/>
        //<input name="save_rent" type="submit" value="Сохранить"/>

        LinksListForm linksForm = new LinksListForm();

        public MainForm()
        {
            // Xpcom.Initialize(@"C:\Program Files (x86)\Mozilla Firefox");

            InitializeComponent();

            tabControl1.TabPages.RemoveAt(1);

            //villa_wbr2.Enabled = false;
            //Xpcom.Initialize(@"C:\Program Files (x86)\Mozilla Firefox");
            //WebBrowserNavigate(admin_wbr, adminPage_tb.Text);
            WebBrowserNavigate(villa_wbr, villaPage_tb.Text);
            //WebBrowserNavigate(villa_wbr2, villaPage_tb.Text);

            //admin_wbr.ScriptErrorsSuppressed = true;
            //admin_wbr.ProgressChanged += new WebBrowserProgressChangedEventHandler(admin_wbr_ProgressChanged);
            //admin_wbr.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(admin_wbr_DocumentCompleted);
            villa_wbr.AllowNavigation = true;
            villa_wbr.ScriptErrorsSuppressed = true;
            villa_wbr.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(villa_wbr_DocumentCompleted);
            villa_wbr.ProgressChanged += new WebBrowserProgressChangedEventHandler(villa_wbr_ProgressChanged);

            //villa_wbr2.DocumentCompleted += villa_wbr2_DocumentCompleted;
            //villa_wbr2.ProgressChanged += villa_wbr2_ProgressChanged;
            linksForm.SetLinksList += new LinksListForm.SetLinkListEventHandler(linksForm_SetLinksList);
        }

        //void villa_wbr2_ProgressChanged(object sender, GeckoProgressEventArgs e)
        //{
        //    villasImages_progressBar.Maximum = Math.Max((int)e.MaximumProgress, (int)e.CurrentProgress);
        //    villasImages_progressBar.Value = (int)e.CurrentProgress;
        //}

        void villa_wbr2_DocumentCompleted(object sender, EventArgs e)
        {
            ParseImagesLinks();
        }

        void villa_wbr_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            villasImages_progressBar.Maximum = Math.Max((int)e.MaximumProgress, (int)e.CurrentProgress);
            villasImages_progressBar.Value = (int)((e.CurrentProgress > 0) ? e.CurrentProgress : 0);
        }

        void admin_wbr_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //admin_progressBar.Maximum = (int)e.MaximumProgress;
            //admin_progressBar.Value = (int)e.CurrentProgress;

            //if (admin_wbr.Document.GetElementById("newphoto_url") != null)
            //    syncFlag = true;
        }

        void villa_wbr_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ParseImagesLinks();
        }

        bool syncFlag;
        //void admin_wbr_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    if (admin_wbr.Document.GetElementById("newphoto_url") != null)
        //        syncFlag = true;
        //    if ((admin_wbr.Document.GetElementById("login") != null)
        //        && (admin_wbr.Document.GetElementById("password") != null)
        //        && (admin_wbr.Document.GetElementById("submit") != null))
        //        login_btn_Click(null, null);
        //}

        private void WebBrowserNavigate(WebBrowser wb, string url)
        {
            wb.Navigate(url);
        }
        //private void WebBrowserNavigate(WebKitBrowser wb, string url)
        //{
        //    wb.Navigate(url);
        //}
        //private void WebBrowserNavigate(Gecko.GeckoWebBrowser wb, string url)
        //{
        //    wb.Navigate(url);
        //}

        //private void loadAdminPage_btn_Click(object sender, EventArgs e)
        //{
        //    WebBrowserNavigate(admin_wbr, adminPage_tb.Text);
        //}

        private void loadImagesPage_btn_Click(object sender, EventArgs e)
        {
            imagesLinks.Clear();
            WebBrowserNavigate(villa_wbr, villaPage_tb.Text);
            //WebBrowserNavigate(villa_wbr2, villaPage_tb.Text);
        }

        List<string> imagesLinks = new List<string>();
        string[] imagesLinksToLoad;
        private void parseImagesLinks_btn_Click(object sender, EventArgs e)
        {
            ParseImagesLinks();
        }


        private void ParseImagesLinks()
        {
            //int k = 0;
            //imagesLinks.Clear();
            if (villa_wbr.Document != null)
            {
                var fromText = txtBxFrom.Text;
                var toText = txtBxTo.Text;
                AddFromCollection(villa_wbr.Document.Images, fromText, toText);
                AddFromCollection(villa_wbr.Document.Links, fromText, toText, new List<string>() { ".jpg", ".png" });
                AddFromCollection(villa_wbr.Document.GetElementsByTagName("div"), fromText, toText, new List<string>() { ".jpg", ".png" });
                AddFromCollection(villa_wbr.Document.GetElementsByTagName("span"), fromText, toText, new List<string>() { ".jpg", ".png" });

            }
            //if (villa_wbr2.Document != null)
            //{
            //    AddFromCollection(villa_wbr2.Document.Images);
            //    AddFromCollection(villa_wbr2.Document.Links, new List<string>() { ".jpg", ".png" });
            //}
            ; ;
            //for (int i = 0; i < villa_wbr.Document.Images.Count; i++)
            //{
            //    string link = villa_wbr.Document.Images[i].GetAttribute("src");
            //    if ((link != null)
            //        && (!imagesLinks.Contains(link)))
            //    {
            //        imagesLinks.Add(link);
            //    }
            //}

            //for (int i = 0; i < villa_wbr.Document.Links.Count; i++)
            //{
            //    string link = villa_wbr.Document.Links[i].GetAttribute("href");
            //    if (link != null)
            //    {
            //        if (link.Contains(".jpg") || (link.Contains(".png")))
            //        {
            //            imagesLinks.Add(link);
            //            //imagesLinks[k] = link;
            //            //k++;
            //        }
            //    }
            //}

            //GetImages();
        }

        bool IsAbsoluteUrl(string url)
        {
            Uri result;
            return Uri.TryCreate(url, UriKind.Absolute, out result);
        }

        //private void AddFromCollection(GeckoElementCollection links, List<string> extraConditions = null)
        //{
        //    if (links == null) return;
        //    for (int i = 0; i < links.Length; i++)
        //    {
        //        string link = links[i].GetAttribute("href");
        //        string link2 = links[i].GetAttribute("src");
        //        link = (link == null) ? link2 : link;
        //        if (!IsAbsoluteUrl(link))
        //        {
        //            Uri baseUri = new Uri(villa_wbr2.Url.Scheme + "://" + villa_wbr2.Url.Host);
        //            Uri myUri = new Uri(baseUri, link);
        //            link = myUri.ToString();
        //        }
        //        if (link != null)
        //        {
        //            bool isExtraCondition = false;
        //            if ((extraConditions != null)
        //                && (extraConditions.Count > 0))
        //            {
        //                foreach (var condition in extraConditions)
        //                {
        //                    isExtraCondition |= link.Contains(condition);
        //                    if (isExtraCondition)
        //                        break;
        //                }
        //            }


        //            if (((isExtraCondition) || extraConditions == null)
        //                && (!imagesLinks.Contains(link)))
        //            {
        //                imagesLinks.Add(link);
        //                //imagesLinks[k] = link;
        //                //k++;
        //            }
        //        }
        //    }
        //}
        private void AddFromCollection(HtmlElementCollection links,
                                        string fromText,
                                        string toText,
                                        List<string> extraConditions = null)
        {
            if (links == null) return;
            for (int i = 0; i < links.Count; i++)
            {
                var link = links[i].GetAttribute("href");
                GatherLink(link, extraConditions);

                link = links[i].GetAttribute("data-src");
                GatherLink(link, extraConditions);

                if (!string.IsNullOrEmpty(fromText))
                {
                    var preLink = links[i].OuterHtml;
                    if (!string.IsNullOrEmpty(preLink))
                    {
                        var fromIndex = preLink.IndexOf(fromText);
                        var toIndex = preLink.IndexOf(toText);
                        if (toIndex <= 0)
                        {
                            toIndex = preLink.Length;
                        }

                        if (fromIndex >= 0 && toIndex >= 0)
                        {
                            link = preLink.Substring(fromIndex, toIndex - fromIndex).Replace(fromText, "");
                            GatherLink(link, extraConditions);
                        }
                    }
                }
            }
        }

        private void GatherLink(string link, List<string> extraConditions = null)
        {
            if (!string.IsNullOrEmpty(link))
            {
                bool isExtraCondition = false;
                if ((extraConditions != null)
                    && (extraConditions.Count > 0))
                {
                    foreach (var condition in extraConditions)
                    {
                        isExtraCondition |= link.Contains(condition);
                        if (isExtraCondition)
                            break;
                    }
                }


                if (((isExtraCondition) || extraConditions == null)
                    && (!imagesLinks.Contains(link)))
                {
                    imagesLinks.Add(link);
                    //imagesLinks[k] = link;
                    //k++;
                }
            }
        }

        List<string> imagesLinksToSelectList = new List<string>();
        private void selectLinks_btn_Click(object sender, EventArgs e)
        {
            ParseImagesLinks();
            isFolder = false;
            imagesLinksToSelectList.Clear();
            for (int i = 0; i < imagesLinks.Count; i++)
            {
                if (imagesLinks[i] != null)
                {
                    if (((jpg_cbx.Checked)
                            && (imagesLinks[i].ToLower().Contains(".jpg")))

                        || ((gif_cbx.Checked)
                            && (imagesLinks[i].ToLower().Contains(".gif")))

                        || (any_cbx.Checked))
                    {
                        imagesLinksToSelectList.Add(imagesLinks[i]);
                    }
                }
            }
            //linksForm = new LinksListForm();
            linksForm.InitImagesLinks(imagesLinksToSelectList.ToArray());
            if (linksForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ;
            }
        }

        void linksForm_SetLinksList(object sender, LinksListEventArg e)
        {
            imagesLinksToLoad = e.Links;
            if (e.IsToSave)
                GetImages();
        }


        private void WaitLoadingAdminPage()
        {
            int k = 0;
            Thread.Sleep(500);
            while ((!syncFlag)
                && (k < 20))
            // && (admin_wbr.Document.GetElementById("newphoto_url") == null))
            {
                Application.DoEvents();
                Thread.Sleep(500);
                k++;
            }
        }

        //private void WaitRefreshAdminPage()
        //{
        //    int k = 0;
        //    while ((admin_wbr.IsBusy) && (k < 100))
        //    {
        //        Application.DoEvents();
        //        Thread.Sleep(500);
        //        k++;
        //    }
        //}

        object locker = new object();
        //private void pasteLinksToAdmin_Click(object sender, EventArgs e)
        //{
        //    lock (locker)
        //    {
        //        syncFlag = true;
        //        Thread.Sleep(1000);

        //        //admin_wbr.Navigate(admin_wbr.Url);
        //        syncFlag = false;
        //        WaitLoadingAdminPage();

        //        string elementName = "newphoto_url";
        //        if (!isFolder)
        //        {
        //            var el1 = admin_wbr.Document.GetElementById("url");
        //            el1.SetAttribute("checked", "checked");//
        //            el1.SetAttribute("value", "url");//
        //            el1.RaiseEvent("onclick");
        //            el1.InvokeMember("onclick");
        //            el1.InvokeMember("click");
        //            object obj1 = el1.DomElement;
        //            System.Reflection.MethodInfo mi1 = obj1.GetType().GetMethod("click");
        //            mi1.Invoke(obj1, new object[0]);

        //            villasImages_progressBar.Value = 0;
        //            villasImages_progressBar.Maximum = imagesLinksToLoad.Length;
        //            for (int i = 0; i < imagesLinksToLoad.Length; i++)
        //            {
        //                var txtEl = admin_wbr.Document.GetElementById(elementName);
        //                if (txtEl != null)
        //                {
        //                    admin_wbr.Document.GetElementById(elementName).SetAttribute("value", imagesLinksToLoad[i]);

        //                    var el = admin_wbr.Document.GetElementById("save_form");
        //                    if (admin_wbr.Document.GetElementsByTagName("input").GetElementsByName("save_form").Count > 1)
        //                        el = admin_wbr.Document.GetElementsByTagName("input").GetElementsByName("save_form")[1];
        //                    else if (admin_wbr.Document.GetElementsByTagName("input").GetElementsByName("save_form").Count > 0)
        //                        el = admin_wbr.Document.GetElementsByTagName("input").GetElementsByName("save_form")[0];
        //                    if (el != null)
        //                    {
        //                        //var el = admin_wbr.Document.GetElementsByTagName("input").GetElementsByName("save_form")[1];

        //                        syncFlag = false;
        //                        mshtml.HTMLInputElement el2 = (mshtml.HTMLInputElement)el.DomElement;
        //                        el2.click();

        //                        el.RaiseEvent("onclick");
        //                        //WaitLoadingAdminPage();
        //                        //el.click();
        //                        el.InvokeMember("click");
        //                        //WaitLoadingAdminPage();
        //                        el.InvokeMember("onclick");
        //                        //WaitLoadingAdminPage();

        //                        object obj = el.DomElement;
        //                        System.Reflection.MethodInfo mi = obj.GetType().GetMethod("click");
        //                        mi.Invoke(obj, new object[0]);

        //                        //admin_wbr.InvokeScript("check_on_submit('form_part3');");

        //                        WaitLoadingAdminPage();

        //                        if (villasImages_progressBar.Value < villasImages_progressBar.Maximum)
        //                            villasImages_progressBar.Value++;
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            admin_wbr.Document.GetElementById("local").SetAttribute("checked", "checked");//
        //            elementName = "newphoto";
        //            villasImages_progressBar.Value = 0;
        //            villasImages_progressBar.Maximum = imagesLinksToLoad.Length;
        //            for (int i = 0; i < imagesLinksToLoad.Length; i++)
        //            {
        //                HTMLInputElement file1 = (HTMLInputElement)((HTMLDocument)admin_wbr.Document.DomDocument).all.item(elementName, 0);//.SetAttribute("value", imagesLinksToLoad[i]);
        //                file1.select();

        //                SendKeys.Send("{TAB}");   //Navigate to the Browse button
        //                SendKeys.Send(" ");       //Click on the browse button

        //                Thread.Sleep(50);
        //                SendKeys.Send(imagesLinksToLoad[i]);         //File Path
        //                SendKeys.Send("{TAB}");
        //                SendKeys.Send("{ENTER}");

        //                Thread.Sleep(50);
        //                var el = admin_wbr.Document.GetElementById("save_rent");

        //                syncFlag = false;
        //                mshtml.HTMLInputElement el2 = (mshtml.HTMLInputElement)el.DomElement;
        //                el2.click();

        //                while (!syncFlag)
        //                {
        //                    Application.DoEvents();
        //                    Thread.Sleep(500);
        //                }
        //                villasImages_progressBar.Value++;
        //            }
        //        }
        //    }
        //}

        bool isFolder = false;
        private void selectFromFolder_btn_Click(object sender, EventArgs e)
        {
            isFolder = true;
            if (selectFolder_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagesLinksToSelectList.Clear();
                DirectoryInfo di = new DirectoryInfo(selectFolder_dialog.SelectedPath);
                foreach (FileInfo fi in di.GetFiles())
                {
                    imagesLinksToSelectList.Add(fi.FullName);
                }

                linksForm.InitImagesLinks(imagesLinksToSelectList.ToArray());
                if (linksForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ;
                }
            }

        }

        private void GetImages()
        {
            string dirPath = Utils.Instance.GetAndCreateDirectoryPath();
            path_tbx.Text = "";
            IHTMLDocument2 doc = (IHTMLDocument2)villa_wbr.Document.DomDocument;
            IHTMLControlRange imgRange = (IHTMLControlRange)((HTMLBody)doc.body).createControlRange();

            int k = 0;
            foreach (IHTMLImgElement img in doc.images)
            {
                imgRange.add((IHTMLControlElement)img);

                imgRange.execCommand("Copy", false, null);

                using (Bitmap bmp = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
                {
                    if ((bmp != null)
                        && (bmp.Size.Width >= 100)
                        && (bmp.Size.Height >= 100))
                    {
                        string namePath = k.ToString() + ".jpg";
                        if (img.nameProp.ToLower().Substring(img.nameProp.Length - 5).Contains(".gif"))
                            namePath = k.ToString() + ".gif";
                        //string namePath = img.nameProp.ToLower().Replace(".jpg", "") + ".jpg";
                        bmp.Save(Path.Combine(dirPath, namePath));
                        k++;
                    }
                    //return bmp;//bmp.Save(@"C:\" + img.nameProp);
                }
            }
            path_tbx.Text = dirPath;
            path_tbx.SelectAll();

            //WebClient wc = new WebClient();
            //byte[] bytes = wc.DownloadData(url);
            //Bitmap b = new Bitmap(new MemoryStream(bytes));
            //return b;
        }

        private void saveToDisk_btn_Click(object sender, EventArgs e)
        {
            GetImages();
        }

        //private void login_btn_Click(object sender, EventArgs e)
        //{
        //    if ((sender == null)
        //        || ((admin_wbr.Document.GetElementById("login") != null)
        //            && (admin_wbr.Document.GetElementById("password") != null)
        //            && (admin_wbr.Document.GetElementById("submit") != null)))
        //    {
        //        admin_wbr.Document.GetElementById("login").SetAttribute("value", login_tbx.Text);
        //        admin_wbr.Document.GetElementById("password").SetAttribute("value", password_tbx.Text);
        //        var el = admin_wbr.Document.GetElementById("submit");
        //        mshtml.HTMLInputElement el2 = (mshtml.HTMLInputElement)el.DomElement;
        //        el2.click();
        //    }
        //}

        int cntClicked = 0;
        Thread newThread;
        private void autoNextBtn_Click(object sender, EventArgs e)
        {
            cntClicked++;
            //"<div class="bsp_go_pnext" onclick="javascript:handleNav(2);"></div>"
            //var next = villa_wbr.Document.GetElementById("bsp_go_pnext");
            //if (next != null)
            //{
            //    next.InvokeMember("Click");
            //}

            //if (newThread == null)
            //    newThread = new Thread(new ThreadStart(AutoClicker));

            //if (cntClicked % 2 == 1)
            //    newThread.Start();
            //else
            //    newThread.Suspend();

            while (cntClicked % 2 == 1)
            {
                villa_wbr.Document.InvokeScript("handleNav", new object[] { 2 });
                Application.DoEvents();
                Thread.Sleep(100);
                ParseImagesLinks();
                Thread.Sleep(500);
            }
        }

        private void AutoClicker()
        {
            while (cntClicked % 2 == 1)
            {
                villa_wbr.Document.InvokeScript("handleNav", new object[] { 2 });
                Thread.Sleep(100);
            }
        }
        private void execThreadSafeMethod(WebBrowser ctrl)
        {
            MethodInvoker method = (MethodInvoker)delegate
            {
                ctrl.Document.InvokeScript("handleNav", new object[] { 2 });
            };
            if (ctrl.InvokeRequired == true)
            {
                ctrl.Invoke(method);
            }
            {
                method.Invoke();
            }
        }
    }
}
