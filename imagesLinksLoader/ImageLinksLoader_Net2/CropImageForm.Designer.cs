namespace ImageLinksLoader_Net2
{
    partial class CropImageForm
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
            this.pbx = new System.Windows.Forms.PictureBox();
            this.right_num = new System.Windows.Forms.NumericUpDown();
            this.left_num = new System.Windows.Forms.NumericUpDown();
            this.bottom_num = new System.Windows.Forms.NumericUpDown();
            this.top_num = new System.Windows.Forms.NumericUpDown();
            this.saveSize_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.perviousBtn = new System.Windows.Forms.Button();
            this.resizeControl1 = new ImageLinksLoader_Net2.ResizeControl();
            this.cropBannerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_num)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx
            // 
            this.pbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx.Location = new System.Drawing.Point(71, 33);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(348, 265);
            this.pbx.TabIndex = 0;
            this.pbx.TabStop = false;
            // 
            // right_num
            // 
            this.right_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.right_num.AutoSize = true;
            this.right_num.Location = new System.Drawing.Point(430, 150);
            this.right_num.Margin = new System.Windows.Forms.Padding(3, 100, 10, 3);
            this.right_num.Name = "right_num";
            this.right_num.Size = new System.Drawing.Size(43, 20);
            this.right_num.TabIndex = 1;
            // 
            // left_num
            // 
            this.left_num.AutoSize = true;
            this.left_num.Location = new System.Drawing.Point(5, 150);
            this.left_num.Margin = new System.Windows.Forms.Padding(200, 5, 3, 3);
            this.left_num.Name = "left_num";
            this.left_num.Size = new System.Drawing.Size(43, 20);
            this.left_num.TabIndex = 2;
            // 
            // bottom_num
            // 
            this.bottom_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottom_num.AutoSize = true;
            this.bottom_num.Location = new System.Drawing.Point(225, 304);
            this.bottom_num.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.bottom_num.Name = "bottom_num";
            this.bottom_num.Size = new System.Drawing.Size(43, 20);
            this.bottom_num.TabIndex = 3;
            // 
            // top_num
            // 
            this.top_num.AutoSize = true;
            this.top_num.Location = new System.Drawing.Point(225, 5);
            this.top_num.Margin = new System.Windows.Forms.Padding(5, 100, 100, 3);
            this.top_num.Name = "top_num";
            this.top_num.Size = new System.Drawing.Size(41, 20);
            this.top_num.TabIndex = 4;
            // 
            // saveSize_btn
            // 
            this.saveSize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSize_btn.Location = new System.Drawing.Point(299, 337);
            this.saveSize_btn.Name = "saveSize_btn";
            this.saveSize_btn.Size = new System.Drawing.Size(120, 23);
            this.saveSize_btn.TabIndex = 5;
            this.saveSize_btn.Text = "Save Crop size";
            this.saveSize_btn.UseVisualStyleBackColor = true;
            this.saveSize_btn.Click += new System.EventHandler(this.saveSize_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next_btn.AutoSize = true;
            this.next_btn.Location = new System.Drawing.Point(425, 275);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(54, 23);
            this.next_btn.TabIndex = 6;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // perviousBtn
            // 
            this.perviousBtn.AutoSize = true;
            this.perviousBtn.Location = new System.Drawing.Point(5, 260);
            this.perviousBtn.Name = "perviousBtn";
            this.perviousBtn.Size = new System.Drawing.Size(58, 23);
            this.perviousBtn.TabIndex = 7;
            this.perviousBtn.Text = "Pervious";
            this.perviousBtn.UseVisualStyleBackColor = true;
            this.perviousBtn.Click += new System.EventHandler(this.perviousBtn_Click);
            // 
            // resizeControl1
            // 
            this.resizeControl1.Location = new System.Drawing.Point(12, 311);
            this.resizeControl1.Name = "resizeControl1";
            this.resizeControl1.Size = new System.Drawing.Size(180, 77);
            this.resizeControl1.TabIndex = 8;
            // 
            // cropBannerBtn
            // 
            this.cropBannerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cropBannerBtn.Location = new System.Drawing.Point(299, 365);
            this.cropBannerBtn.Name = "cropBannerBtn";
            this.cropBannerBtn.Size = new System.Drawing.Size(120, 23);
            this.cropBannerBtn.TabIndex = 5;
            this.cropBannerBtn.Text = "Crop Borders size";
            this.cropBannerBtn.UseVisualStyleBackColor = true;
            this.cropBannerBtn.Click += new System.EventHandler(this.cropBannerBtn_Click);
            // 
            // CropImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.resizeControl1);
            this.Controls.Add(this.perviousBtn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.cropBannerBtn);
            this.Controls.Add(this.saveSize_btn);
            this.Controls.Add(this.top_num);
            this.Controls.Add(this.bottom_num);
            this.Controls.Add(this.left_num);
            this.Controls.Add(this.right_num);
            this.Controls.Add(this.pbx);
            this.Name = "CropImageForm";
            this.Text = "CropImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx;
        private System.Windows.Forms.NumericUpDown right_num;
        private System.Windows.Forms.NumericUpDown left_num;
        private System.Windows.Forms.NumericUpDown bottom_num;
        private System.Windows.Forms.NumericUpDown top_num;
        private System.Windows.Forms.Button saveSize_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button perviousBtn;
        private ResizeControl resizeControl1;
        private System.Windows.Forms.Button cropBannerBtn;
    }
}