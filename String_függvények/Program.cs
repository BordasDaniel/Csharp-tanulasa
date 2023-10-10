<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace String_Függvények {
    public class Program
    {
        public static void Main(string[] args)
        {

            // string függvények:

            string randomString = "Ez egy szöveg.";
            Console.WriteLine("A szöveged hosszúsága: {0}", randomString.Length); // Hosszúságot adja vissza.
            Console.WriteLine("A szöveged tartalmaz: {0}", randomString.Contains("egy")); // Boolean értékkel tér vissza, megnézi, hogy tartalmazza-e a szöveg az a szót vagy karaktert.
            Console.WriteLine("Az indexe a : {0}", randomString.IndexOf("e")); // Számmal tér vissza, megnézi, hogy hányadik indexben helyezkedik el a szövegedben.
            Console.WriteLine("Szöveg eltávolítása: {0}", randomString.Remove(0, 5)); // Eltávolítja a karaktereket a megadott intervallumon belül.
            Console.WriteLine("Szöveg hozzáadása: {0}", randomString.Insert(10, "valami")); // Szöveg hozzáadása a megadott indexre.
            Console.WriteLine("Helyettesítés: {0}", randomString.Replace("egy", "hülye")); // A megadott szöveg helyére kerül be.
            Console.WriteLine("Hasonlítás A és B: {0}", string.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            //  StringComparison.OrdinalIgnoreCase kikapcsolja a kis és nagy betűs szavak között különbséget.
            // Hasonlítások és kis és nagybetűs különbségek ignorálása:
            // < 0: str1 megelőzi str2-t
            // = : 0
            // > 0 : str2 megelőzi str1-et

            Console.WriteLine("A == a: {0}", string.Equals("A", "a"));
            Console.WriteLine("A == a: {0}", string.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Jobbra: {0}", randomString.PadLeft(20, '.')); // Karakterrel való kitöltés jobbra.
            Console.WriteLine("Balra : {0}", randomString.PadRight(20, '.')); // Karakterrel való kitöltés balra. 
            Console.WriteLine("Szóköz eltávolítása : {0}", randomString.Trim()); // Szóköz eltávolítása
            Console.WriteLine("Nagybetű: {0}", randomString.ToUpper()); // Nagybetűs lesz minden karakter.
            Console.WriteLine("Kisbetűs: {0}", randomString.ToLower()); // Kisbetűs lesz minden karakter.

            string ujString = string.Format("{0} látta a {1} {2} a {3}ban", "Béci", "Józsit", "vásárolni", "Tesco"); // Szöveg formázása, kiegészítéssel.
            Console.WriteLine(ujString);
            Console.Write(ujString + "\n"); // Új sor beszúrása

            string nev2 = "Derek";
            string nev3 = "Derek";
            if (nev2.Equals(nev3, StringComparison.Ordinal)) // Két szó összehasonlítása.
            {
                Console.WriteLine("A nevek megegyeznek.");
            }
            else
            {
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace String_Függvények {
    public class Program
    {
        public static void Main(string[] args)
        {

            // string függvények:

            string randomString = "Ez egy szöveg.";
            Console.WriteLine("A szöveged hosszúsága: {0}", randomString.Length); // Hosszúságot adja vissza.
            Console.WriteLine("A szöveged tartalmaz: {0}", randomString.Contains("egy")); // Boolean értékkel tér vissza, megnézi, hogy tartalmazza-e a szöveg az a szót vagy karaktert.
            Console.WriteLine("Az indexe a : {0}", randomString.IndexOf("e")); // Számmal tér vissza, megnézi, hogy hányadik indexben helyezkedik el a szövegedben.
            Console.WriteLine("Szöveg eltávolítása: {0}", randomString.Remove(0, 5)); // Eltávolítja a karaktereket a megadott intervallumon belül.
            Console.WriteLine("Szöveg hozzáadása: {0}", randomString.Insert(10, "valami")); // Szöveg hozzáadása a megadott indexre.
            Console.WriteLine("Helyettesítés: {0}", randomString.Replace("egy", "hülye")); // A megadott szöveg helyére kerül be.
            Console.WriteLine("Hasonlítás A és B: {0}", string.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            //  StringComparison.OrdinalIgnoreCase kikapcsolja a kis és nagy betűs szavak között különbséget.
            // Hasonlítások és kis és nagybetűs különbségek ignorálása:
            // < 0: str1 megelőzi str2-t
            // = : 0
            // > 0 : str2 megelőzi str1-et

            Console.WriteLine("A == a: {0}", string.Equals("A", "a"));
            Console.WriteLine("A == a: {0}", string.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Jobbra: {0}", randomString.PadLeft(20, '.')); // Karakterrel való kitöltés jobbra.
            Console.WriteLine("Balra : {0}", randomString.PadRight(20, '.')); // Karakterrel való kitöltés balra. 
            Console.WriteLine("Szóköz eltávolítása : {0}", randomString.Trim()); // Szóköz eltávolítása
            Console.WriteLine("Nagybetű: {0}", randomString.ToUpper()); // Nagybetűs lesz minden karakter.
            Console.WriteLine("Kisbetűs: {0}", randomString.ToLower()); // Kisbetűs lesz minden karakter.

            string ujString = string.Format("{0} látta a {1} {2} a {3}ban", "Béci", "Józsit", "vásárolni", "Tesco"); // Szöveg formázása, kiegészítéssel.
            Console.WriteLine(ujString);
            Console.Write(ujString + "\n"); // Új sor beszúrása

            string nev2 = "Derek";
            string nev3 = "Derek";
            if (nev2.Equals(nev3, StringComparison.Ordinal)) // Két szó összehasonlítása.
            {
                Console.WriteLine("A nevek megegyeznek.");
            }
            else
            {
>>>>>>> 983a3c25d2b03837ca9c74d1d8d18f12c09030e5
                Console.WriteLine("A két név nem egyezik meg.");
            }


            // adatkivitel formázása:

            Console.WriteLine("Pénzérték : {0:c}", 23.455);
            Console.WriteLine("Kiegészítés 0-val : {0:d4}", 23);
            Console.WriteLine("3 decimális-ra való kerekítés : {0:f3}", 23.4555555556);
            Console.WriteLine("Tagolás : {0:n4}", 2300);
<<<<<<< HEAD
        }
    }
    

=======
        }
    }
    

>>>>>>> 983a3c25d2b03837ca9c74d1d8d18f12c09030e5
}