namespace FlexiCapture_App
{
    partial class Matched
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
            this.Unmatched_Icbs_Records = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unmatched_Trans_Records = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Unmatched_Icbs_Records
            // 
            this.Unmatched_Icbs_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Account_Name,
            this.Account_Number,
            this.Amount});
            this.Unmatched_Icbs_Records.FullRowSelect = true;
            this.Unmatched_Icbs_Records.Location = new System.Drawing.Point(17, 17);
            this.Unmatched_Icbs_Records.Name = "Unmatched_Icbs_Records";
            this.Unmatched_Icbs_Records.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Icbs_Records.TabIndex = 6;
            this.Unmatched_Icbs_Records.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Icbs_Records.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
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
            // Unmatched_Trans_Records
            // 
            this.Unmatched_Trans_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Unmatched_Trans_Records.FullRowSelect = true;
            this.Unmatched_Trans_Records.Location = new System.Drawing.Point(650, 17);
            this.Unmatched_Trans_Records.Name = "Unmatched_Trans_Records";
            this.Unmatched_Trans_Records.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Trans_Records.TabIndex = 7;
            this.Unmatched_Trans_Records.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Trans_Records.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account Name";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Account Number";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 100;
            // 
            // Matched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 479);
            this.Controls.Add(this.Unmatched_Icbs_Records);
            this.Controls.Add(this.Unmatched_Trans_Records);
            this.Name = "Matched";
            this.Text = "Matched";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Unmatched_Icbs_Records;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Account_Name;
        private System.Windows.Forms.ColumnHeader Account_Number;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ListView Unmatched_Trans_Records;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}