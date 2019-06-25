namespace _190421_1_OOP_Ornek_Proje
{
    partial class frmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBolumler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtotKayit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBolum);
            this.groupBox1.Location = new System.Drawing.Point(2, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bölüm Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bölüm Adı";
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Location = new System.Drawing.Point(72, 27);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(100, 20);
            this.textBoxBolum.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 211);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(2, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bölüm Listesi";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(74, 96);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(100, 20);
            this.textBoxAra.TabIndex = 1;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ara";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtotKayit,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(2, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(168, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtotKayit
            // 
            this.toolStripButtotKayit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtotKayit.Image")));
            this.toolStripButtotKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtotKayit.Name = "toolStripButtotKayit";
            this.toolStripButtotKayit.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtotKayit.Text = "Kayıt";
            this.toolStripButtotKayit.Click += new System.EventHandler(this.toolStripButtotKayit_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtotKayit;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
    }
}