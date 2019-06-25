using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190421_1_OOP_Ornek_Proje.Manager
{
    interface IBranslar
    {
        //crud=> create ,read ,update,delete
        //arama ,filtreleme
        string Ekle(string bransadi);
        string Guncelle(int branslarid, string bransadi);
        string Sil(int branslarid);
        //listeleme içi genericList kullanacağız
        List<Branslar> BransListele();
        //Genericlist ile bir listeleme yapılacağını ve bu listelemede branslar ..........
        List<Branslar> BransAra(string AranacakKelime);
        string GirisTemizle(string bransadi);
    }
}
