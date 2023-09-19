using System;
// using ugyanaz mint az import
// System nélkül mindenhova ki kellene rakni a System. prefixet pl.: Kiiratás
// Systemmel: Console.WriteLine("Hello world!");
// System nélkül: System.Console.WriteLine("Hello world!");


namespace Alapok_Konzol_parancsok
{
    public class Program
    {
        public static void Main(string[] args)
            // static: Letud futni a program objektum létrehozása nélkül.
            // void: A függvény nem tér vissza semmilyen értékkel.
            // string[] args: Bármilyen adat amely átlett adva a függvénynek.
        {
            // Konzol parancsok:
            Console.WriteLine("Hello world!"); // Kiiratás.
            Console.ForegroundColor = ConsoleColor.Black; // A szöveg színének megváltoztatása.
            Console.BackgroundColor = ConsoleColor.White; // A szöveg mögötti háttér szín megváltoztatása.
            Console.Clear(); // Az egész console ablak tisztítása valamint a színmódosítások végrehajátása mindenen.
            Console.WriteLine("Hello world!");
            Console.Write("Mi a neved? "); // A ...WriteLine-al ellentétben ez nem kezd új sort mindig a szöveg után hanem a következőt vele egy sorba teszi.
            string nev = Console.ReadLine(); // Adat beolvasása a felhasználótól.
            Console.WriteLine($"Hello {nev}"); // $"szöveg": fullstring, vagyis minden beleírt szöveg string formátumú lesz.
                                               // Nem kell + jelt tenni ha hozzá akarunk fűzni egy változót helyette a {változó neve} szintaxist használjuk.
                                               // $ nélkül: Console.WriteLine("Hello " + nev);

        }
    }
}