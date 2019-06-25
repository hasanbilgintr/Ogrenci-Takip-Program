using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _190421_1_OOP_Ornek_Proje.Manager;

namespace _190421_1_OOP_Ornek_Proje
{
    public partial class BranslarForm : Form
    {
        public BranslarForm()
        {
            InitializeComponent();
        }

        BranslarManager braman = new BranslarManager();

        private void toolStripButton1_Click(object sender, EventArgs e) //kayıt
        {
            string eklesonuc = braman.Ekle(textBoxBransAdi.Text);
            dataGridView1.DataSource = braman.BransListele();
            MessageBox.Show(eklesonuc);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string guncelleSonuc = braman.Guncelle(branslar_ID, textBoxBransAdi.Text);
            dataGridView1.DataSource = braman.BransListele();
            MessageBox.Show(guncelleSonuc);
        }

        private void BranslarForm_Load(object sender, EventArgs e)
        {
            Location = new Point(0);
            dataGridView1.DataSource = braman.BransListele();
            dataGridView1.Columns["Ogretmenler"].Visible = false;
            dataGridView1.Columns["BranslarID"].Width = 60;
            dataGridView1.Columns["BransAdi"].Width = 70;
        }

        int branslar_ID;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //textBoxBransAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();   // kolon eklendiğinde sıkıntı olabilir dikkat!!
            textBoxBransAdi.Text = dataGridView1.CurrentRow.Cells["BransAdi"].Value.ToString(); //aynı

            branslar_ID = (int)dataGridView1.CurrentRow.Cells["BranslarID"].Value;

            //MessageBox.Show(branslar_ID.ToString());  //test amaçlı
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = braman.BransAra(textBoxAra.Text);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string SilSonuc = braman.Sil(branslar_ID);
            dataGridView1.DataSource = braman.BransListele();
            MessageBox.Show(SilSonuc);
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //temizleme
        {
            //textBoxBransAdi.Clear(); textBoxAra.Clear();
            textBoxBransAdi.Text = braman.GirisTemizle(textBoxBransAdi.Text);
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = braman.BransListele();
        }
    }
}
