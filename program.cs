using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapp
{
    public class program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new mobil();
            mobil1.Merk ="Conda";
            mobil1.Warna = "Putih";
            mobil1.Model = "Briot";
            mobil1.Jumlahpintu = "5";
            mobil1.Tahunkeluaran = "2018";
            mobil1.Kecepatan = "145km/jam";

            mobil1.Kecepatanmobil();
            mobil1.Klaksonmobil();
            mobil1.Keterangan();
        }
    }
}