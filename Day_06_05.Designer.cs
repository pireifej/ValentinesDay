namespace Valentine_s_Day
{
    partial class Day_06_05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Day_06_05));
            this.rtb_email_content = new System.Windows.Forms.RichTextBox();
            this.pbx_event = new System.Windows.Forms.PictureBox();
            this.lbl_friday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_email_content
            // 
            this.rtb_email_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_email_content.Location = new System.Drawing.Point(28, 196);
            this.rtb_email_content.Name = "rtb_email_content";
            this.rtb_email_content.ReadOnly = true;
            this.rtb_email_content.Size = new System.Drawing.Size(1070, 537);
            this.rtb_email_content.TabIndex = 1;
            this.rtb_email_content.Text = resources.GetString("rtb_email_content.Text");
            // 
            // pbx_event
            // 
            this.pbx_event.BackgroundImage = global::Valentine_s_Day.Properties.Resources.day_06_05;
            this.pbx_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_event.Location = new System.Drawing.Point(-2, 0);
            this.pbx_event.Name = "pbx_event";
            this.pbx_event.Size = new System.Drawing.Size(1167, 748);
            this.pbx_event.TabIndex = 0;
            this.pbx_event.TabStop = false;
            // 
            // lbl_friday
            // 
            this.lbl_friday.AutoSize = true;
            this.lbl_friday.BackColor = System.Drawing.Color.DarkRed;
            this.lbl_friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_friday.ForeColor = System.Drawing.Color.White;
            this.lbl_friday.Location = new System.Drawing.Point(2, 9);
            this.lbl_friday.Name = "lbl_friday";
            this.lbl_friday.Size = new System.Drawing.Size(266, 29);
            this.lbl_friday.TabIndex = 2;
            this.lbl_friday.Text = "Tuesday, June 05, 2012";
            this.lbl_friday.Click += new System.EventHandler(this.label1_Click);
            // 
            // Day_06_05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 745);
            this.Controls.Add(this.lbl_friday);
            this.Controls.Add(this.rtb_email_content);
            this.Controls.Add(this.pbx_event);
            this.Name = "Day_06_05";
            this.Text = "Day_06_05";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_event;
        private System.Windows.Forms.RichTextBox rtb_email_content;
        protected System.Windows.Forms.Label lbl_friday;
    }
}