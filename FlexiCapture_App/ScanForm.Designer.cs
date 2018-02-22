namespace FlexiCapture_App
{
    partial class ScanForm
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
            this.progress_Bar = new FlexiCapture_App.Progress_Bar();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progress_Bar
            // 
            this.progress_Bar.Location = new System.Drawing.Point(12, 81);
            this.progress_Bar.Name = "progress_Bar";
            this.progress_Bar.Size = new System.Drawing.Size(429, 23);
            this.progress_Bar.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "button1";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 116);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.progress_Bar);
            this.Name = "ScanForm";
            this.Text = "ScanForm";
            this.Load += new System.EventHandler(this.ScanForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Progress_Bar progress_Bar;
        private System.Windows.Forms.Button btn_start;
    }
}