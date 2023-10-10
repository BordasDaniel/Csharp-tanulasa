using System;
using System.Collections.Generic;
using System.Linq;


namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = egy adatszerkezet amely egy listányi objektumot tartalmaz amelyeket index alapján lehet elérni.
            // Hasonló egy tömbhöz, de tud dinamikusan csökkenni/nőni méretileg.
            // using System.Collections.Generic; szükséges hozzá
            // Használat: List<típus> név = new List<típus>();

            // Tömb használatával:

            string[] food = new string[3];

            food[0] = "pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";
            // food[3] = "fries"; // Hibát eredményez mivel nem lehet megváltoztatni egy tömb hosszát.


            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            // Lista használatáva:

            List<string> foods = new List<string>();

            foods.Add("pizza"); // Elem hozzáadása a listához.
            foods.Add("hamburger");
            foods.Add("hotdog");
            foods.Add("fries");

            Console.WriteLine(foods[0]); // Egy elem elérése.

            foods.Remove("fries"); // Elem eltávolítása érték alapján.
            foods.Remove(foods[0]); // Elem eltávolítása index alapján.

            foods.Insert(0, "sushi"); // Elem beszúrása egy megadott indexre.

            Console.WriteLine(foods.Count()); // Lista hosszának lekérése.

            Console.WriteLine(foods.IndexOf("pizza")); // Elem indexének lekérése.

            foods.Insert(0, "fries");
            foods.Add("fries");

            Console.WriteLine(foods.LastIndexOf("fries")); // Egy elem utolsó indexének lekérése.

            Console.WriteLine(foods.Contains("pizza")); // Megnézi, hogy tartalmazza-e az elemet a lista.

            foods.Sort(); // Rendezés
            foods.Reverse(); // Fordított sorrend.

            foods.Clear(); // Üres listát eredményez.

            string[] foodArray = foods.ToArray(); // Egy listából tömböt csinál.

            foreach (string item in foods)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}