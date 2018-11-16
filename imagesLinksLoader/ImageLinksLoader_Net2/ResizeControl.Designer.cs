namespace ImageLinksLoader_Net2
{
    partial class ResizeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resizeAndSaveLinks_btn = new System.Windows.Forms.Button();
            this.newSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.newWidthBtn = new System.Windows.Forms.RadioButton();
            this.byPersintageRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSizeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resizeAndSaveLinks_btn);
            this.groupBox2.Controls.Add(this.newSizeNumeric);
            this.groupBox2.Controls.Add(this.newWidthBtn);
            this.groupBox2.Controls.Add(this.byPersintageRbtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 85);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize";
            // 
            // resizeAndSaveLinks_btn
            // 
            this.resizeAndSaveLinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resizeAndSaveLinks_btn.Location = new System.Drawing.Point(73, 44);
            this.resizeAndSaveLinks_btn.Name = "resizeAndSaveLinks_btn";
            this.resizeAndSaveLinks_btn.Size = new System.Drawing.Size(90, 30);
            this.resizeAndSaveLinks_btn.TabIndex = 3;
            this.resizeAndSaveLinks_btn.Text = "Resize&&Save";
            this.resizeAndSaveLinks_btn.UseVisualStyleBackColor = true;
            this.resizeAndSaveLinks_btn.Visible = false;
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
            this.newWidthBtn.CheckedChanged += new System.EventHandler(this.newWidthBtn_CheckedChanged);
            // 
            // byPersintageRbtn
            // 
            this.byPersintageRbtn.AutoSize = true;
            this.byPersintageRbtn.Location = new System.Drawing.Point(6, 21);
            this.byPersintageRbtn.Name = "byPersintageRbtn";
            this.byPersintageRbtn.Size = new System.Drawing.Size(47, 17);
            this.byPersintageRbtn.TabIndex = 0;
            this.byPersintageRbtn.Text = "by %";
            this.byPersintageRbtn.UseVisualStyleBackColor = true;
            this.byPersintageRbtn.CheckedChanged += new System.EventHandler(this.byPersintageRbtn_CheckedChanged);
            // 
            // ResizeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ResizeControl";
            this.Size = new System.Drawing.Size(185, 85);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSizeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button resizeAndSaveLinks_btn;
        private System.Windows.Forms.NumericUpDown newSizeNumeric;
        private System.Windows.Forms.RadioButton newWidthBtn;
        private System.Windows.Forms.RadioButton byPersintageRbtn;
    }
}
