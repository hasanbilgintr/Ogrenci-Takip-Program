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
    public partial class HOgrencilerForm : Form
    {
        public HOgrencilerForm()
        {
            InitializeComponent();
        }
        OkulSabahDBEntities db = new OkulSabahDBEntities();
        HOgrencilerManager ogrman = new HOgrencilerManager();
        private void HOgrencilerForm_Load(object sender, EventArgs e)
        {
            Location = new Point(0);
            ogrman.loaddatagridviewal(dataGridView1);
        }
       
        public int ogr_id;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            HOgrencilerGuncelleForm Guncelformu = new HOgrencilerGuncelleForm();

            ogr_id = (int)dataGridView1.CurrentRow.Cells["OgrencilerID"].Value;
            Ogrenciler sonuc = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == ogr_id); //var veri türüde da olur
            Guncelformu.ogrenciID = ogr_id;

            try
            {
                Guncelformu.maskedTextBoxTC.Text = dataGridView1.CurrentRow.Cells["OgrenciTC"].Value.ToString();
            }
            catch (Exception)
            {
                Guncelformu.maskedTextBoxTC.Text = "";
            }
            try
            {
                Guncelformu.textBoxAdi.Text = dataGridView1.CurrentRow.Cells["OgrenciAdi"].Value.ToString();
            }
            catch (Exception)
            {
                Guncelformu.textBoxAdi.Text = "";
            }

            try
            {
                Guncelformu.textBoxSoyadi.Text = dataGridView1.CurrentRow.Cells["OgrenciSoyadi"].Value.ToString();
            }
            catch (Exception)
            {
                Guncelformu.textBoxSoyadi.Text = "";
            }

            try
            {
                string Csecim = dataGridView1.CurrentRow.Cells["Cinsiyeti"].Value.ToString();
                if (Csecim == "Kadın" || Csecim == "kadın")
                {
                    Guncelformu.radioButtonKadin.Checked = true;
                }
                else if (Csecim == "Erkek" || Csecim == "erkek")
                {
                    Guncelformu.radioButtonErkek.Checked = true;
                }
            }
            catch (Exception)
            {
                Guncelformu.radioButtonErkek.Checked = false;
                Guncelformu.radioButtonKadin.Checked = false;
            }

            try
            {
                Guncelformu.dateTimePickerDogumTarihi.Text = dataGridView1.CurrentRow.Cells["DogumTarihi"].Value.ToString();
            }
            catch (Exception)
            {
                Guncelformu.dateTimePickerDogumTarihi.Text = "1.1.1990";
            }

            //combobaxların katagorileri yüklemek için ya burda yada atıcağı pencerede yapabiliriz ama öncelikle katogorileri sonra verilerini combolabox.text lerine vermek zorundayız kategoriler bir yöntemi varda verilerini yollamanın 
            //1.yöntem
            Guncelformu.comboBoxDogumYeri.DataSource = db.iller.ToList();  //classa atılabilir//atamadım:D
            Guncelformu.comboBoxDogumYeri.DisplayMember = "ilAdi";
            Guncelformu.comboBoxDogumYeri.ValueMember = "illerID";

            //string dyeri = dataGridView1.CurrentRow.Cells["DogumYeri"].Value.ToString();
            //var dyerisonuc = db.iller.FirstOrDefault(k => k.ilAdi == dyeri);
            //Guncelformu.comboBoxDogumYeri.Text = db.iller.FirstOrDefault(k => k.ilAdi == dyerisonuc.ilAdi).ilAdi;

            // yada 
            //string dyeri = dataGridView1.CurrentRow.Cells["DogumYeri"].Value.ToString();
            //Guncelformu.comboBoxDogumYeri.Text = db.iller.FirstOrDefault(k => k.ilAdi == dyeri).ilAdi;

            //yada           ogrenciID den daha iyi öncelikle an başa satırın ogrencilerIDsi bir değişkene atanır ardından alınan değerle db den ogrencilerden ogrencilerID ile karşılatırır bunuda ogrenciler yada var veri türüne eşitler son ra bu
            try
            {
                Guncelformu.comboBoxDogumYeri.Text = db.iller.FirstOrDefault(k => k.illerID == sonuc.DogumYeriID).ilAdi;
            }
            catch (Exception)
            {
                Guncelformu.comboBoxDogumYeri.Text = "";
            }

            //2.Yöntem
            //burda kategorileri tanımlayıp diğer formda verini itama vs olabilir
            Guncelformu.comboBoxSinifi.DataSource = db.Sınıflar.ToList();  
            Guncelformu.comboBoxSinifi.DisplayMember = "SinifSubesi";
            Guncelformu.comboBoxSinifi.ValueMember = "SiniflarID";
            
            Guncelformu.ShowDialog();
        }

        private void textBoxTCAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ogrman.OgrenciAra(textBoxTCAra.Text);
        }

        private void buttonYeniKayit_Click(object sender, EventArgs e)
        {
            HogrencilerYeniKayit frm_yeni = new HogrencilerYeniKayit();
            frm_yeni.ShowDialog();
        }

    }
}
