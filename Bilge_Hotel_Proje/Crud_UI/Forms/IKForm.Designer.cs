namespace Crud_UI.Forms
{
    partial class IKForm
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
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vardiyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToLoginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarVeMusterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.vardiyalarToolStripMenuItem,
            this.returnToLoginFormToolStripMenuItem,
            this.odalarVeMusterilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1526, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            this.çalışanlarToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarToolStripMenuItem_Click);
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
            // odalarVeMusterilerToolStripMenuItem
            // 
            this.odalarVeMusterilerToolStripMenuItem.Name = "odalarVeMusterilerToolStripMenuItem";
            this.odalarVeMusterilerToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.odalarVeMusterilerToolStripMenuItem.Text = "Odalar ve Musteriler";
            this.odalarVeMusterilerToolStripMenuItem.Click += new System.EventHandler(this.odalarVeMusterilerToolStripMenuItem_Click);
            // 
            // IKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 883);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IKForm";
            this.Text = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vardiyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToLoginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarVeMusterilerToolStripMenuItem;
    }
}