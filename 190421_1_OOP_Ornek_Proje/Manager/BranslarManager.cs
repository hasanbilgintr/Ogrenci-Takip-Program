using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    //class oluştururken ilk işlem erişim belirleyicisi vermek olsun 
    public class BranslarManager : IBranslar
    {
        OkulSabahDBEntities DB = new OkulSabahDBEntities(); //global alan

        public List<Branslar> BransAra(string AranacakKelime)
        {
            return DB.Branslar.Where(k => k.BransAdi.Contains(AranacakKelime)).ToList();
            //BransAdi içinde Contains kodu ile arama yapılarak AranacakKelime parametresinde yer alan veride ne varsa ,içeriyorsa bütün içeren o yapıları listeleyecektir.
        }

        public List<Branslar> BransListele()
        {
            return DB.Branslar.ToList();
        }

        public string Ekle(string bransadi)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(bransadi))
                {
                    //tekrarlı ver olmasın
                    var/*Braslar da yazılabilir*/ varsaBrans = DB.Branslar.Where(k => k.BransAdi == bransadi).FirstOrDefault();//bu kod yapısını bir if karar yapısına alarak gelen değerin null olup olmadığını kontrol edeceğiz. null ise veritabanında aynı ismi taşıyan Branş olmadığı anlamına gelecektir.null'dan farklı ise aynı isimde veri tabanında Branş olduğunu gösterecektir.
                    if (varsaBrans == null)
                    {
                        //Branslar tablosunda BransAdi parametresi(Brans_Adi) nin taşıdığı veriye eşit ise
                        //entiityframwork ile eklmeme yapacağız
                        Branslar bolumekle = new Branslar();//Branslar tablosunu nesne olarak aldık
                        bolumekle.BransAdi = bransadi;
                        DB.Branslar.Add(bolumekle);
                        int sonuc = DB.SaveChanges();
                        if (sonuc > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme Başarısız";
                    }
                    return "Aynı Branş var ";
                }
                return "Lütfen Branş Adını Giriniz";
            }
            catch (Exception)
            {
                return "Branş Eklenirken hata oluştu,lütfen kontrol ediniz";
            }
        }

        public string GirisTemizle(string bransadi)
        {
            bransadi = null;
            return bransadi;
        }

        public string Guncelle(int branslarid, string bransadi)
        {
            try
            {
                Branslar update = DB.Branslar.Where(g => g.BranslarID == branslarid).FirstOrDefault();

                if (update != null)
                {
                    if (!string.IsNullOrWhiteSpace(bransadi))
                    {
                        Branslar Bransayni = DB.Branslar.FirstOrDefault(k => k.BransAdi == bransadi);
                        if (Bransayni == null)
                        {
                            DialogResult mesaj = MessageBox.Show("Güncelleme yapmak istediğinizden emin misini?", "Silme penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                            if (mesaj == DialogResult.OK)
                            {
                                update.BransAdi = bransadi;
                                if (DB.SaveChanges() > 0)
                                {
                                    return "Güncelleme Başarılı";
                                }
                                return "Güncelleme Başarısız";
                            }
                            return "Güncellemeyi İptal Ettiniz";
                        }
                        return "BransAdi Aynı var"; //farklı branşadı girin
                    }
                    return "BranşAdını Boş Bırakmayınız";
                }
                return "Seçim yapmadınız";
            }
            catch (Exception)
            {
                return "Hata var Yetkiliye Bildirin";
            }
        }

        public string Sil(int branslarid)
        {
            try
            {
                Branslar branssil = DB.Branslar.Where(f => f.BranslarID == branslarid).FirstOrDefault();

                if (branssil != null)
                {
                    DialogResult mesaj = MessageBox.Show("Silmek istediğiniziden emin misiniz?", "Silme Penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (mesaj == DialogResult.OK)
                    {
                        DB.Branslar.Remove(branssil);
                        if (DB.SaveChanges() > 0)
                        {
                            //branssil = null; //her silme işleminden soonra bu değişkenin üzerinde olan verileri temizliyoruz  
                            //gerek kalmıyo yazılmayabilir
                            return "Silme Başarılı";
                        }
                        return "Silme Başarısız";
                    }
                    return "Silme İşlemini İptal ettiniz";
                }
                return "Seçim Yapmadınız ";
            }
            catch (Exception)
            {
                return "Hata var ";
            }
        }
        //Manager class a yazılan bir metot Interface class'ına eklenme zorunluluğu yoktur fakat Interface class'a eklenen bir metot yapısı kalıtım verdiği manager class'a implement edilmek zorunda.

        public void DenemeMetot()
        {
            //bu classı Interface classta tanımlamak zorunda değiliz
        }
    }
}
