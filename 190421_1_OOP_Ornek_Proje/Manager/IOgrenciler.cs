using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    interface IOgrenciler
    {
        List<vw_OgrenciBilgileri> OgrenciListesi();

        string OgrenciEkle(string tc, string adi, string soyad, string cinsiyet, DateTime dtarih, string adres, int sinif, int kangrubu, int dyeri, int kullaniciadi);

        string OgrenciGuncelle(int id, string tc, string adi, string soyad, string cinsiyet, DateTime dtarih, string adres, int sinif, int kangrubu, int dyeri, int kullaniciadi);

        string OgrenciSil(int id);

        List<vw_OgrenciBilgileri> OgrenciAra(string ad);

        List<vw_OgrenciBilgileri> SinifveCinsiyetAra(string sinif, string cinsiyet);


    }
}
