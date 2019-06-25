namespace _190421_1_OOP_Ornek_Proje
{
    partial class FrmMenu
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
            this.OgrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HogrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiniflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BranslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BolumlertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelkuladi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OgrencilerToolStripMenuItem
            // 
            this.OgrencilerToolStripMenuItem.Name = "OgrencilerToolStripMenuItem";
            this.OgrencilerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.OgrencilerToolStripMenuItem.Text = "Öğrenciler";
            this.OgrencilerToolStripMenuItem.Click += new System.EventHandler(this.OgrencilerToolStripMenuItem_Click);
            // 
            // HogrencilerToolStripMenuItem
            // 
            this.HogrencilerToolStripMenuItem.Name = "HogrencilerToolStripMenuItem";
            this.HogrencilerToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.HogrencilerToolStripMenuItem.Text = "HocanınOgrenciler";
            this.HogrencilerToolStripMenuItem.Click += new System.EventHandler(this.HogrencilerToolStripMenuItem_Click);
            // 
            // SiniflarToolStripMenuItem
            // 
            this.SiniflarToolStripMenuItem.Name = "SiniflarToolStripMenuItem";
            this.SiniflarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.SiniflarToolStripMenuItem.Text = "Sınıflar";
            this.SiniflarToolStripMenuItem.Click += new System.EventHandler(this.SiniflarToolStripMenuItem_Click);
            // 
            // BranslarToolStripMenuItem
            // 
            this.BranslarToolStripMenuItem.Name = "BranslarToolStripMenuItem";
            this.BranslarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.BranslarToolStripMenuItem.Text = "Branşlar";
            this.BranslarToolStripMenuItem.Click += new System.EventHandler(this.BranslarToolStripMenuItem_Click);
            // 
            // BolumlertoolStripMenuItem
            // 
            this.BolumlertoolStripMenuItem.Name = "BolumlertoolStripMenuItem";
            this.BolumlertoolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.BolumlertoolStripMenuItem.Text = "Bölümler";
            this.BolumlertoolStripMenuItem.Click += new System.EventHandler(this.BolumlertoolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OgrencilerToolStripMenuItem,
            this.HogrencilerToolStripMenuItem,
            this.SiniflarToolStripMenuItem,
            this.BranslarToolStripMenuItem,
            this.BolumlertoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelkuladi
            // 
            this.labelkuladi.AutoSize = true;
            this.labelkuladi.Location = new System.Drawing.Point(631, 11);
            this.labelkuladi.Name = "labelkuladi";
            this.labelkuladi.Size = new System.Drawing.Size(0, 13);
            this.labelkuladi.TabIndex = 5;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 360);
            this.Controls.Add(this.labelkuladi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem OgrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HogrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SiniflarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BranslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BolumlertoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Label labelkuladi;
    }
}