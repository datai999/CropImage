namespace CropImage
{
    partial class FormCropImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCropImage));
            this.picBox_original = new System.Windows.Forms.PictureBox();
            this.picBox_crop = new System.Windows.Forms.PictureBox();
            this.btn_resize = new System.Windows.Forms.Button();
            this.nud_top = new System.Windows.Forms.NumericUpDown();
            this.textview_top = new System.Windows.Forms.TextBox();
            this.textview_bot = new System.Windows.Forms.TextBox();
            this.nud_bot = new System.Windows.Forms.NumericUpDown();
            this.textview_left = new System.Windows.Forms.TextBox();
            this.nud_left = new System.Windows.Forms.NumericUpDown();
            this.textview_right = new System.Windows.Forms.TextBox();
            this.nud_right = new System.Windows.Forms.NumericUpDown();
            this.textview_sizeOriginal = new System.Windows.Forms.TextBox();
            this.textview_sizeCrop = new System.Windows.Forms.TextBox();
            this.text_test = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_crop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_right)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_original
            // 
            this.picBox_original.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picBox_original.Location = new System.Drawing.Point(12, 12);
            this.picBox_original.Name = "picBox_original";
            this.picBox_original.Size = new System.Drawing.Size(600, 800);
            this.picBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_original.TabIndex = 0;
            this.picBox_original.TabStop = false;
            this.picBox_original.Click += new System.EventHandler(this.picBox_original_Click);
            // 
            // picBox_crop
            // 
            this.picBox_crop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picBox_crop.Location = new System.Drawing.Point(770, 12);
            this.picBox_crop.Name = "picBox_crop";
            this.picBox_crop.Size = new System.Drawing.Size(600, 800);
            this.picBox_crop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_crop.TabIndex = 1;
            this.picBox_crop.TabStop = false;
            // 
            // btn_resize
            // 
            this.btn_resize.Location = new System.Drawing.Point(618, 280);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(146, 55);
            this.btn_resize.TabIndex = 0;
            this.btn_resize.Text = "Resize";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // nud_top
            // 
            this.nud_top.Location = new System.Drawing.Point(677, 111);
            this.nud_top.Name = "nud_top";
            this.nud_top.Size = new System.Drawing.Size(50, 22);
            this.nud_top.TabIndex = 1;
            this.nud_top.TabStop = false;
            this.nud_top.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nud_top.ValueChanged += new System.EventHandler(this.resize);
            // 
            // textview_top
            // 
            this.textview_top.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textview_top.Enabled = false;
            this.textview_top.Location = new System.Drawing.Point(630, 111);
            this.textview_top.Multiline = true;
            this.textview_top.Name = "textview_top";
            this.textview_top.ReadOnly = true;
            this.textview_top.Size = new System.Drawing.Size(40, 22);
            this.textview_top.TabIndex = 6;
            this.textview_top.TabStop = false;
            this.textview_top.Text = "Top :";
            this.textview_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textview_bot
            // 
            this.textview_bot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textview_bot.Enabled = false;
            this.textview_bot.Location = new System.Drawing.Point(630, 151);
            this.textview_bot.Multiline = true;
            this.textview_bot.Name = "textview_bot";
            this.textview_bot.ReadOnly = true;
            this.textview_bot.Size = new System.Drawing.Size(40, 22);
            this.textview_bot.TabIndex = 8;
            this.textview_bot.TabStop = false;
            this.textview_bot.Text = "Bot :";
            this.textview_bot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_bot
            // 
            this.nud_bot.Location = new System.Drawing.Point(677, 151);
            this.nud_bot.Name = "nud_bot";
            this.nud_bot.Size = new System.Drawing.Size(50, 22);
            this.nud_bot.TabIndex = 2;
            this.nud_bot.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nud_bot.ValueChanged += new System.EventHandler(this.resize);
            // 
            // textview_left
            // 
            this.textview_left.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textview_left.Enabled = false;
            this.textview_left.Location = new System.Drawing.Point(630, 196);
            this.textview_left.Multiline = true;
            this.textview_left.Name = "textview_left";
            this.textview_left.ReadOnly = true;
            this.textview_left.Size = new System.Drawing.Size(40, 22);
            this.textview_left.TabIndex = 10;
            this.textview_left.TabStop = false;
            this.textview_left.Text = "Left :";
            this.textview_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_left
            // 
            this.nud_left.Location = new System.Drawing.Point(677, 196);
            this.nud_left.Name = "nud_left";
            this.nud_left.Size = new System.Drawing.Size(50, 22);
            this.nud_left.TabIndex = 3;
            this.nud_left.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nud_left.ValueChanged += new System.EventHandler(this.resize);
            // 
            // textview_right
            // 
            this.textview_right.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textview_right.Enabled = false;
            this.textview_right.Location = new System.Drawing.Point(630, 236);
            this.textview_right.Multiline = true;
            this.textview_right.Name = "textview_right";
            this.textview_right.ReadOnly = true;
            this.textview_right.Size = new System.Drawing.Size(40, 22);
            this.textview_right.TabIndex = 12;
            this.textview_right.TabStop = false;
            this.textview_right.Text = "Right :";
            this.textview_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_right
            // 
            this.nud_right.Location = new System.Drawing.Point(677, 236);
            this.nud_right.Name = "nud_right";
            this.nud_right.Size = new System.Drawing.Size(50, 22);
            this.nud_right.TabIndex = 4;
            this.nud_right.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nud_right.ValueChanged += new System.EventHandler(this.resize);
            // 
            // textview_sizeOriginal
            // 
            this.textview_sizeOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textview_sizeOriginal.Enabled = false;
            this.textview_sizeOriginal.Location = new System.Drawing.Point(618, 33);
            this.textview_sizeOriginal.Name = "textview_sizeOriginal";
            this.textview_sizeOriginal.Size = new System.Drawing.Size(146, 15);
            this.textview_sizeOriginal.TabIndex = 13;
            this.textview_sizeOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textview_sizeCrop
            // 
            this.textview_sizeCrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textview_sizeCrop.Enabled = false;
            this.textview_sizeCrop.Location = new System.Drawing.Point(618, 67);
            this.textview_sizeCrop.Name = "textview_sizeCrop";
            this.textview_sizeCrop.Size = new System.Drawing.Size(146, 15);
            this.textview_sizeCrop.TabIndex = 14;
            this.textview_sizeCrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_test
            // 
            this.text_test.Enabled = false;
            this.text_test.Location = new System.Drawing.Point(618, 391);
            this.text_test.Multiline = true;
            this.text_test.Name = "text_test";
            this.text_test.Size = new System.Drawing.Size(146, 421);
            this.text_test.TabIndex = 15;
            // 
            // FormCropImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 833);
            this.Controls.Add(this.text_test);
            this.Controls.Add(this.textview_right);
            this.Controls.Add(this.nud_right);
            this.Controls.Add(this.textview_left);
            this.Controls.Add(this.nud_left);
            this.Controls.Add(this.textview_bot);
            this.Controls.Add(this.nud_bot);
            this.Controls.Add(this.textview_top);
            this.Controls.Add(this.nud_top);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.picBox_crop);
            this.Controls.Add(this.picBox_original);
            this.Controls.Add(this.textview_sizeCrop);
            this.Controls.Add(this.textview_sizeOriginal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCropImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Image";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_crop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_original;
        private System.Windows.Forms.PictureBox picBox_crop;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.NumericUpDown nud_top;
        private System.Windows.Forms.TextBox textview_top;
        private System.Windows.Forms.TextBox textview_bot;
        private System.Windows.Forms.NumericUpDown nud_bot;
        private System.Windows.Forms.TextBox textview_left;
        private System.Windows.Forms.NumericUpDown nud_left;
        private System.Windows.Forms.TextBox textview_right;
        private System.Windows.Forms.NumericUpDown nud_right;
        private System.Windows.Forms.TextBox textview_sizeOriginal;
        private System.Windows.Forms.TextBox textview_sizeCrop;
        private System.Windows.Forms.TextBox text_test;
    }
}

