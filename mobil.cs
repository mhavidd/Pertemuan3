using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapp
{
    public class mobil
    {
        // properties
        public string Warna {get; set;}
        public string Jumlahpintu {get; set;}
        public string Merk {get; set;}
        public string Model {get; set;}
        public string Tahunkeluaran {get; set;}
        public string Kecepatan {get; set;}

        //method
        public void Kecepatanmobil()
        {
            Console.WriteLine($"Mobil {Model} melaju dengan kecepatan {Kecepatan}");
        }
        public void Klaksonmobil()
        {
            Console.WriteLine($"Mobil {Model} dengan klakson berbunyi twin twin twin");
        }
        public void Keterangan()
        {
            Console.WriteLine($"Mobil saya berwarna {Warna}, merek {Merk}, model {Model}, keluaran tahun {Tahunkeluaran}, dengan jumlah pintu sebanyak {Jumlahpintu} ");
        }

    }
}