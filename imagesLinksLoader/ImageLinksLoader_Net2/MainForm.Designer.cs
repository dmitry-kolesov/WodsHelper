namespace ImageLinksLoader_Net2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.villa_wbr = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxTo = new System.Windows.Forms.TextBox();
            this.txtBxFrom = new System.Windows.Forms.TextBox();
            this.autoNextBtn = new System.Windows.Forms.Button();
            this.path_tbx = new System.Windows.Forms.TextBox();
            this.saveToDisk_btn = new System.Windows.Forms.Button();
            this.selectFromFolder_btn = new System.Windows.Forms.Button();
            this.villasImages_progressBar = new System.Windows.Forms.ProgressBar();
            this.villaPage_tb = new System.Windows.Forms.TextBox();
            this.any_cbx = new System.Windows.Forms.CheckBox();
            this.pasteLinksToAdmin_btn = new System.Windows.Forms.Button();
            this.villaPage_btn = new System.Windows.Forms.Button();
            this.selectLinks_btn = new System.Windows.Forms.Button();
            this.jpg_cbx = new System.Windows.Forms.CheckBox();
            this.gif_cbx = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1354, 551);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.villa_wbr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1346, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Villa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // villa_wbr
            // 
            this.villa_wbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.villa_wbr.Location = new System.Drawing.Point(3, 3);
            this.villa_wbr.MinimumSize = new System.Drawing.Size(20, 20);
            this.villa_wbr.Name = "villa_wbr";
            this.villa_wbr.Size = new System.Drawing.Size(1340, 519);
            this.villa_wbr.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1346, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Villa3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBxTo);
            this.splitContainer1.Panel1.Controls.Add(this.txtBxFrom);
            this.splitContainer1.Panel1.Controls.Add(this.autoNextBtn);
            this.splitContainer1.Panel1.Controls.Add(this.path_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.saveToDisk_btn);
            this.splitContainer1.Panel1.Controls.Add(this.selectFromFolder_btn);
            this.splitContainer1.Panel1.Controls.Add(this.villasImages_progressBar);
            this.splitContainer1.Panel1.Controls.Add(this.villaPage_tb);
            this.splitContainer1.Panel1.Controls.Add(this.any_cbx);
            this.splitContainer1.Panel1.Controls.Add(this.pasteLinksToAdmin_btn);
            this.splitContainer1.Panel1.Controls.Add(this.villaPage_btn);
            this.splitContainer1.Panel1.Controls.Add(this.selectLinks_btn);
            this.splitContainer1.Panel1.Controls.Add(this.jpg_cbx);
            this.splitContainer1.Panel1.Controls.Add(this.gif_cbx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 687);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "from-to tags/text";
            // 
            // txtBxTo
            // 
            this.txtBxTo.Location = new System.Drawing.Point(730, 79);
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(100, 20);
            this.txtBxTo.TabIndex = 26;
            // 
            // txtBxFrom
            // 
            this.txtBxFrom.Location = new System.Drawing.Point(624, 80);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.Size = new System.Drawing.Size(100, 20);
            this.txtBxFrom.TabIndex = 25;
            // 
            // autoNextBtn
            // 
            this.autoNextBtn.Location = new System.Drawing.Point(477, 72);
            this.autoNextBtn.Name = "autoNextBtn";
            this.autoNextBtn.Size = new System.Drawing.Size(141, 32);
            this.autoNextBtn.TabIndex = 24;
            this.autoNextBtn.Text = "Auto Next Click";
            this.autoNextBtn.UseVisualStyleBackColor = true;
            this.autoNextBtn.Click += new System.EventHandler(this.autoNextBtn_Click);
            // 
            // path_tbx
            // 
            this.path_tbx.Location = new System.Drawing.Point(302, 110);
            this.path_tbx.Name = "path_tbx";
            this.path_tbx.ReadOnly = true;
            this.path_tbx.Size = new System.Drawing.Size(169, 20);
            this.path_tbx.TabIndex = 23;
            // 
            // saveToDisk_btn
            // 
            this.saveToDisk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveToDisk_btn.Location = new System.Drawing.Point(362, 75);
            this.saveToDisk_btn.Name = "saveToDisk_btn";
            this.saveToDisk_btn.Size = new System.Drawing.Size(109, 29);
            this.saveToDisk_btn.TabIndex = 22;
            this.saveToDisk_btn.Text = "Save to disk";
            this.saveToDisk_btn.UseVisualStyleBackColor = true;
            this.saveToDisk_btn.Click += new System.EventHandler(this.saveToDisk_btn_Click);
            // 
            // selectFromFolder_btn
            // 
            this.selectFromFolder_btn.Enabled = false;
            this.selectFromFolder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectFromFolder_btn.Location = new System.Drawing.Point(477, 40);
            this.selectFromFolder_btn.Name = "selectFromFolder_btn";
            this.selectFromFolder_btn.Size = new System.Drawing.Size(139, 29);
            this.selectFromFolder_btn.TabIndex = 21;
            this.selectFromFolder_btn.Text = "Select from folder";
            this.selectFromFolder_btn.UseVisualStyleBackColor = true;
            this.selectFromFolder_btn.Visible = false;
            // 
            // villasImages_progressBar
            // 
            this.villasImages_progressBar.Location = new System.Drawing.Point(0, 72);
            this.villasImages_progressBar.Name = "villasImages_progressBar";
            this.villasImages_progressBar.Size = new System.Drawing.Size(240, 23);
            this.villasImages_progressBar.TabIndex = 20;
            // 
            // villaPage_tb
            // 
            this.villaPage_tb.Dock = System.Windows.Forms.DockStyle.Top;
            this.villaPage_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.villaPage_tb.Location = new System.Drawing.Point(0, 0);
            this.villaPage_tb.Name = "villaPage_tb";
            this.villaPage_tb.Size = new System.Drawing.Size(1354, 29);
            this.villaPage_tb.TabIndex = 13;
            // 
            // any_cbx
            // 
            this.any_cbx.AutoSize = true;
            this.any_cbx.Checked = true;
            this.any_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.any_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.any_cbx.Location = new System.Drawing.Point(243, 40);
            this.any_cbx.Name = "any_cbx";
            this.any_cbx.Size = new System.Drawing.Size(53, 24);
            this.any_cbx.TabIndex = 19;
            this.any_cbx.Text = "any";
            this.any_cbx.UseVisualStyleBackColor = true;
            // 
            // pasteLinksToAdmin_btn
            // 
            this.pasteLinksToAdmin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pasteLinksToAdmin_btn.Location = new System.Drawing.Point(2, 40);
            this.pasteLinksToAdmin_btn.Name = "pasteLinksToAdmin_btn";
            this.pasteLinksToAdmin_btn.Size = new System.Drawing.Size(109, 29);
            this.pasteLinksToAdmin_btn.TabIndex = 18;
            this.pasteLinksToAdmin_btn.Text = "<- Paste links To Admin";
            this.pasteLinksToAdmin_btn.UseVisualStyleBackColor = true;
            this.pasteLinksToAdmin_btn.Visible = false;
            // 
            // villaPage_btn
            // 
            this.villaPage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.villaPage_btn.Location = new System.Drawing.Point(362, 40);
            this.villaPage_btn.Name = "villaPage_btn";
            this.villaPage_btn.Size = new System.Drawing.Size(109, 29);
            this.villaPage_btn.TabIndex = 14;
            this.villaPage_btn.Text = "Go To Page";
            this.villaPage_btn.UseVisualStyleBackColor = true;
            this.villaPage_btn.Click += new System.EventHandler(this.loadImagesPage_btn_Click);
            // 
            // selectLinks_btn
            // 
            this.selectLinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectLinks_btn.Location = new System.Drawing.Point(117, 40);
            this.selectLinks_btn.Name = "selectLinks_btn";
            this.selectLinks_btn.Size = new System.Drawing.Size(109, 29);
            this.selectLinks_btn.TabIndex = 17;
            this.selectLinks_btn.Text = "Select links";
            this.selectLinks_btn.UseVisualStyleBackColor = true;
            this.selectLinks_btn.Click += new System.EventHandler(this.selectLinks_btn_Click);
            // 
            // jpg_cbx
            // 
            this.jpg_cbx.AutoSize = true;
            this.jpg_cbx.Checked = true;
            this.jpg_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jpg_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jpg_cbx.Location = new System.Drawing.Point(302, 42);
            this.jpg_cbx.Name = "jpg_cbx";
            this.jpg_cbx.Size = new System.Drawing.Size(49, 24);
            this.jpg_cbx.TabIndex = 15;
            this.jpg_cbx.Text = "jpg";
            this.jpg_cbx.UseVisualStyleBackColor = true;
            // 
            // gif_cbx
            // 
            this.gif_cbx.AutoSize = true;
            this.gif_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gif_cbx.Location = new System.Drawing.Point(302, 71);
            this.gif_cbx.Name = "gif_cbx";
            this.gif_cbx.Size = new System.Drawing.Size(45, 24);
            this.gif_cbx.TabIndex = 16;
            this.gif_cbx.Text = "gif";
            this.gif_cbx.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 687);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog selectFolder_dialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser villa_wbr;
        private System.Windows.Forms.TabPage tabPage3;
        //private Gecko.GeckoWebBrowser villa_wbr2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button autoNextBtn;
        private System.Windows.Forms.TextBox path_tbx;
        private System.Windows.Forms.Button saveToDisk_btn;
        private System.Windows.Forms.Button selectFromFolder_btn;
        private System.Windows.Forms.ProgressBar villasImages_progressBar;
        private System.Windows.Forms.TextBox villaPage_tb;
        private System.Windows.Forms.CheckBox any_cbx;
        private System.Windows.Forms.Button pasteLinksToAdmin_btn;
        private System.Windows.Forms.Button villaPage_btn;
        private System.Windows.Forms.Button selectLinks_btn;
        private System.Windows.Forms.CheckBox jpg_cbx;
        private System.Windows.Forms.CheckBox gif_cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxTo;
        private System.Windows.Forms.TextBox txtBxFrom;
    }
}

