using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    public class MusteriManagement
    {
        List<Musteri> musteriler;
        public MusteriManagement( List<Musteri> _musteriler)
        {
            musteriler = _musteriler;

        }
        public List<Musteri> GetMusteriler()
        {
            return musteriler;
        }

        public void AddMusteri(Musteri musteri)
        {
            if (musteri.TcKimlik.ToString().Length < 11)
                throw new Exception("Lütfen kimlik numaranızı düzgün giriniz.");
            if (musteri.AdSoyad.Length == 0)
                throw new Exception("Lütfen isim soyad bölümünü boş bırakmayınız.");
            
            musteriler.Add(musteri);
        }
        
        public void DeleteMusteri(Musteri musteri)
        {
            musteriler.Remove(musteri);
        }
        public Musteri GetMusteriBySeatNumber(int seatNumber)
        {
            if (musteriler != null)
            {
                foreach (Musteri item in musteriler)
                {
                    if (item.Id == seatNumber)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public void UpdateMusteri(Musteri musteri, string adSoyad, string tcKimlik)
        {                 
            if (tcKimlik.Length > 11)
                throw new Exception("Lütfen kimlik numaranızı düzgün giriniz.");
            if (adSoyad.Length == 0)
                throw new Exception("Lütfen isim soyad bölümünü boş bırakmayınız.");
            DeleteMusteri(musteri);
            musteri.AdSoyad = adSoyad;
            musteri.TcKimlik = Convert.ToInt64(tcKimlik);
            AddMusteri(musteri);
        }

    }
}
