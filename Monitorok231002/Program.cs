﻿using System;
using System.IO;
using System.Collections.Generic;




namespace asd0922
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Monitor> monitorok = new List<Monitor>();
            foreach (var i in File.ReadAllLines(@"../../../monitorok.txt"))
            {
                monitorok.Add(new Monitor(i));
            };
            Console.WriteLine(monitorok.Count);
            //Lehetőleg minden kiírást a főprogram végezzen el. Próbálj minél több kódot újrahasznosítani. Minden feladatot meg kell oldani hagyományosan, és azután, ha tudod, LINQ-val is.


            //1. Hozz létre egy osztályt a monitorok adatai számára. Olvasd be a fájl tartalmát.


            //2. Írd ki a monitorok összes adatát virtuális metódussal, soronként egy monitort a képernyőre. A kiírás így nézzen ki:


            //Gyártó: Samsung; Típus: S24D330H; Méret: 24 col; Nettó ár: 33000 Ft


            //2. Tárold az osztálypéldányokban a bruttó árat is (ÁFA: 27%, konkrétan a 27-tel számolj, ne 0,27-tel vagy más megoldással.)


            //3. Tételezzük fel, hogy mindegyik monitorból 15 db van készleten, ez a nyitókészlet. Mekkora a nyitó raktárkészlet bruttó (tehát áfával növelt) értéke?            
            //Írj egy metódust, ami meghívásakor kiszámolja a raktárkészlet aktuális bruttó értékét. A főprogram írja ki az értéket.
            Console.WriteLine($"A nyitó készlet teljes bruttó ára: {KezdoAr(monitorok)} Ft");

            //4. Írd ki egy új fájlba, és a képernyőre az 50.000 Ft feletti nettó értékű monitorok összes adatát (a darabszámmal együtt) úgy,
            //hogy a szöveges adatok nagybetűsek legyenek, illetve az árak ezer forintba legyenek átszámítva.
            //Az ezer forintba átszámítást egy külön függvényben valósítsd meg.
            StreamWriter sw = new StreamWriter(
                path: @"..\..\..\DragaMonitor.txt",
                append: true,
                encoding: System.Text.Encoding.UTF8);
            foreach (var m in monitorok)
            {
                if (m.ara > 50000)
                {
                    sw.WriteLine($"{m.marka};{m.tipusa};{m.merete};{m.ara};{m.gamer};{m.brutto}");
                }
            }
            sw.Close();

            //5. Egy vevő keresi a HP EliteDisplay E242 monitort. Írd ki neki a képernyőre, hogy hány darab ilyen van a készleten.
            //Ha nincs a készleten, ajánlj neki egy olyan monitort, aminek az ára az átlaghoz fölülről közelít. Ehhez használd az átlagszámító függvényt (később lesz feladat).


            //6. Egy újabb vevőt csak az ár érdekli. Írd ki neki a legolcsóbb monitor méretét, és árát.


            //7. A cég akciót hirdet. A 70.000 Ft fölötti árú Samsung monitorok bruttó árából 5%-ot elenged.
            //Írd ki, hogy mennyit veszítene a cég az akcióval, ha az összes akciós monitort akciósan eladná.


            //8. Írd ki a képernyőre minden monitor esetén, hogy az adott monitor nettó ára a nettó átlag ár alatt van-e, vagy fölötte,
            //esetleg pontosan egyenlő az átlag árral. Ezt is a főprogram írja ki.


            //9. Modellezzük, hogy megrohamozták a vevők a boltot. 5 és 15 közötti random számú vásárló 1 vagy 2 random módon kiválasztott monitort vásárol,
            //ezzel csökkentve az eredeti készletet. Írd ki, hogy melyik monitorból mennyi maradt a boltban.
            //Vigyázz, hogy nulla darab alá ne mehessen a készlet. Ha az adott monitor éppen elfogyott, ajánlj neki egy másikat (lásd fent).


            //10. Írd ki a képernyőre, hogy a vásárlások után van-e olyan monitor, amelyikből mindegyik elfogyott (igen/nem).


            //11. Írd ki a gyártókat abc sorrendben a képernyőre. Oldd meg úgy is, hogy a metódus írja ki, és úgy is, hogy a főprogram.


            //12. Csökkentsd a legdrágább monitor bruttó árát 10%-kal, írd ki ezt az értéket a képernyőre.


            Console.ReadKey();
        }

        static int KezdoAr(List<Monitor> monitorok)
        {
            int f3 = 0;
            foreach (var m in monitorok)
            {
                f3 += m.brutto * 15;
            }
            return f3;
        }
    }
}
