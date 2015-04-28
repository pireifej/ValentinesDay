namespace Valentine_s_Day
{
    partial class frm_Message
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
            this.pbx_foreword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_foreword)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_foreword
            // 
            this.pbx_foreword.Image = global::Valentine_s_Day.Properties.Resources.foreword;
            this.pbx_foreword.Location = new System.Drawing.Point(0, 0);
            this.pbx_foreword.Name = "pbx_foreword";
            this.pbx_foreword.Size = new System.Drawing.Size(1194, 748);
            this.pbx_foreword.TabIndex = 0;
            this.pbx_foreword.TabStop = false;
            // 
            // frm_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1186, 749);
            this.Controls.Add(this.pbx_foreword);
            this.Name = "frm_Message";
            this.Text = "I love you...";
            this.Load += new System.EventHandler(this.DeleteMe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_foreword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_foreword;


    }
}