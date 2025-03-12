using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class KodeProduk
    {
        public string GetKodeProduk(string kodeproduk)
        {
            Dictionary<string, string> kode = new Dictionary<string, string>
            {
                { "Laptop", "E100" },
                { "Smartphone", "E101" },
                { "Tablet", "E102" },
                { "Headset", "E103" },
                { "Keyboard", "E104" },
                { "Mouse", "E105" },
                { "Printer", "E106" },
                { "Monitor", "E107" },
                { "Smartwatch", "E108" },
                { "Kamera", "E109" }
            };
            return kode.ContainsKey(kodeproduk) ? kode[kodeproduk] : "Kode pos tidak ditemukan";
        }
    }

}