using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    class BolumlerManager : IBolumler
    {
        OkulSabahDBEntities DB = new OkulSabahDBEntities();

        public List<Bolumler> BolumAra(string bolumadi)
        {
            return DB.Bolumler.Where(o => o.BolumAdi.Contains(bolumadi)).ToList();
        }

        public string BolumEkle(string bolumadi)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(bolumadi))
                {
                    Bolumler Bolumayni = DB.Bolumler.Where(k => k.BolumAdi == bolumadi).FirstOrDefault();
                    if (Bolumayni == null)
                    {
                        Bolumler bekle = new Bolumler();
                        bekle.BolumAdi = bolumadi;
                        DB.Bolumler.Add(bekle);
                        if (DB.SaveChanges() > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme Başarısız";
                    }
                    return "Aynısı var";
                }
                return "Bölüm Adını doldurun";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public string Bolumguncelle(int bolumlerid, string bolumadi)
        {
            try
            {
                Bolumler bolguncel = DB.Bolumler.Where(h => h.BolumlerID == bolumlerid).FirstOrDefault();
                if (bolguncel != null) //if(bolumlerid!=0)
                {
                    if (!string.IsNullOrWhiteSpace(bolumadi))
                    {
                        Bolumler bolumayni = DB.Bolumler.Where(k => k.BolumAdi == bolumadi).FirstOrDefault();
                        if (bolumayni == null)
                        {
                            DialogResult guncelle_mesaj = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (guncelle_mesaj == DialogResult.Yes)
                            {
                                bolguncel.BolumAdi = bolumadi;
                                if (DB.SaveChanges() > 0)
                                {
                                    return "Güncelleme Başarılı";
                                }
                                return "Güncelleme Başarısız";
                            }
                            return "İşleminiz iptal edildi";
                        }
                        return "BolumAdi Ayınısı var";
                    }
                    return "Bolum Adini Boş Bırakmayınız";
                }
                return "Seçim Yapmadınız";
            }
            catch (Exception)
            {
                return "hata var";
            }
        }

        public List<Bolumler> BolumListele()
        {
            return DB.Bolumler.ToList();
        }

        public string BolumSil(int bolumlerid)
        {
            try
            {
                Bolumler bolumsil = DB.Bolumler.Where(l => l.BolumlerID == bolumlerid).FirstOrDefault();

                if (bolumsil != null)
                {
                    DialogResult silmesaj = MessageBox.Show("Silmek Sitediğinizden emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (silmesaj == DialogResult.Yes)
                    {
                        DB.Bolumler.Remove(bolumsil);
                        if (DB.SaveChanges() > 0)
                        {
                            return "Silme Başarılı";
                        }
                        return "Silme Başarısız";
                    }
                    return "İşlemi iptal ettiniz";
                }
                return "Seçim Yapmadınız";
            }
            catch (Exception)
            {
                return "hata var";
            }
        }
    }
}
