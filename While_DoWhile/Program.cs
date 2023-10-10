<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace While_DoWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // While ciklus:

            // Addig akarod futtatni ameddig egy feltétel igaznak minősül.
            // pl.: Ki akarjuk iratni a páratlan számokat.

            int INDEX = 1;
            while (INDEX <= 10)
            {
                if (INDEX % 2 == 0)
                {
                    INDEX++;
                    continue;
                }

                if (INDEX == 9) break;
                Console.WriteLine(INDEX);
                INDEX++;

            }


            // Do while ciklus:

            // Akkor fogod használni amikor legalább egyszer muszály lefuttatnod a kódot.
            // Ez egy hátultesztelős ciklus vagyis akkor is le fog futni a kód első alkalommal ha a feltétel hamis.
            // Először a törzse fut le majd a feltétel megnézése.

            Random rnd = new Random();
            int titkosSzam = rnd.Next(1, 11);
            int szamTalalt = 0;
            Console.WriteLine("Random szám: {0}", titkosSzam);

            do
            {
                Console.WriteLine(titkosSzam);
                Console.Write("Üss be egy számot 1 és 11 között:");
                szamTalalt = int.Parse(Console.ReadLine());

            } while (titkosSzam != szamTalalt);

            Console.WriteLine("Eltaláltad a számot. {0}", titkosSzam);

            Console.ReadKey();
        }
    }
}
        
    
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace While_DoWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // While ciklus:

            // Addig akarod futtatni ameddig egy feltétel igaznak minősül.
            // pl.: Ki akarjuk iratni a páratlan számokat.

            int INDEX = 1;
            while (INDEX <= 10)
            {
                if (INDEX % 2 == 0)
                {
                    INDEX++;
                    continue;
                }

                if (INDEX == 9) break;
                Console.WriteLine(INDEX);
                INDEX++;

            }


            // Do while ciklus:

            // Akkor fogod használni amikor legalább egyszer muszály lefuttatnod a kódot.
            // Ez egy hátultesztelős ciklus vagyis akkor is le fog futni a kód első alkalommal ha a feltétel hamis.
            // Először a törzse fut le majd a feltétel megnézése.

            Random rnd = new Random();
            int titkosSzam = rnd.Next(1, 11);
            int szamTalalt = 0;
            Console.WriteLine("Random szám: {0}", titkosSzam);

            do
            {
                Console.WriteLine(titkosSzam);
                Console.Write("Üss be egy számot 1 és 11 között:");
                szamTalalt = int.Parse(Console.ReadLine());

            } while (titkosSzam != szamTalalt);

            Console.WriteLine("Eltaláltad a számot. {0}", titkosSzam);

            Console.ReadKey();
        }
    }
}
        
    
>>>>>>> 983a3c25d2b03837ca9c74d1d8d18f12c09030e5
