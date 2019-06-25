using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    class SinifManager : ISinif
    {
        OkulSabahDBEntities db = new OkulSabahDBEntities();

        public void Ara(string aranacak_kelime)
        {
            throw new NotImplementedException();
        }

        public void Filtrele(string isim)
        {
            throw new NotImplementedException();
        }

        public void Filtrele(string isim, string sinif_subesi)
        {
            throw new NotImplementedException();
        }

        public void Filtrele(string isim, string sinif_subesi, string sinif_No)
        {
            throw new NotImplementedException();
        }

        public string sinifEkle(string sinif_subesi, int ogretmen_Id, int bolum_Id)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(sinif_subesi))
                {
                    Sınıflar sinifayni = db.Sınıflar.Where(k => k.SinifSubesi == sinif_subesi).FirstOrDefault();
                    if (sinifayni == null)
                    {
                        Sınıflar ekle = new Sınıflar();
                        ekle.SinifSubesi = sinif_subesi;
                        ekle.BolumID = bolum_Id;
                        ekle.OgretmenID = ogretmen_Id;

                        db.Sınıflar.Add(ekle);
                        if (db.SaveChanges() > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme başarısız";
                    }
                    return "Aynı Sınıf Şubesi var";
                }
                return "Boşlukları Doldurun";
            }
            catch (Exception)
            {
                return "Hata var Yetkiliye Bildirin";
            }
        }

        public string sinifGuncelle(int siniflar_Id, string sinif_subesi, int ogretmen_Id, int bolum_Id)
        {
            try
            {
                if (siniflar_Id > 0)
                {
                    if (!string.IsNullOrWhiteSpace(sinif_subesi))
                    {
                        DialogResult guncelonay = MessageBox.Show("Güncellemek istediğinizden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (guncelonay == DialogResult.Yes)
                        {
                            //update Sınıflar set SınıfSubesi='Lise-1',Sınıfno=12 where SınıflarID=1015
                            Sınıflar guncelle = db.Sınıflar.Where(k => k.SiniflarID == siniflar_Id).FirstOrDefault();
                            guncelle.SinifSubesi = sinif_subesi;
                            guncelle.OgretmenID = ogretmen_Id;
                            guncelle.BolumID = bolum_Id;
                            if (db.SaveChanges() > 0)
                            {
                                return "Başarılı";
                            }
                            return "Başarısız";
                        }
                        return "İşleminiz iptal edildi";
                    }
                    return "Sinif Şubesi  boş bırakmayın";
                }
                return "Lütfen Seçim yapınız";
            }
            catch (Exception)
            {
                return "Hata var Yetkiliye haber verin";
            }
        }

        public List<Sınıflar> SinifListele()
        {
            //generic list ile çağrılan sınıf tablosu mutlaka geriye dönüş değer içinde bir list ile belirtilmelidir
            return db.Sınıflar.ToList();
        }

        public string SinifSilme(int siniflar_Id)
        {
            try
            {
                Sınıflar sil = db.Sınıflar.Where(k => k.SiniflarID == siniflar_Id).FirstOrDefault();

                if (sil != null)
                {
                    DialogResult silmesaj = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (silmesaj == DialogResult.Yes)
                    {

                        db.Sınıflar.Remove(sil);
                        if (db.SaveChanges() > 0)
                        {
                            return "Silme Başarılı";
                        }
                        return "Silme Başarısız";
                    }
                    return "İşlem İptal Edildi";
                }
                return "Seçim Yapılamadı";
            }
            catch (Exception)
            {
                return "Hata Yetkiliye Bildirin";
            }
        }
    }
}
