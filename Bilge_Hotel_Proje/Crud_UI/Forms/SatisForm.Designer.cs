namespace Crud_UI.Forms
{
    partial class SatisForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rezervasyonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatilPaketiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vardiyalarVeÇalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonlarToolStripMenuItem,
            this.odaToolStripMenuItem,
            this.tatilPaketiToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.vardiyalarVeÇalışanlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1433, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezervasyonlarToolStripMenuItem
            // 
            this.rezervasyonlarToolStripMenuItem.Name = "rezervasyonlarToolStripMenuItem";
            this.rezervasyonlarToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.rezervasyonlarToolStripMenuItem.Text = "Rezervasyonlar";
            this.rezervasyonlarToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonlarToolStripMenuItem_Click);
            // 
            // odaToolStripMenuItem
            // 
            this.odaToolStripMenuItem.Name = "odaToolStripMenuItem";
            this.odaToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.odaToolStripMenuItem.Text = "Oda";
            this.odaToolStripMenuItem.Click += new System.EventHandler(this.odaToolStripMenuItem_Click);
            // 
            // tatilPaketiToolStripMenuItem
            // 
            this.tatilPaketiToolStripMenuItem.Name = "tatilPaketiToolStripMenuItem";
            this.tatilPaketiToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.tatilPaketiToolStripMenuItem.Text = "Tatil Paketi";
            this.tatilPaketiToolStripMenuItem.Click += new System.EventHandler(this.tatilPaketiToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // vardiyalarVeÇalışanlarToolStripMenuItem
            // 
            this.vardiyalarVeÇalışanlarToolStripMenuItem.Name = "vardiyalarVeÇalışanlarToolStripMenuItem";
            this.vardiyalarVeÇalışanlarToolStripMenuItem.Size = new System.Drawing.Size(207, 29);
            this.vardiyalarVeÇalışanlarToolStripMenuItem.Text = "Vardiyalar ve Çalışanlar";
            this.vardiyalarVeÇalışanlarToolStripMenuItem.Click += new System.EventHandler(this.vardiyalarVeÇalışanlarToolStripMenuItem_Click);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 939);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatilPaketiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vardiyalarVeÇalışanlarToolStripMenuItem;
    }
}