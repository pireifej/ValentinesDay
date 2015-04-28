namespace Valentine_s_Day
{
    partial class january_2012_frm
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
            this.lbl_day_jan_19 = new System.Windows.Forms.Label();
            this.btn_to_feb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_day_jan_19
            // 
            this.lbl_day_jan_19.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day_jan_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_day_jan_19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_day_jan_19.Location = new System.Drawing.Point(227, 478);
            this.lbl_day_jan_19.Name = "lbl_day_jan_19";
            this.lbl_day_jan_19.Size = new System.Drawing.Size(28, 24);
            this.lbl_day_jan_19.TabIndex = 0;
            this.lbl_day_jan_19.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_to_feb
            // 
            this.btn_to_feb.BackgroundImage = global::Valentine_s_Day.Properties.Resources.right_arrow;
            this.btn_to_feb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_to_feb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_to_feb.Location = new System.Drawing.Point(916, 497);
            this.btn_to_feb.Name = "btn_to_feb";
            this.btn_to_feb.Size = new System.Drawing.Size(80, 54);
            this.btn_to_feb.TabIndex = 1;
            this.btn_to_feb.Text = "To February";
            this.btn_to_feb.UseVisualStyleBackColor = true;
            this.btn_to_feb.Click += new System.EventHandler(this.button1_Click);
            // 
            // january_2012_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Valentine_s_Day.Properties.Resources.january_2012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 599);
            this.Controls.Add(this.btn_to_feb);
            this.Controls.Add(this.lbl_day_jan_19);
            this.Name = "january_2012_frm";
            this.Text = "January 2012";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_day_jan_19;
        private System.Windows.Forms.Button btn_to_feb;



    }
}

