using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    interface IHOgrenciler
    {
        List<vw_OgrenciBilgileri> OgrenciListele();

        string OgrenciEkle(string Tc, string ad, string soyad, string cinsiyet, DateTime dtarih, int dyeriid, string adres, decimal kilo, decimal boy, int kanid, int sinifid, int kullaniciid);

        string OgrenciGuncelle(int id,string Tc, string ad, string soyad, string cinsiyet, DateTime dtarih, int dyeriid, string adres, decimal kilo, decimal boy, int kanid, int sinifid, int kullaniciid);

        string OgrenciSil(int ogrencilerid);

        List<vw_OgrenciBilgileri> OgrenciAra(string tc);

        void sinifyukle(ComboBox sinif);
        void dyeriyukle(ComboBox dyeri);
        void kangrubuyukle(ComboBox kangrubu);

        void loaddatagridviewal(DataGridView dataal);

    }
}
