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
    public partial class formOgrenciler : Form
    {
        public formOgrenciler()
        {
            InitializeComponent();
        }
        OkulSabahDBEntities DB = new OkulSabahDBEntities();

        OgrencilerManager ogrman = new OgrencilerManager();

        string Isaretli = "";

        private void formOgrenciler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrman.OgrenciListesi();
            dataGridView1.Columns["OgrencilerID"].Width = 70;
            dataGridView1.Columns["OgrenciTc"].Width = 75;
            dataGridView1.Columns["OgrenciAdi"].Width = 65;
            dataGridView1.Columns["OgrenciSoyadi"].Width = 80;
            dataGridView1.Columns["Cinsiyeti"].Width = 52;
            dataGridView1.Columns["DogumTarihi"].Width = 70;
            dataGridView1.Columns["Adres"].Width = 85;
            dataGridView1.Columns["Sınıf"].Width = 55;
            dataGridView1.Columns["KanGrubuAdi"].Width = 75;
            dataGridView1.Columns["DogumYeri"].Width = 70;
            dataGridView1.Columns["KullaniciAdi"].Width = 65;


            comboBoxSinif.DataSource = DB.Sınıflar.ToList();
            comboBoxSinif.DisplayMember = "SinifSubesi";
            comboBoxSinif.ValueMember = "SiniflarID";

            comboBoxDyeri.DataSource = DB.iller.ToList();
            comboBoxDyeri.DisplayMember = "ilAdi";
            comboBoxDyeri.ValueMember = "illerID";

            comboBoxKangrubu.DataSource = DB.KanGruplari.ToList();
            comboBoxKangrubu.DisplayMember = "KanGrubuAdi";
            comboBoxKangrubu.ValueMember = "KanGruplariID";

            comboBoxkullaniciAdi.DataSource = DB.Kullanicilar.ToList();
            comboBoxkullaniciAdi.DisplayMember = "KullaniciAdi";
            comboBoxkullaniciAdi.ValueMember = "KullanicilarID";

            Location = new Point(0);
        }


        private void toolStripButtonKayit_Click(object sender, EventArgs e)
        {
            if (radioButtonErkek.Checked == true) Isaretli = "Erkek";
            else if (radioButtonKadin.Checked == true) Isaretli = "Kadın";

            string KayitSonuc = ogrman.OgrenciEkle(maskedTextBoxTC.Text, textBoxAd.Text, textBoxSoyad.Text, Isaretli.ToString(), dateTimePickerDtarih.Value, textBoxAdres.Text, (int)comboBoxSinif.SelectedValue, (int)comboBoxKangrubu.SelectedValue, (int)comboBoxDyeri.SelectedValue, (int)comboBoxkullaniciAdi.SelectedValue);
            dataGridView1.DataSource = ogrman.OgrenciListesi();
            MessageBox.Show(KayitSonuc);
        }

        int Ogrenciler_ID;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                maskedTextBoxTC.Text = dataGridView1.CurrentRow.Cells["OgrenciTC"].Value.ToString();
            }
            catch (Exception)
            {
                maskedTextBoxTC.Text = "";
            }

            try
            {
                textBoxAd.Text = dataGridView1.CurrentRow.Cells["OgrenciAdi"].Value.ToString();
            }
            catch (Exception)
            {
                textBoxAd.Text = "";
            }

            try
            {
                textBoxSoyad.Text = dataGridView1.CurrentRow.Cells["OgrenciSoyadi"].Value.ToString();
            }
            catch (Exception)
            {
                textBoxSoyad.Text = "";
            }

            try
            {
                string Isarettrue = dataGridView1.CurrentRow.Cells["Cinsiyeti"].Value.ToString().ToUpper();
                //if (Isarettrue == "Erkek" || Isarettrue == "erkek") { radioButtonErkek.Checked = true; } else if (Isarettrue == "Kadın" || Isarettrue == "kadın") { radioButtonKadin.Checked = true; } 
                if (Isarettrue.StartsWith("E")) { radioButtonErkek.Checked = true; }
                else if ((Isarettrue.StartsWith("K"))) { radioButtonKadin.Checked = true; }
                else if (Isarettrue == "" || Isarettrue != null || Isarettrue != "") { radioButtonErkek.Checked = false; radioButtonKadin.Checked = false; }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Yetkiliye Bildiriniz");
            }

            try
            {
                dateTimePickerDtarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DogumTarihi"].Value.ToString());
            }
            catch (Exception)
            {
                dateTimePickerDtarih.Value = DateTime.Parse("1.01.2000");
            }

            try
            {
                textBoxAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            }
            catch (Exception)
            {
                textBoxAdres.Text = "";
            }

            try
            {
                string Sinif_ = dataGridView1.CurrentRow.Cells["Sınıf"].Value.ToString();
                comboBoxSinif.Text = DB.Sınıflar.Where(f => f.SinifSubesi == Sinif_).FirstOrDefault().SinifSubesi;
            }
            catch (Exception)
            {
                comboBoxSinif.Text = "";
            }

            try
            {
                string Kangrubuadi_ = dataGridView1.CurrentRow.Cells["KangrubuAdi"].Value.ToString();
                comboBoxKangrubu.Text = DB.KanGruplari.Where(p => p.KanGrubuAdi == Kangrubuadi_).FirstOrDefault().KanGrubuAdi;
            }
            catch (Exception)
            {
                comboBoxKangrubu.Text = "";
            }

            try
            {
                string Kullaniciadi_ = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
                comboBoxkullaniciAdi.Text = DB.Kullanicilar.Where(w => w.KullaniciAdi == Kullaniciadi_).FirstOrDefault().KullaniciAdi;
            }
            catch (Exception)
            {
                comboBoxkullaniciAdi.Text = "";
            }

            try
            {
                string dyeri_ = dataGridView1.CurrentRow.Cells["DogumYeri"].Value.ToString();
                comboBoxDyeri.Text = DB.iller.Where(s => s.ilAdi == dyeri_).FirstOrDefault().ilAdi;
            }
            catch (Exception)
            {
                comboBoxDyeri.Text = "";
            }

            Ogrenciler_ID = (int)dataGridView1.CurrentRow.Cells["OgrencilerID"].Value;
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (radioButtonErkek.Checked == true) Isaretli = "Erkek";
            else if (radioButtonKadin.Checked == true) Isaretli = "Kadın";

            string GuncellleSonuc = ogrman.OgrenciGuncelle(Ogrenciler_ID, maskedTextBoxTC.Text, textBoxAd.Text, textBoxSoyad.Text, Isaretli.ToString(), dateTimePickerDtarih.Value, textBoxAdres.Text, (int)comboBoxSinif.SelectedValue, (int)comboBoxKangrubu.SelectedValue, (int)comboBoxDyeri.SelectedValue, (int)comboBoxkullaniciAdi.SelectedValue);
            dataGridView1.DataSource = ogrman.OgrenciListesi();
            MessageBox.Show(GuncellleSonuc);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string SilmeSonuc = ogrman.OgrenciSil(Ogrenciler_ID);
            dataGridView1.DataSource = ogrman.OgrenciListesi();
            MessageBox.Show(SilmeSonuc);
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrman.OgrenciAra(textBoxAra.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrman.SinifveCinsiyetAra(textBox2.Text, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrman.SinifveCinsiyetAra(textBox2.Text, textBox1.Text);
        }

        private void toolStripButtonYenileme_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrman.OgrenciListesi();
        }
    }
}
