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
    public partial class HogrencilerYeniKayit : Form
    {
        public HogrencilerYeniKayit()
        {
            InitializeComponent();
        }

        HOgrencilerManager ogrman = new HOgrencilerManager();

        private void HogrencilerYeniKayit_Load(object sender, EventArgs e)
        {
            ogrman.sinifyukle(comboBoxSinifi);
            ogrman.dyeriyukle(comboBoxDogumYeri);
            ogrman.kangrubuyukle(comboBoxKanGrubu);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            HOgrencilerForm frm_ogr = (HOgrencilerForm)Application.OpenForms["HOgrencilerForm"];

            string EkleSonuc=ogrman.OgrenciEkle(maskedTextBoxTC.Text,textBoxAdi.Text,textBoxSoyadi.Text,ogrman.CinsiyetSecimi(radioButtonErkek,radioButtonKadin),dateTimePickerDogumTarihi.Value,(int)comboBoxDogumYeri.SelectedValue,textBoxAdres.Text,Convert.ToDecimal(textBoxKilo.Text),Convert.ToDecimal(textBoxBoy.Text),(int)comboBoxKanGrubu.SelectedValue,(int)comboBoxSinifi.SelectedValue,1);
            frm_ogr.dataGridView1.DataSource = ogrman.OgrenciListele();
            MessageBox.Show(EkleSonuc);
        }
    }
}
