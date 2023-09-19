using System;
using System.Collections.Generic;
using System.Linq;

namespace Tomb
{
    public class Program
    {

        // -------- Függvény kezd ------------
        // szintaxis : típus visszatérési érték(void == semmi, vagyis eljárás lesz) név(paraméterek) { törzs }

        static void TombKiiratasa(int[] intArray, string mess)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, i);
            }
        }


        // -------- Függvény vége ------------

        public static void Main(string[] args)
        {
            // Tömbök:

            // Dobozok a dobozban amelyek különböző értékeket tartalmaznak ugyanazon típusból.
            // Minden érték index vagy kulcs alapján érhető el.
            // Fix méretűek (előre meg kell határozni)
            // A kezdő index 0.
            // Számok []-ban, szövegek {}ben vannak.
            // Szintaxis: típus[] változó neve = new típus[mennyiség]


            int[] kedvencSzamok = new int[3];
            kedvencSzamok[0] = 23;
            Console.WriteLine("Kedvenc számok 0. indexének értéke: {0}", kedvencSzamok[0]);

            string[] vasarlokNeve = { "Bob", "Sally", "Suzy" };
            var dolgozok = new[] { "Mike", "Paul", "Rick" };
            // A var engedélyezi bármely típus használatát értékadáskor, tömbök esetén ez azt jelenti, hogy lehet vegyes is a tömb.

            // Tömb alap objektumokkal, amely alaptípusa a különböző típusoknak.
            // Bármilyen adatottípust tartalmazhat.
            object[] randomTomb = { "Paul", 45, 1.234 };
            Console.WriteLine("randomTomb 0: {0}", randomTomb[0].GetType());
            Console.WriteLine("Tömb hossza: {0}", randomTomb.Length); // Tömb hosszának lekérése.

            int[] randomszmok = { 0, 1, 4, 9, 2 };

            Array.Sort(randomszmok); // Tömb szortírozása
            Array.Reverse(randomszmok); // Tömb fordított sorrendben
            Console.WriteLine("1 indexnél : {0}", Array.IndexOf(randomszmok, 1));
            randomszmok.SetValue(0, 1); // Érték felcserélése egy indexnél

            int[] scrTomb = { 1, 2, 3 };
            int[] desTomb = new int[2];
            int KezdIndex = 0;
            int Hossz = 2;
            Array.Copy(scrTomb, KezdIndex, desTomb, 0, Hossz); // Tömb tartalmának másolása egy másikba.
            TombKiiratasa(desTomb, "Másolás");

            Array masikTomb = Array.CreateInstance(typeof(int), 10); // Tömb létrehozása másik módon.
            scrTomb.CopyTo(masikTomb, 5); // 5db ,,0" lesz benne mivel az 5. indextől fogja elkezdeni másolni.


            // Több dimenziós tömb:

            // Amikor deklarálsz egy tömböt, akkor tulajdonképpen azt mondod, hogy dobozokat akarsz csinálni amelyek egymás hegyén hátán vannak vertikálisan.
            // Amikor egy többdimenziós listát definiálsz akkor sorokat fogsz létrehozni.

            string[,] nevek = new string[2, 2]
            { // [sor/oszlop]
                { "Bob", "Smaith" },
                { "Sally", "Smith"}
            };

            Console.WriteLine("MD Érték : {0}", nevek.GetValue(1, 0)); // Érték lekérése több dimenziós listából. (HányadikTömb, HanyadikEleme)

            for (int i = 0; i < nevek.GetLength(0); i++)
            {
                for (int j = 0; j < nevek.GetLength(0); j++)
                {
                    Console.WriteLine("{0}\n", nevek[i, j]);
                }
            }

            

            // For ciklus:

            // Bejárja a tömböt.
            // Szintaxis : 
            // for (int i = INDEX(általában 0 szokott lenni); feltétel; i++ vagy i-- (számláló növelése vagy csökkentése){ törzs }

            for (int i = 0; i < randomTomb.Length; i++)
            {
                Console.WriteLine("Tömb: {0} : Érték : {1}", i, randomTomb[i]);
            }


            // foreach ciklus:

            // Bejárja a listát úgy, hogy egyenként felveszi az értékét annak az elemnek.
            // Szintaxis: típus i in lista { törzs }

            foreach (int i in masikTomb)
            {
                Console.WriteLine("Másolás2 : {0}", i);
            }

            TombKiiratasa(randomszmok, "ForEach");
        }
    }
}