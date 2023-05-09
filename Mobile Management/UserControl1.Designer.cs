namespace Mobile_Management
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBanner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBanner
            // 
            this.labelBanner.AutoSize = true;
            this.labelBanner.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanner.Location = new System.Drawing.Point(326, 255);
            this.labelBanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(355, 59);
            this.labelBanner.TabIndex = 1;
            this.labelBanner.Text = "ANHTUAN.CO";
            this.labelBanner.Click += new System.EventHandler(this.labelBanner_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelBanner);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1041, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBanner;
    }
}
