using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
namespace SinemaOOPsiz
{
    public class Json
    {
        public void JsonYaz(string ad, string salon)
        {
            List<data> _data = new List<data>();
            Console.WriteLine("Bilet Alan Müşterinin İsmi");
            string isim = Console.ReadLine();
            _data.Add(new data()
            {
                Musteri = isim,
                FilmAd = ad,
                SalonAd = salon,
                Saat = DateTime.Now

            });

            string json = JsonSerializer.Serialize(_data);


            string _path = @"C:\Users\emira\Desktop\" + isim + ".json";
            File.WriteAllText(_path, json);
            Console.WriteLine($"Bilet Başarıyla {isim} Kişisine Satıldı.");
        }


    }
}
