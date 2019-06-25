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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OkulSabahDBEntities db = new OkulSabahDBEntities(); 

        SinifManager sinman = new SinifManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(0); // pencere konumu 0 ladık

            //Öğretmenleri Combobox a yüklenmesi
            //comboBoxOgretmeni.Text = "resul";

            comboBoxOgretmeni.DisplayMember = "OgretmenAdi"; // çekmek istenilen ismin kolonuadının  aynısı olmalı
            comboBoxOgretmeni.ValueMember = "OgretmenlerID";// çekilmek istenen ID değeri yazılır
            comboBoxOgretmeni.DataSource = db.Ogretmenler.ToList();


            //Bölümlerin ComboBox a yüklenmesi
            comboBoxBolumu.DisplayMember = "BolumAdi"; //kullanıcı için
            comboBoxBolumu.ValueMember = "BolumlerID"; //kodcu için
            comboBoxBolumu.DataSource = db.Bolumler.ToList();

            dataGridView1.DataSource = sinman.SinifListele();
            dataGridView1.Columns["Ogretmenler"].Visible = false;//kolonları gizledik
            dataGridView1.Columns["Bolumler"].Visible = false;
            dataGridView1.Columns["Ogrenciler"].Visible = false;
            dataGridView1.Columns["SiniflarID"].Width = 65; //kolonunun genişliği
            dataGridView1.Columns["OgretmenID"].Width = 82;
            dataGridView1.Columns["BolumID"].Width = 60;
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            //Sınıflar ekle = new Sınıflar();
            //ekle.SınıfNo = textBoxSinifNo.Text;
            //ekle.SınıfSubesi = textBoxSinifSubesi.Text;
            //ekle.BolumID = (int)comboBoxBolumu.SelectedValue;
            //ekle.OgretmenID = (int)comboBoxOgretmeni.SelectedValue;
            //db.Sınıflar.Add(ekle);
            //if(db.SaveChanges()>0)
            //{
            //    MessageBox.Show("Ekleme Başarılı");
            //}
            //else
            //{
            //    MessageBox.Show("Ekleme başarısız");
            //}

            //yukardaki kod alanında yazılan kodları SinifManager class ına alacağız, bu kodlar lazım olduğunda class ın içindeki metodu çağıracağız
            string EkleSonuc = sinman.sinifEkle(textBoxSinifSubesi.Text, (int)comboBoxOgretmeni.SelectedValue, (int)comboBoxBolumu.SelectedValue);
            dataGridView1.DataSource = sinman.SinifListele();
            MessageBox.Show(EkleSonuc);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string GunSonuc = sinman.sinifGuncelle(Siniflar_Id, textBoxSinifSubesi.Text, (int)comboBoxOgretmeni.SelectedValue, (int)comboBoxBolumu.SelectedValue);
            dataGridView1.DataSource = sinman.SinifListele();
            MessageBox.Show(GunSonuc);
        }

        int Siniflar_Id;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxSinifSubesi.Text = dataGridView1.CurrentRow.Cells["SinifSubesi"].Value.ToString();
            //Öğretmene tıklayınca ID değeri gelmektedir bizimi bu ID derğini alıp veritabanında eşleşen Öğretmeni adını getirip ComboBox ın içine atmamız gerekli
            //comboBoxBolumu.Text=
            //MessageBox.Show(dataGridView1.CurrentRow.Cells["OgretmenID"].Value.ToString());
            int Ogretmen_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["OgretmenID"].Value.ToString());
            //int Ogretmen_ID = (int)dataGridView1.CurrentRow.Cells["OgretmenID"].Value;   //aynı 
            
            comboBoxOgretmeni.Text = db.Ogretmenler.FirstOrDefault(k => k.OgretmenlerID == Ogretmen_ID).OgretmenAdi;
            //comboBoxOgretmeni.Text = db.Ogretmenler.Where(k => k.OgretmenlerID == Ogretmen_ID).FirstOrDefault().OgretmenAdi;// aynı

            //Bölüme tıklanınca gelen Id değerine göre veritabanından Bölümler tablosunda o bölümü getirelim
            int bolum_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BolumID"].Value);
            comboBoxBolumu.Text = db.Bolumler.FirstOrDefault(b => b.BolumlerID == bolum_ID).BolumAdi;
            //***********************
            //Güncelleme ve silme için sınıflarID değerine ihtiyaç
            Siniflar_Id = (int)dataGridView1.CurrentRow.Cells["SiniflarID"].Value;
            //ID değerini test amaçlı bir mesaagebox atıp gelip gelmediğini deneyebiliriz.
            //MessageBox.Show(Siniflar_Id.ToString(););
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            //rowheadervisible. true yapılırsa datagridvievin sol tarafınaki boşlukluğu siler
            //witdh ise genişliği

            string SilSonuc = sinman.SinifSilme(Siniflar_Id);
            dataGridView1.DataSource = sinman.SinifListele();
            MessageBox.Show(SilSonuc);
        }
    }
}
