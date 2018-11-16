namespace ImageLinksLoader_Net2
{
    partial class LinksListForm
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
            this.components = new System.ComponentModel.Container();
            this.links_listView = new System.Windows.Forms.ListView();
            this.copy_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicate_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDisk_btn = new System.Windows.Forms.Button();
            this.saveAndCrop_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resizeAndSaveLinks_btn = new System.Windows.Forms.Button();
            this.newSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.newWidthBtn = new System.Windows.Forms.RadioButton();
            this.byPersintageRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reverse_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.path_tbx = new System.Windows.Forms.TextBox();
            this.saveDisk_progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findReplace_btn = new System.Windows.Forms.Button();
            this.toFind_tbx = new System.Windows.Forms.TextBox();
            this.replaceTo_tbx = new System.Windows.Forms.TextBox();
            this.selectAll_cbx = new System.Windows.Forms.CheckBox();
            this.copy_contextMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSizeNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // links_listView
            // 
            this.links_listView.CheckBoxes = true;
            this.links_listView.ContextMenuStrip = this.copy_contextMenuStrip;
            this.links_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.links_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.links_listView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.links_listView.LabelEdit = true;
            this.links_listView.Location = new System.Drawing.Point(0, 202);
            this.links_listView.Name = "links_listView";
            this.links_listView.Size = new System.Drawing.Size(1193, 437);
            this.links_listView.TabIndex = 0;
            this.links_listView.UseCompatibleStateImageBehavior = false;
            this.links_listView.View = System.Windows.Forms.View.List;
            // 
            // copy_contextMenuStrip
            // 
            this.copy_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy_menuItem,
            this.edit_menuItem,
            this.duplicate_menuItem});
            this.copy_contextMenuStrip.Name = "copy_contextMenuStrip";
            this.copy_contextMenuStrip.Size = new System.Drawing.Size(125, 70);
            // 
            // copy_menuItem
            // 
            this.copy_menuItem.Name = "copy_menuItem";
            this.copy_menuItem.Size = new System.Drawing.Size(124, 22);
            this.copy_menuItem.Text = "Copy";
            this.copy_menuItem.Click += new System.EventHandler(this.copy_menuItem_Click);
            // 
            // edit_menuItem
            // 
            this.edit_menuItem.Name = "edit_menuItem";
            this.edit_menuItem.Size = new System.Drawing.Size(124, 22);
            this.edit_menuItem.Text = "Edit";
            this.edit_menuItem.Click += new System.EventHandler(this.edit_menuItem_Click);
            // 
            // duplicate_menuItem
            // 
            this.duplicate_menuItem.Name = "duplicate_menuItem";
            this.duplicate_menuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicate_menuItem.Text = "Duplicate";
            // 
            // saveToDisk_btn
            // 
            this.saveToDisk_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveToDisk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveToDisk_btn.Location = new System.Drawing.Point(1070, 0);
            this.saveToDisk_btn.Name = "saveToDisk_btn";
            this.saveToDisk_btn.Size = new System.Drawing.Size(123, 202);
            this.saveToDisk_btn.TabIndex = 6;
            this.saveToDisk_btn.Text = "Save To Disk";
            this.saveToDisk_btn.UseVisualStyleBackColor = true;
            this.saveToDisk_btn.Click += new System.EventHandler(this.saveToDisk_btn_Click);
            // 
            // saveAndCrop_btn
            // 
            this.saveAndCrop_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveAndCrop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveAndCrop_btn.Location = new System.Drawing.Point(947, 0);
            this.saveAndCrop_btn.Name = "saveAndCrop_btn";
            this.saveAndCrop_btn.Size = new System.Drawing.Size(123, 202);
            this.saveAndCrop_btn.TabIndex = 12;
            this.saveAndCrop_btn.Text = "Save && Crop";
            this.saveAndCrop_btn.UseVisualStyleBackColor = true;
            this.saveAndCrop_btn.Click += new System.EventHandler(this.saveAndCrop_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resizeAndSaveLinks_btn);
            this.groupBox2.Controls.Add(this.newSizeNumeric);
            this.groupBox2.Controls.Add(this.newWidthBtn);
            this.groupBox2.Controls.Add(this.byPersintageRbtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(625, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 202);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize";
            // 
            // resizeAndSaveLinks_btn
            // 
            this.resizeAndSaveLinks_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeAndSaveLinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resizeAndSaveLinks_btn.Location = new System.Drawing.Point(181, 16);
            this.resizeAndSaveLinks_btn.Name = "resizeAndSaveLinks_btn";
            this.resizeAndSaveLinks_btn.Size = new System.Drawing.Size(138, 183);
            this.resizeAndSaveLinks_btn.TabIndex = 3;
            this.resizeAndSaveLinks_btn.Text = "Resize&&Save";
            this.resizeAndSaveLinks_btn.UseVisualStyleBackColor = true;
            this.resizeAndSaveLinks_btn.Click += new System.EventHandler(this.resizeAndSaveLinks_btn_Click);
            // 
            // newSizeNumeric
            // 
            this.newSizeNumeric.Location = new System.Drawing.Point(73, 21);
            this.newSizeNumeric.Name = "newSizeNumeric";
            this.newSizeNumeric.Size = new System.Drawing.Size(71, 20);
            this.newSizeNumeric.TabIndex = 1;
            // 
            // newWidthBtn
            // 
            this.newWidthBtn.AutoSize = true;
            this.newWidthBtn.Location = new System.Drawing.Point(6, 44);
            this.newWidthBtn.Name = "newWidthBtn";
            this.newWidthBtn.Size = new System.Drawing.Size(64, 17);
            this.newWidthBtn.TabIndex = 0;
            this.newWidthBtn.Text = "by width";
            this.newWidthBtn.UseVisualStyleBackColor = true;
            this.newWidthBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // byPersintageRbtn
            // 
            this.byPersintageRbtn.AutoSize = true;
            this.byPersintageRbtn.Checked = true;
            this.byPersintageRbtn.Location = new System.Drawing.Point(6, 21);
            this.byPersintageRbtn.Name = "byPersintageRbtn";
            this.byPersintageRbtn.Size = new System.Drawing.Size(47, 17);
            this.byPersintageRbtn.TabIndex = 0;
            this.byPersintageRbtn.TabStop = true;
            this.byPersintageRbtn.Text = "by %";
            this.byPersintageRbtn.UseVisualStyleBackColor = true;
            this.byPersintageRbtn.CheckedChanged += new System.EventHandler(this.byPersintageRbtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reverse_btn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.path_tbx);
            this.groupBox3.Controls.Add(this.saveDisk_progressBar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.selectAll_cbx);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 202);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Common";
            // 
            // reverse_btn
            // 
            this.reverse_btn.Location = new System.Drawing.Point(363, 158);
            this.reverse_btn.Name = "reverse_btn";
            this.reverse_btn.Size = new System.Drawing.Size(87, 23);
            this.reverse_btn.TabIndex = 18;
            this.reverse_btn.Text = "Reverse";
            this.reverse_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Path to disk folder:";
            // 
            // path_tbx
            // 
            this.path_tbx.Location = new System.Drawing.Point(122, 161);
            this.path_tbx.Name = "path_tbx";
            this.path_tbx.ReadOnly = true;
            this.path_tbx.Size = new System.Drawing.Size(235, 20);
            this.path_tbx.TabIndex = 14;
            // 
            // saveDisk_progressBar
            // 
            this.saveDisk_progressBar.Location = new System.Drawing.Point(122, 134);
            this.saveDisk_progressBar.Name = "saveDisk_progressBar";
            this.saveDisk_progressBar.Size = new System.Drawing.Size(235, 23);
            this.saveDisk_progressBar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Save to disk progress:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.findReplace_btn);
            this.groupBox1.Controls.Add(this.toFind_tbx);
            this.groupBox1.Controls.Add(this.replaceTo_tbx);
            this.groupBox1.Location = new System.Drawing.Point(177, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find && Replace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find:";
            // 
            // findReplace_btn
            // 
            this.findReplace_btn.Location = new System.Drawing.Point(117, 67);
            this.findReplace_btn.Name = "findReplace_btn";
            this.findReplace_btn.Size = new System.Drawing.Size(100, 23);
            this.findReplace_btn.TabIndex = 0;
            this.findReplace_btn.Text = "Find && Replace";
            this.findReplace_btn.UseVisualStyleBackColor = true;
            this.findReplace_btn.Click += new System.EventHandler(this.findReplace_btn_Click);
            // 
            // toFind_tbx
            // 
            this.toFind_tbx.Location = new System.Drawing.Point(11, 44);
            this.toFind_tbx.Name = "toFind_tbx";
            this.toFind_tbx.Size = new System.Drawing.Size(100, 20);
            this.toFind_tbx.TabIndex = 3;
            // 
            // replaceTo_tbx
            // 
            this.replaceTo_tbx.Location = new System.Drawing.Point(117, 44);
            this.replaceTo_tbx.Name = "replaceTo_tbx";
            this.replaceTo_tbx.Size = new System.Drawing.Size(100, 20);
            this.replaceTo_tbx.TabIndex = 3;
            // 
            // selectAll_cbx
            // 
            this.selectAll_cbx.AutoSize = true;
            this.selectAll_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectAll_cbx.Location = new System.Drawing.Point(11, 77);
            this.selectAll_cbx.Name = "selectAll_cbx";
            this.selectAll_cbx.Size = new System.Drawing.Size(158, 24);
            this.selectAll_cbx.TabIndex = 12;
            this.selectAll_cbx.Text = "Select/deselect All";
            this.selectAll_cbx.UseVisualStyleBackColor = true;
            // 
            // LinksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 639);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveAndCrop_btn);
            this.Controls.Add(this.saveToDisk_btn);
            this.Controls.Add(this.links_listView);
            this.Name = "LinksListForm";
            this.Text = "Links";
            this.copy_contextMenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSizeNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ListView links_listView;
        private System.Windows.Forms.ContextMenuStrip copy_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copy_menuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicate_menuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_menuItem;
        private System.Windows.Forms.Button saveToDisk_btn;
        private System.Windows.Forms.Button saveAndCrop_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown newSizeNumeric;
        private System.Windows.Forms.RadioButton newWidthBtn;
        private System.Windows.Forms.RadioButton byPersintageRbtn;
        private System.Windows.Forms.Button resizeAndSaveLinks_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button reverse_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path_tbx;
        private System.Windows.Forms.ProgressBar saveDisk_progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findReplace_btn;
        private System.Windows.Forms.TextBox toFind_tbx;
        private System.Windows.Forms.TextBox replaceTo_tbx;
        private System.Windows.Forms.CheckBox selectAll_cbx;
    }
}