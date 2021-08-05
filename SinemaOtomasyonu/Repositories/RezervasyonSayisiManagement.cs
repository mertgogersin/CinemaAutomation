using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.Repositories
{
    class RezervasyonSayisiManagement
    {
        
        public int ToplamKayit(List<Musteri> musteriler)
        {
            return musteriler.Count;
        }
        public int ToplamKadinSayisi(List<Musteri> musteriler)
        {
            int count = 0;
            foreach (var item in musteriler)
            {
                if (item.Cinsiyet == Cinsiyet.Kadin)
                {
                    count++;
                }
            }
            return count;
        }

        public int ToplamErkekSayisi(List<Musteri> musteriler)
        {
            int count = 0;
            foreach (var item in musteriler)
            {
                if (item.Cinsiyet == Cinsiyet.Erkek)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
