using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Metódus_túlterhelés
{
    class Program
    {

        // Beolvassa a két számot és annak összegét adja vissza.
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Beolvassa a két szöveget és annak összegét adja vissza.
        public static string Add(string str1,string str2)
        {
            return str1 + str2;
        }


        static void Main(string[] args)
        {
            // A túlterhelés egy olyan folyamat amellyel egyetlen metódusnak több definíciót adhatunk meg.
            // Ez azt jelenti, hogy használhatjuk ugyanazt a metódus nevet két különböző dolog elvégzésére.

            // pl.: dolgok összeadása: Létrehozhatunk egy AddNumbers metódust amely számok összeadásáért felelős.
            // Szövegek összeadása azonban másképp működik szóval szükséged lesz egy új AddStrings metódusra.
            // Ezzel az a baj, hogy emlékezni kell kettő különböző metódusra amelyek ugyanazt a feladatot látják el.

            // A jobb megoldás az lenne, hogy túlterheljünk egy Add metódust így tud számokkal és szövegekkel is dolgozni.

            // Minden metódusnak van egy aláírása amely a nevéből és a paraméterlistájából áll.
            // Nem lehet két metódusnak ugyanaz az aláírása ugyanazon a scope-on belül.

            // Túlterheljük a metódust azzal, hogy ugyanazt a nevet adjuk meg egy új metódusnak mint az előzőnek de más aláírást.


            // Ugyanaz a kettő metódusnak a neve de más a paraméterlistája.
            // Mivel ez egy másik aláírás ezért megengedett.

            // Amikor megpróbáljuk elérni a metódust láthatjuk, hogy annak két változata van.
            // A megfelelőt a rendszer autómatikusan kifogja választani a paraméterktől függően.
            // Add()

            // Add(1, 2) Két szám átadásával az összeadó metódus fog lefutni.
            // Add("Hali ", "Jani") Két szöveg megadásával pedig az összefűző metódus fog lefutni.

            // Három dolog egyike fog történni amikor a rendszer megpróbálja egy túlterhelt metódus metódus melyik verzióját kell futtatni:
            // 1.: Ha van egy pontos egyezés az argumentumokkal akkor az a metódus fog lefutni.
            // 2.: Ha nincs pontos egyezés akkor a rendszer megnézi az összes lehetséges egyezést és kiválasztja azt amelyik a legkevesebb konverziót igényli.
            // 3.: Ha nincs több verzió amely ugyanannyi átalakítást igényel akkor egy hibaüzenet jelenik meg.

            int szam = Add(1, 2);
            string szoveg = Add("Hali ", "Jani");
            Console.WriteLine(szam);
            Console.WriteLine(szoveg);
            Console.ReadKey();

        }
    }
}