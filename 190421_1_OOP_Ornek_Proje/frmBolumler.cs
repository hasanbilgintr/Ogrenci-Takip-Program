using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _190421_1_OOP_Ornek_Proje.Manager; //dosyaya ulaşım içim 

namespace _190421_1_OOP_Ornek_Proje
{
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }

        OkulSabahDBEntities DB = new OkulSabahDBEntities();

         BolumlerManager  bolman= new BolumlerManager();

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            Location = new Point(0);

            dataGridView1.DataSource = bolman.BolumListele();
            dataGridView1.Columns["Sınıflar"].Visible = false;
        }

        private void toolStripButtotKayit_Click(object sender, EventArgs e)
        {
            string Eklesonuc = bolman.BolumEkle(textBoxBolum.Text);
            dataGridView1.DataSource = bolman.BolumListele();
            MessageBox.Show(Eklesonuc);
        }

        int bolumler_ID;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxBolum.Text = dataGridView1.CurrentRow.Cells["BolumAdi"].Value.ToString();

            bolumler_ID = (int)dataGridView1.CurrentRow.Cells["BolumlerID"].Value;
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string guncelleSonuc = bolman.Bolumguncelle(bolumler_ID, textBoxBolum.Text);
            dataGridView1.DataSource = bolman.BolumListele();
            MessageBox.Show(guncelleSonuc);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string silsonuc = bolman.BolumSil(bolumler_ID);
            dataGridView1.DataSource = bolman.BolumListele();
            MessageBox.Show(silsonuc);
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bolman.BolumAra(textBoxAra.Text);
        }
    }
}
