namespace Crud_UI.Forms
{
    partial class TatilPaketBilgi
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
            this.lstPaket = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstPaket
            // 
            this.lstPaket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lstPaket.GridLines = true;
            this.lstPaket.HideSelection = false;
            this.lstPaket.Location = new System.Drawing.Point(211, 69);
            this.lstPaket.Name = "lstPaket";
            this.lstPaket.Size = new System.Drawing.Size(911, 504);
            this.lstPaket.TabIndex = 9;
            this.lstPaket.UseCompatibleStateImageBehavior = false;
            this.lstPaket.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Paket Adı";
            this.columnHeader2.Width = 198;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 159;
            // 
            // TatilPaketBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 722);
            this.Controls.Add(this.lstPaket);
            this.Name = "TatilPaketBilgi";
            this.Text = "TatilPaketBilgi";
            this.Load += new System.EventHandler(this.TatilPaketBilgi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPaket;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}