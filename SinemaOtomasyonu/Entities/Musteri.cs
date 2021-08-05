using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    public class Musteri
    {

        public int Id { get; set; }
        public string AdSoyad { get; set; }

        public long TcKimlik { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

    }
}
