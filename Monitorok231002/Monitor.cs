using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace asd0922
{
    class Monitor
    {
        public string marka { get; set; }
        public string tipusa { get; set; }
        public string merete { get; set; }


        public int ara { get; set; }
        public bool gamer { get; set; }
        public int brutto { get; set; }



        public Monitor(string sor)
        {
            string[] atmeneti = sor.Split(";");
            marka = atmeneti[0];
            tipusa = atmeneti[1];
            merete = atmeneti[2];
            ara = Convert.ToInt32(atmeneti[3]);
            gamer = sor.Contains("gamer");
            brutto = ara + ara / 100 * 27;
        }
        public void Kiir()
        {
            Console.WriteLine($"Gyártó: {marka}; Típus: {tipusa}; Méret: {merete}; Nettó ár: {ara}; Gamer: {gamer}");
        }
    }
}
