using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    public class HOgrencilerManager : IHOgrenciler
    {
        OkulSabahDBEntities db = new OkulSabahDBEntities();

        public List<vw_OgrenciBilgileri> OgrenciAra(string tc)
        {
            db = new OkulSabahDBEntities();
            return db.vw_OgrenciBilgileri.Where(k => k.OgrenciTC.Contains(tc)).ToList();
        }

        public string OgrenciEkle(string Tc, string ad, string soyad, string cinsiyet, DateTime dtarih, int dyeriid, string adres, decimal kilo, decimal boy, int kanid, int sinifid, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Tc) && !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad))
                {
                    Ogrenciler aynitc = db.Ogrenciler.FirstOrDefault(k => k.OgrenciTC == Tc);
                    if (aynitc == null)
                    {
                        Ogrenciler ogrekle = new Ogrenciler();
                        ogrekle.OgrenciTC = Tc;
                        ogrekle.OgrenciAdi = ad;
                        ogrekle.OgrenciSoyadi = soyad;
                        ogrekle.Cinsiyeti = cinsiyet;
                        ogrekle.DogumTarihi = dtarih;
                        ogrekle.DogumYeriID = dyeriid;
                        ogrekle.Adres = adres;
                        ogrekle.OgrenciKilo = kilo;
                        ogrekle.OgrenciBoy = boy;
                        ogrekle.KanGrubuID = kanid;
                        ogrekle.SinifID = sinifid;
                        ogrekle.KullaniciID = kullaniciid;

                        db.Ogrenciler.Add(ogrekle);
                        if (db.SaveChanges() > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme Başarısız";
                    }
                    return "Aynı Tc li var";
                }
                return "Tc, Ad ve Soyad Boş Bırakmayınız";
            }
            catch (Exception)
            {
                return "Hata var Yetkiliye Bildirin";
            }
        }

        public string OgrenciGuncelle(int id, string Tc, string ad, string soyad, string cinsiyet, DateTime dtarih, int dyeriid, string adres, decimal kilo, decimal boy, int kanid, int sinifid, int kullaniciid)
        {
            try
            {
                //Ogrenciler Guncelle = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == id);
                if (id > 0) //if(guncelle!=null)  bölede yapılabilirdi
                            //yeni pencerede açıldığı için seçilmeme gibi şansı yok gerek yok buna aslında
                {
                    if (!string.IsNullOrWhiteSpace(Tc) && !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad))
                    {
                        DialogResult guncelonay = MessageBox.Show("Güncellemek istediğine emin misiniz", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (guncelonay == DialogResult.Yes)
                        {
                            Ogrenciler Guncelle = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == id);
                            Guncelle.OgrenciTC = Tc;
                            Guncelle.OgrenciAdi = ad;
                            Guncelle.OgrenciSoyadi = soyad;
                            Guncelle.Cinsiyeti = cinsiyet;
                            Guncelle.DogumTarihi = dtarih;
                            Guncelle.DogumYeriID = dyeriid;
                            Guncelle.Adres = adres;
                            Guncelle.OgrenciKilo = kilo;
                            Guncelle.OgrenciBoy = boy;
                            Guncelle.KanGrubuID = kanid;
                            Guncelle.SinifID = sinifid;
                            Guncelle.KullaniciID = kullaniciid;
                            if (db.SaveChanges() != 0)
                            {
                                return "Güncelleme Başarılı";
                            }
                            return "Güncelleme Başarısız";
                        }
                        return "İşlem İptal Edildi";
                    }
                    return "Lütfen Tc,Ad ve Soyad Boş Bırakmayınız";
                }
                return "Lütfen Seçim yapınız";
            }
            catch (Exception)
            {
                return "Hata Var YEtkiliye Bildirin";
            }
        }

        public List<vw_OgrenciBilgileri> OgrenciListele()
        {
            return db.vw_OgrenciBilgileri.ToList();
        }

        public string OgrenciSil(int ogrencilerid)
        {
            try
            {
                if (ogrencilerid != 0) //bunada gerek yok yeni pnecere olduğu için
                {
                    DialogResult MesajSil = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (MesajSil == DialogResult.Yes)
                    {
                        Ogrenciler Sil = db.Ogrenciler.FirstOrDefault(k => k.OgrencilerID == ogrencilerid);
                        db.Ogrenciler.Remove(Sil);
                        if (db.SaveChanges() != 0)
                        {
                            return "Silme Başarılı";
                        }
                        return "Silme Başarısız";
                    }
                    return "Silme İşleminizi İptal Ettiniz";
                }
                return "Lütfen Seçim yapınız";
            }
            catch (Exception)
            {
                return "Hata var Yetkiliye Bildiriniz";
            }
        }

        public string CinsiyetSecimi(RadioButton erkek, RadioButton kadin)
        {
            if (erkek.Checked == true)
            {
                return "Erkek";
            }
            else if (kadin.Checked == true)
            {
                return "Kadın";
            }
            return "";
        }

        public void loaddatagridviewal(DataGridView dataal)
        {
            dataal.DataSource = db.vw_OgrenciBilgileri.ToList();
            dataal.Columns["OgrencilerID"].Width = 70;
            dataal.Columns["OgrenciTC"].Width = 75;
            dataal.Columns["OgrenciAdi"].Width = 65;
            dataal.Columns["OgrenciSoyadi"].Width = 80;
            dataal.Columns["Cinsiyeti"].Width = 50;
            dataal.Columns["DogumTarihi"].Width = 70;
            dataal.Columns["Adres"].Width = 80;
            dataal.Columns["Sınıf"].Width = 60;
            dataal.Columns["KanGrubuAdi"].Width = 75;
            dataal.Columns["DogumYeri"].Width = 65;
            dataal.Columns["KullaniciAdi"].Width = 70;
        }

        public void sinifyukle(ComboBox cmbsinif)
        {//combobox ismi sinif yapıldı vs..
            cmbsinif.DataSource = db.Sınıflar.ToList();
            cmbsinif.DisplayMember = "SinifSubesi";
            cmbsinif.ValueMember = "SiniflarID";
        }

        public void dyeriyukle(ComboBox cmbdyeri)
        {
            cmbdyeri.DataSource = db.iller.ToList();
            cmbdyeri.DisplayMember = "ilAdi";
            cmbdyeri.ValueMember = "illerID";
        }

        public void kangrubuyukle(ComboBox cmbkangrubu)
        {
            cmbkangrubu.DataSource = db.KanGruplari.ToList();
            cmbkangrubu.DisplayMember = "KanGrubuAdi";
            cmbkangrubu.ValueMember = "KanGruplariID";
        }
    }
}
