using System;
using System.Collections.Generic;
using System.Linq;

namespace Random_tanulasa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Létrehozunk egy objektumot a random osztályhoz.
            // Ezen keresztül tudjuk meghívni a beépített függvényeket.
            // Random változónév = new Random();
            Random random = new Random();

            // Elérése: változónév.függvény(paraméter(ek));

            random.Next(); // Random szám generálása. Argumentum nélkül 0 és 2 millión túl generál egy számot.

            // Pl.: dobókockával való dobás 1 és 6 között:

            // Balról zárt jobbról nyílt intervallumot adunk meg.
            int num = random.Next(1, 7);
            Console.WriteLine(num);
            

            // Lehet módosítani is persze pl.: hozzáadunk még 100-at a végeredményhez:

            Console.WriteLine(random.Next(1, 7) + 100);


            // random decimális szám generálása:

            double dub = random.NextDouble(); // 0 és 1 között van a random szám argumentum nélkül.
            Console.WriteLine(dub);

            // Ha többször is kell egymás után random számot generálni ahhoz nem kell új objektumot lérehozni.
            // Elég egyszer példáányosítani majd azt újrahasználni.

            // pl.: 3 6 oldalú kockát dobunk.

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);


            Console.ReadKey();


        }
    }
}