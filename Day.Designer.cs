namespace Valentine_s_Day
{
    partial class Day
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
            this.pbx_event = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_event
            // 
            this.pbx_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_event.Location = new System.Drawing.Point(0, 0);
            this.pbx_event.Name = "pbx_event";
            this.pbx_event.Size = new System.Drawing.Size(1195, 887);
            this.pbx_event.TabIndex = 0;
            this.pbx_event.TabStop = false;
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(844, 612);
            this.Controls.Add(this.pbx_event);
            this.Name = "Day";
            this.Text = "Day";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_event)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_event;


    }
}