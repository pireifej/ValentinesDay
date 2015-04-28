namespace Valentine_s_Day
{
    partial class february_2012_frm
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
            this.lbl_day_feb_24 = new System.Windows.Forms.Label();
            this.btn_to_march = new System.Windows.Forms.Button();
            this.btn_to_january = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_day_feb_24
            // 
            this.lbl_day_feb_24.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_feb_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_day_feb_24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_day_feb_24.Location = new System.Drawing.Point(234, 546);
            this.lbl_day_feb_24.Name = "lbl_day_feb_24";
            this.lbl_day_feb_24.Size = new System.Drawing.Size(28, 24);
            this.lbl_day_feb_24.TabIndex = 1;
            this.lbl_day_feb_24.Click += new System.EventHandler(this.lbl_day_feb_24_Click);
            // 
            // btn_to_march
            // 
            this.btn_to_march.BackgroundImage = global::Valentine_s_Day.Properties.Resources.right_arrow;
            this.btn_to_march.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_to_march.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_to_march.Location = new System.Drawing.Point(944, 338);
            this.btn_to_march.Name = "btn_to_march";
            this.btn_to_march.Size = new System.Drawing.Size(80, 54);
            this.btn_to_march.TabIndex = 2;
            this.btn_to_march.Text = "To March";
            this.btn_to_march.UseVisualStyleBackColor = true;
            this.btn_to_march.Click += new System.EventHandler(this.btn_to_march_Click);
            // 
            // btn_to_january
            // 
            this.btn_to_january.BackgroundImage = global::Valentine_s_Day.Properties.Resources.left_arrow;
            this.btn_to_january.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_to_january.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_to_january.Location = new System.Drawing.Point(12, 338);
            this.btn_to_january.Name = "btn_to_january";
            this.btn_to_january.Size = new System.Drawing.Size(80, 54);
            this.btn_to_january.TabIndex = 3;
            this.btn_to_january.Text = "To January";
            this.btn_to_january.UseVisualStyleBackColor = true;
            this.btn_to_january.Click += new System.EventHandler(this.btn_to_february_Click);
            // 
            // february_2012_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Valentine_s_Day.Properties.Resources.february_2012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1036, 599);
            this.Controls.Add(this.btn_to_january);
            this.Controls.Add(this.btn_to_march);
            this.Controls.Add(this.lbl_day_feb_24);
            this.Name = "february_2012_frm";
            this.Text = "February 2013";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_day_feb_24;
        private System.Windows.Forms.Button btn_to_march;
        private System.Windows.Forms.Button btn_to_january;
    }
}