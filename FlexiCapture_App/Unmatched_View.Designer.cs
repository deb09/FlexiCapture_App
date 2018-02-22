namespace FlexiCapture_App
{
    partial class Unmatched_View
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
            this.Unmatched_Trans = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Unmatched_Trans
            // 
            this.Unmatched_Trans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Date,
            this.Account_Name,
            this.Account_Number,
            this.Amount});
            this.Unmatched_Trans.Location = new System.Drawing.Point(12, 27);
            this.Unmatched_Trans.Name = "Unmatched_Trans";
            this.Unmatched_Trans.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Trans.TabIndex = 0;
            this.Unmatched_Trans.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Trans.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(184, 212);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(309, 401);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Database";
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // Account_Name
            // 
            this.Account_Name.Text = "Account Name";
            this.Account_Name.Width = 200;
            // 
            // Account_Number
            // 
            this.Account_Number.Text = "Account Number";
            this.Account_Number.Width = 130;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Unmatched_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unmatched_Trans);
            this.Controls.Add(this.listView2);
            this.Name = "Unmatched_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unmatched_View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Unmatched_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Unmatched_Trans;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Account_Name;
        private System.Windows.Forms.ColumnHeader Account_Number;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Date;
    }
}