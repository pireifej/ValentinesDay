namespace Valentine_s_Day
{
    partial class Day_03_14
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
            this.lbl_phone_music = new System.Windows.Forms.Label();
            this.pbx_event = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_phone_music
            // 
            this.lbl_phone_music.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_phone_music.Image = global::Valentine_s_Day.Properties.Resources.phone;
            this.lbl_phone_music.Location = new System.Drawing.Point(132, 395);
            this.lbl_phone_music.Name = "lbl_phone_music";
            this.lbl_phone_music.Size = new System.Drawing.Size(170, 328);
            this.lbl_phone_music.TabIndex = 9;
            this.lbl_phone_music.Click += new System.EventHandler(this.lbl_phone_music_Click);
            // 
            // pbx_event
            // 
            this.pbx_event.BackgroundImage = global::Valentine_s_Day.Properties.Resources.day_03_14;
            this.pbx_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_event.Location = new System.Drawing.Point(0, 0);
            this.pbx_event.Name = "pbx_event";
            this.pbx_event.Size = new System.Drawing.Size(1195, 887);
            this.pbx_event.TabIndex = 8;
            this.pbx_event.TabStop = false;
            // 
            // Day_03_14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(861, 629);
            this.Controls.Add(this.lbl_phone_music);
            this.Controls.Add(this.pbx_event);
            this.Name = "Day_03_14";
            this.Text = "Day 03 14";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_event;
        private System.Windows.Forms.Label lbl_phone_music;
    }
}