using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    interface IBolumler
    {
        string BolumEkle(string bolumadi);
        string Bolumguncelle(int bolumlerid, string bolumadi);
        string BolumSil(int bolumlerid);
        List<Bolumler> BolumListele();
        List<Bolumler> BolumAra(string bolumadi);
    }
}
