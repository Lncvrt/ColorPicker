namespace ColorPicker
{
    partial class ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.lookingatlabel = new System.Windows.Forms.Label();
            this.rgblabel = new System.Windows.Forms.Label();
            this.hexlabel = new System.Windows.Forms.Label();
            this.cmkylabel = new System.Windows.Forms.Label();
            this.previewlabel = new System.Windows.Forms.Label();
            this.colorpreview = new System.Windows.Forms.Panel();
            this.bindlabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.hsllabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lookingatlabel
            // 
            this.lookingatlabel.AutoSize = true;
            this.lookingatlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lookingatlabel.ForeColor = System.Drawing.Color.White;
            this.lookingatlabel.Location = new System.Drawing.Point(112, 15);
            this.lookingatlabel.Name = "lookingatlabel";
            this.lookingatlabel.Size = new System.Drawing.Size(125, 15);
            this.lookingatlabel.TabIndex = 1;
            this.lookingatlabel.Text = "Currently Looking At:";
            // 
            // rgblabel
            // 
            this.rgblabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rgblabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rgblabel.ForeColor = System.Drawing.Color.White;
            this.rgblabel.Location = new System.Drawing.Point(100, 90);
            this.rgblabel.Name = "rgblabel";
            this.rgblabel.Size = new System.Drawing.Size(150, 15);
            this.rgblabel.TabIndex = 2;
            this.rgblabel.Text = "R: n/a, G: n/a, B: n/a";
            this.rgblabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rgblabel.Click += new System.EventHandler(this.rgblabel_Click);
            // 
            // hexlabel
            // 
            this.hexlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hexlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hexlabel.ForeColor = System.Drawing.Color.White;
            this.hexlabel.Location = new System.Drawing.Point(125, 40);
            this.hexlabel.Name = "hexlabel";
            this.hexlabel.Size = new System.Drawing.Size(100, 15);
            this.hexlabel.TabIndex = 3;
            this.hexlabel.Text = "Hex: n/a";
            this.hexlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hexlabel.Click += new System.EventHandler(this.hexlabel_Click);
            // 
            // cmkylabel
            // 
            this.cmkylabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmkylabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmkylabel.ForeColor = System.Drawing.Color.White;
            this.cmkylabel.Location = new System.Drawing.Point(35, 115);
            this.cmkylabel.Name = "cmkylabel";
            this.cmkylabel.Size = new System.Drawing.Size(280, 15);
            this.cmkylabel.TabIndex = 4;
            this.cmkylabel.Text = "CMKY: C: n/a%, M: n/a%, Y: n/a%, K: n/a%";
            this.cmkylabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmkylabel.Click += new System.EventHandler(this.cmkylabel_Click);
            // 
            // previewlabel
            // 
            this.previewlabel.AutoSize = true;
            this.previewlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.previewlabel.ForeColor = System.Drawing.Color.White;
            this.previewlabel.Location = new System.Drawing.Point(147, 140);
            this.previewlabel.Name = "previewlabel";
            this.previewlabel.Size = new System.Drawing.Size(56, 15);
            this.previewlabel.TabIndex = 5;
            this.previewlabel.Text = "Preview:";
            this.previewlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorpreview
            // 
            this.colorpreview.BackColor = System.Drawing.Color.White;
            this.colorpreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorpreview.Location = new System.Drawing.Point(75, 165);
            this.colorpreview.Name = "colorpreview";
            this.colorpreview.Size = new System.Drawing.Size(200, 100);
            this.colorpreview.TabIndex = 6;
            // 
            // bindlabel
            // 
            this.bindlabel.AutoSize = true;
            this.bindlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindlabel.ForeColor = System.Drawing.Color.White;
            this.bindlabel.Location = new System.Drawing.Point(77, 275);
            this.bindlabel.Name = "bindlabel";
            this.bindlabel.Size = new System.Drawing.Size(195, 30);
            this.bindlabel.TabIndex = 7;
            this.bindlabel.Text = "Use middle click to lock it in\r\nUse middle click again to unlock it\r\n";
            this.bindlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statuslabel
            // 
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statuslabel.ForeColor = System.Drawing.Color.White;
            this.statuslabel.Location = new System.Drawing.Point(95, 315);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(160, 15);
            this.statuslabel.TabIndex = 8;
            this.statuslabel.Text = "Current Status: Unlocked";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsllabel
            // 
            this.hsllabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsllabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hsllabel.ForeColor = System.Drawing.Color.White;
            this.hsllabel.Location = new System.Drawing.Point(100, 65);
            this.hsllabel.Name = "hsllabel";
            this.hsllabel.Size = new System.Drawing.Size(150, 15);
            this.hsllabel.TabIndex = 9;
            this.hsllabel.Text = "HSL: n/a°, n/a%, n/a%";
            this.hsllabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsllabel.Click += new System.EventHandler(this.hsllabel_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(334, 351);
            this.Controls.Add(this.hsllabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.bindlabel);
            this.Controls.Add(this.colorpreview);
            this.Controls.Add(this.previewlabel);
            this.Controls.Add(this.cmkylabel);
            this.Controls.Add(this.hexlabel);
            this.Controls.Add(this.rgblabel);
            this.Controls.Add(this.lookingatlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorPicker";
            this.Text = "Color Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lookingatlabel;
        private System.Windows.Forms.Label rgblabel;
        private System.Windows.Forms.Label hexlabel;
        private System.Windows.Forms.Label cmkylabel;
        private System.Windows.Forms.Label previewlabel;
        private System.Windows.Forms.Panel colorpreview;
        private System.Windows.Forms.Label bindlabel;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label hsllabel;
    }
}

