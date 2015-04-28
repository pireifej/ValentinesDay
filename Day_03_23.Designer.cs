namespace Valentine_s_Day
{
    partial class Day_03_23
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
            this.lbl_phone = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx_event = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_phone
            // 
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_phone.Location = new System.Drawing.Point(419, 739);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(458, 27);
            this.lbl_phone.TabIndex = 8;
            this.lbl_phone.Text = "http://www.youtube.com/watch?v=AULG4MoYxQk";
            this.lbl_phone.Click += new System.EventHandler(this.lbl_phone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbx_event
            // 
            this.pbx_event.BackgroundImage = global::Valentine_s_Day.Properties.Resources.day_03_23;
            this.pbx_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_event.Location = new System.Drawing.Point(0, 0);
            this.pbx_event.Name = "pbx_event";
            this.pbx_event.Size = new System.Drawing.Size(1198, 885);
            this.pbx_event.TabIndex = 10;
            this.pbx_event.TabStop = false;
            // 
            // Day_03_23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1209, 882);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.pbx_event);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Day_03_23";
            this.Text = "Day_03_23";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbx_event;
    }
}