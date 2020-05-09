using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_2
{
    public class Kisi
    {
        public string adi { get; set; }
        public string soyadi { get; set; }

        private int yas; // Değer saklaması için tanımlandı.
        public int Yas
        {
            get // Değer okunduğunda çalışır.
            {
                return yas;
            }
            set // Değer atandığında çalışır.
            {
                yas = value;
            }
        }
    }
}
// Property'nin get ve set methodları değiştirilebilir.
// Value komutu property'ye atılan değerdir ve value C#'ta anahtar bir kelimedir.