namespace _190421_1_OOP_Ornek_Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBolumu = new System.Windows.Forms.ComboBox();
            this.comboBoxOgretmeni = new System.Windows.Forms.ComboBox();
            this.textBoxSinifSubesi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEkle,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonEkle
            // 
            this.toolStripButtonEkle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.toolStripButtonEkle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEkle.Image")));
            this.toolStripButtonEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEkle.Name = "toolStripButtonEkle";
            this.toolStripButtonEkle.Size = new System.Drawing.Size(55, 23);
            this.toolStripButtonEkle.Text = "Ekle";
            this.toolStripButtonEkle.Click += new System.EventHandler(this.toolStripButtonEkle_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(83, 23);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(45, 23);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBolumu);
            this.groupBox1.Controls.Add(this.comboBoxOgretmeni);
            this.groupBox1.Controls.Add(this.textBoxSinifSubesi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Bilgileri";
            // 
            // comboBoxBolumu
            // 
            this.comboBoxBolumu.FormattingEnabled = true;
            this.comboBoxBolumu.Location = new System.Drawing.Point(348, 50);
            this.comboBoxBolumu.Name = "comboBoxBolumu";
            this.comboBoxBolumu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBolumu.TabIndex = 2;
            // 
            // comboBoxOgretmeni
            // 
            this.comboBoxOgretmeni.FormattingEnabled = true;
            this.comboBoxOgretmeni.Location = new System.Drawing.Point(348, 18);
            this.comboBoxOgretmeni.Name = "comboBoxOgretmeni";
            this.comboBoxOgretmeni.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOgretmeni.TabIndex = 2;
            // 
            // textBoxSinifSubesi
            // 
            this.textBoxSinifSubesi.Location = new System.Drawing.Point(126, 32);
            this.textBoxSinifSubesi.Name = "textBoxSinifSubesi";
            this.textBoxSinifSubesi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSinifSubesi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sınıf Şubesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğretmeni:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(483, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sınıflar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEkle;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBolumu;
        private System.Windows.Forms.ComboBox comboBoxOgretmeni;
        private System.Windows.Forms.TextBox textBoxSinifSubesi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

