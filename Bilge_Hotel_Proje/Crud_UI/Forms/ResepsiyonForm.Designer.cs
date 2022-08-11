namespace Crud_UI.Forms
{
    partial class ResepsiyonForm
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
            this.odaDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vardiyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToLoginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonlarToolStripMenuItem,
            this.odaDurumuToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.vardiyalarToolStripMenuItem,
            this.returnToLoginFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1441, 33);
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
            // odaDurumuToolStripMenuItem
            // 
            this.odaDurumuToolStripMenuItem.Name = "odaDurumuToolStripMenuItem";
            this.odaDurumuToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.odaDurumuToolStripMenuItem.Text = "Oda Durumu";
            this.odaDurumuToolStripMenuItem.Click += new System.EventHandler(this.odaDurumuToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            this.müşteriToolStripMenuItem.Click += new System.EventHandler(this.müşteriToolStripMenuItem_Click);
            // 
            // vardiyalarToolStripMenuItem
            // 
            this.vardiyalarToolStripMenuItem.Name = "vardiyalarToolStripMenuItem";
            this.vardiyalarToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.vardiyalarToolStripMenuItem.Text = "Vardiyalar";
            this.vardiyalarToolStripMenuItem.Click += new System.EventHandler(this.vardiyalarToolStripMenuItem_Click);
            // 
            // returnToLoginFormToolStripMenuItem
            // 
            this.returnToLoginFormToolStripMenuItem.Name = "returnToLoginFormToolStripMenuItem";
            this.returnToLoginFormToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.returnToLoginFormToolStripMenuItem.Text = "Return to Login Form";
            this.returnToLoginFormToolStripMenuItem.Click += new System.EventHandler(this.returnToLoginFormToolStripMenuItem_Click);
            // 
            // ResepsiyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 778);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ResepsiyonForm";
            this.Text = "ResepsiyonForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vardiyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToLoginFormToolStripMenuItem;
    }
}