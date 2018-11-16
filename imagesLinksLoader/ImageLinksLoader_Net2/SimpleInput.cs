using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageLinksLoader_Net2
{
    public partial class SimpleInput : Form
    {
        public int Count { get { return Convert.ToInt32(this.numericUpDown1.Value); } }
        public SimpleInput()
        {
            InitializeComponent();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
