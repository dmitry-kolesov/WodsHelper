using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLinksLoader_Net2
{
    public class LinksListEventArg
    {
        public LinksListEventArg(string[] s, bool isToSave = false) { Links = s; IsToSave = isToSave; }
        public string[] Links { get; private set; } // readonly
        public bool IsToSave { get; private set; } // readonly
    }
}
