using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLinksLoader_Net2
{
    public partial class ResizeControl : UserControl
    {
        public ResizeControl()
        {
            InitializeComponent();
        }

        public ResizeFormResult GetResizeFormResult()
        {
            var isNullable = !byPersintageRbtn.Checked && !newWidthBtn.Checked;
            return new ResizeFormResult { IsByPercintage = (isNullable) ? null : (bool?)(byPersintageRbtn.Checked && !newWidthBtn.Checked), Size = (int)newSizeNumeric.Value };
        }

        private void newWidthBtn_CheckedChanged(object sender, EventArgs e)
        {
            newSizeNumeric.Maximum = 1500;
        }

        private void byPersintageRbtn_CheckedChanged(object sender, EventArgs e)
        {
            newSizeNumeric.Maximum = 100;
        }
    }
}
