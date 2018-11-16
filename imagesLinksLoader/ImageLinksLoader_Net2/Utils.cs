using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageLinksLoader_Net2
{
    class Utils
    {
        public static Utils _instance;
        public static Utils Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Utils();
                return _instance;
            }
        }

        public string GetAndCreateDirectoryPath()
        {
            DateTime now = DateTime.Now;
            string dirPath = @"d:\temp\asteria\" + string.Format("{0}-{1}-{2} {3}-{4}", now.Year, now.Month, now.Day, now.Hour, now.Minute) + "\\";
            System.IO.Directory.CreateDirectory(dirPath);
            return dirPath;
        }
    }
}
