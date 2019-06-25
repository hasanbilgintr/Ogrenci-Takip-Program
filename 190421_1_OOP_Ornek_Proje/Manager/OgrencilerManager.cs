using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    public class OgrencilerManager : IOgrenciler
    {
        OkulSabahDBEntities DB = new OkulSabahDBEntities();

        public List<vw_OgrenciBilgileri> OgrenciAra(string ad)
        {
            return DB.vw_OgrenciBilgileri.Where(l => l.OgrenciAdi.Contains(ad)).ToList();
        }

        public string OgrenciEkle(string tc, string adi, string soyad, string cinsiyet, DateTime dtarih, string adres, int sinif, int kangrubu, int dyeri, int kullaniciadi)
        {
            
            try
            {
                if (!string.IsNullOrWhiteSpace(tc) && !string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(soyad))
                {
                    Ogrenciler ogrenciayni = DB.Ogrenciler.Where(o => o.OgrenciTC == tc).FirstOrDefault();
                    if (ogrenciayni == null)
                    {
                        Ogrenciler ekleogr = new Ogrenciler();
                        ekleogr.OgrenciTC = tc;
                        ekleogr.OgrenciAdi = adi;
                        ekleogr.OgrenciSoyadi = soyad;
                        ekleogr.Cinsiyeti = cinsiyet;
                        ekleogr.DogumTarihi = dtarih;
                        ekleogr.Adres = adres;
                        ekleogr.SinifID = sinif;
                        ekleogr.KanGrubuID = kangrubu;
                        ekleogr.DogumYeriID = dyeri;
                        ekleogr.KullaniciID = kullaniciadi;

                        DB.Ogrenciler.Add(ekleogr);
                        if (DB.SaveChanges() > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme Başarısız";
                    }
                    return "Aynısı var Eklenmez";
                }
                return "Tc,Ad ve Soyad Boş Bırakma";
            }
            catch (Exception)
            {
                return "Hata Var Yetkiliye Bildiriniz";
            }
        }

        

        public string OgrenciGuncelle(int id, string tc, string adi, string soyad, string cinsiyet, DateTime dtarih, string adres, int sinif, int kangrubu, int dyeri, int kullaniciadi)
        {
            try
            {
                Ogrenciler OgrenciGuncelle = DB.Ogrenciler.Where(e => e.OgrencilerID == id).FirstOrDefault();
                if (OgrenciGuncelle != null)//id!=0 aynı yeterdi üsstekine gerek kalmazdı 
                {
                    if (!string.IsNullOrWhiteSpace(tc) && !string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(soyad))
                    {
                        DialogResult Guncellememesaj = MessageBox.Show("Guncellemek İstediğiniziden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (Guncellememesaj == DialogResult.Yes)
                        {
                            OgrenciGuncelle.OgrenciTC = tc;
                            OgrenciGuncelle.OgrenciAdi = adi;
                            OgrenciGuncelle.OgrenciSoyadi = soyad;
                            OgrenciGuncelle.Cinsiyeti = cinsiyet;
                            OgrenciGuncelle.DogumTarihi = dtarih;
                            OgrenciGuncelle.Adres = adres;
                            OgrenciGuncelle.SinifID = sinif;
                            OgrenciGuncelle.KanGrubuID = kangrubu;
                            OgrenciGuncelle.DogumYeriID = dyeri;
                            OgrenciGuncelle.KullaniciID = kullaniciadi;

                            if (DB.SaveChanges() > 0)
                            {
                                return "Güncelleme Başarılı";
                            }
                            return "Güncelleme Başarısız";
                        }
                        return "İşlem İptal Edildi"; 
                    }
                    return "Tc ,ad ve soyad boş bırakılmaz";
                }
                return "Lütfen Seçim Yapınız";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public List<vw_OgrenciBilgileri> OgrenciListesi()
        {
            DB = new OkulSabahDBEntities();
            return DB.vw_OgrenciBilgileri.ToList();
        }

        public string OgrenciSil(int id)
        {
            try
            {
                Ogrenciler OgrSil = DB.Ogrenciler.Where(q => q.OgrencilerID == id).FirstOrDefault();
                if (OgrSil != null)
                {
                    DialogResult SilmeMesaji = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (SilmeMesaji == DialogResult.Yes)
                    {
                        DB.Ogrenciler.Remove(OgrSil);
                        if (DB.SaveChanges() > 0)
                        {
                            return "Silme Başarılı";
                        }
                        return "Silm Başarısız";
                    }
                    return "İşlem İptal Edildi";
                }
                return "Seçim Yapılmadı";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public List<vw_OgrenciBilgileri> SinifveCinsiyetAra(string sinif, string cinsiyet)
        {
            return DB.vw_OgrenciBilgileri.Where(p => p.Sınıf.Contains(sinif) && p.Cinsiyeti.Contains(cinsiyet)).ToList();
        }
    }
}
