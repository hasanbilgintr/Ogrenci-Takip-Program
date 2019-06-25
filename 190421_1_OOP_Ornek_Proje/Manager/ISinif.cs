using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    interface ISinif
    {
        //metotla için bir plan oluşturmak 
        string sinifEkle(string sinif_subesi, int ogretmen_Id, int bolum_Id);
        //Güncelleme
        string sinifGuncelle(int siniflar_Id,string sinif_subesi, int ogretmen_Id, int bolum_Id);
        //silme
        string SinifSilme(int siniflar_Id);
        //Listeleme
        List<Sınıflar> SinifListele();
        //Listeleme kısmında GenericList kullandık generic List birden fazla yapıyı bir listede görmek amacıyla kullanılır. kullanış şekli yukarıda SinifListele metodunda olduğu gibidir.Hangi tablonun verileri listelenmek isteniyorsa <> işaretleri içinde o tablo yazılır.
        //Arama
        void Ara(string aranacak_kelime);
        //Filtreleme
        void Filtrele(string isim);
        void Filtrele(string isim, string sinif_subesi);
        void Filtrele(string isim, string sinif_subesi, string sinif_No);
    }
}
