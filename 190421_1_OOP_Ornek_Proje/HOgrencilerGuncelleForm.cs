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
    public partial class HOgrencilerGuncelleForm : Form
    {
        public HOgrencilerGuncelleForm()
        {
            InitializeComponent();
        }

        HOgrencilerManager ogrman = new HOgrencilerManager();

        OkulSabahDBEntities db = new OkulSabahDBEntities();

        public int ogrenciID;

        private void HOgrencilerGuncelleForm_Load(object sender, EventArgs e)
        {
            //hogrenciform devamı...
            //2.yöntem veri ataası ise bu farklı form olduğu için gelen formda datagridview1 deki ogrencilerID değerini globala alıp public yaptık ve burdada globala  ogrenciID globalde public tanımaldık  görüldüğü gibi
            Ogrenciler sonuc = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == ogrenciID);
            try
            {
                comboBoxSinifi.Text = db.Sınıflar.FirstOrDefault(k => k.SiniflarID == sonuc.SinifID).SinifSubesi;
            }
            catch (Exception)
            {
                comboBoxSinifi.Text = "";
            }

            //3-yöntem ise 
            ogrman.kangrubuyukle(comboBoxKanGrubu);

            try
            {
                comboBoxKanGrubu.Text = db.KanGruplari.FirstOrDefault(k => k.KanGruplariID == sonuc.KanGrubuID).KanGrubuAdi;
            }
            catch (Exception)
            {
                comboBoxKanGrubu.Text = "";
            }


            try
            {
                textBoxAdres.Text = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == ogrenciID).Adres;
            }
            catch (Exception)
            {
                textBoxAdres.Text = "";
            }

            try
            {
                textBoxKilo.Text = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == ogrenciID).OgrenciKilo.ToString();
            }
            catch (Exception)
            {
                textBoxKilo.Text = "";
            }

            try
            {
                textBoxBoy.Text = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == ogrenciID).OgrenciBoy.ToString();
            }
            catch (Exception)
            {
                textBoxBoy.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) //Guncellemek
        {
            HOgrencilerForm frm_ogr = (HOgrencilerForm)Application.OpenForms["HOgrencilerForm"];

            string GuncelleSonuc = ogrman.OgrenciGuncelle(ogrenciID, maskedTextBoxTC.Text, textBoxAdi.Text, textBoxSoyadi.Text, ogrman.CinsiyetSecimi(radioButtonErkek,radioButtonKadin), dateTimePickerDogumTarihi.Value, (int)comboBoxDogumYeri.SelectedValue, textBoxAdres.Text, Convert.ToDecimal(textBoxKilo.Text), Convert.ToDecimal(textBoxBoy.Text),(int)comboBoxKanGrubu.SelectedValue,(int)comboBoxSinifi.SelectedValue, 1);
            this.Close();
            frm_ogr.dataGridView1.DataSource = ogrman.OgrenciListele();
            MessageBox.Show(GuncelleSonuc);
        }

        private void buttonOgrencisil_Click(object sender, EventArgs e)
        {
            HOgrencilerForm frm_ogr = (HOgrencilerForm)Application.OpenForms["HOgrencilerForm"];
            string SilSonuc = ogrman.OgrenciSil(ogrenciID);
            this.Close();
            frm_ogr.dataGridView1.DataSource = ogrman.OgrenciListele();
            MessageBox.Show(SilSonuc);
        }
    }
}
