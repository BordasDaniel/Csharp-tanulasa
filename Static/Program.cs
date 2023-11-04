<<<<<<< HEAD
﻿using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = egy módosítót használunk egy statikus tag deklarálásra, amely inkább az osztályhoz tartozik
            // bármely specifikus objektum helyett (nem kell neki objektum)

            // pl.: Számláló létrehozása amely azt számolja, hogy hány autó lett létrehozva.
            // A konstruktor is csak egy metódus.
            // Nem vagy korlátozva mezőkhöz.

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");


            // 1 lesz mind a kettő ugyanis minden autó objektumnak megvan a maga autószám mező másolata.
            // A konstruktoron belül amikor mi növeljük az autók számát minden példányban, tehát maximum 1 lesz.
            // Megoldás rá az, hogy statikus lesz a számláló.
            // Így viszont nem lehet elérni a változót objektumra hivatkozva hanem az osztályra kell.

            /*
            Console.WriteLine(car1.numberOfCars);
            Console.WriteLine(car2.numberOfCars);
            */

            Console.WriteLine(Car.numberOfCars);
            // Így mostmár ez a változó az osztályhoz tartozik és egyetlen objektumnak sincs tulajdonjoga felette.
            // Olyan mintha mind egy változón osztozkodnának.


            Car car3 = new Car("Lambo");
            Console.WriteLine(Car.numberOfCars);
            

            Car.StartRace();

            // Lehet az osztályt is statikussá tenni, így viszont nem lehet majd példányosítani.
            // pl.: Math osztály amihez nem hozunk létre objektumokat, hogy használjuk a metódusait hanem azonnal használjuk öket.
            /*
             Math math1 = new Math();
             math1.Round(3.14);

             // Helyette:
             Math.Round(3.14); 
             */

            Console.ReadKey();
        }
    }

    /* static */
    class Car
    {
        string model;
        public static int numberOfCars;

        public Car(string model)
        {
            this.model = model;
            numberOfCars++; // Amikor létrejön egy autó objektum megnő az értéke 1-el.
        }

        // Lehet metódus is statikus.
        public static void StartRace()
        {
            Console.WriteLine("The race has begun.");
        }
    }
=======
﻿using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = egy módosítót használunk egy statikus tag deklarálásra, amely inkább az osztályhoz tartozik
            // bármely specifikus objektum helyett (nem kell neki objektum)

            // pl.: Számláló létrehozása amely azt számolja, hogy hány autó lett létrehozva.
            // A konstruktor is csak egy metódus.
            // Nem vagy korlátozva mezőkhöz.

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");


            // 1 lesz mind a kettő ugyanis minden autó objektumnak megvan a maga autószám mező másolata.
            // A konstruktoron belül amikor mi növeljük az autók számát minden példányban, tehát maximum 1 lesz.
            // Megoldás rá az, hogy statikus lesz a számláló.
            // Így viszont nem lehet elérni a változót objektumra hivatkozva hanem az osztályra kell.

            /*
            Console.WriteLine(car1.numberOfCars);
            Console.WriteLine(car2.numberOfCars);
            */

            Console.WriteLine(Car.numberOfCars);
            // Így mostmár ez a változó az osztályhoz tartozik és egyetlen objektumnak sincs tulajdonjoga felette.
            // Olyan mintha mind egy változón osztozkodnának.


            Car car3 = new Car("Lambo");
            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            // Lehet az osztályt is statikussá tenni, így viszont nem lehet majd példányosítani.
            // pl.: Math osztály amihez nem hozunk létre objektumokat, hogy használjuk a metódusait hanem azonnal használjuk öket.
            /*
             Math math1 = new Math();
             math1.Round(3.14);

             // Helyette:
             Math.Round(3.14); 
             */

            Console.ReadKey();
        }
    }

    /* static */ class Car
    {
        string model;
        public static int numberOfCars;

        public Car(string model) 
        {
            this.model = model;
            numberOfCars++; // Amikor létrejön egy autó objektum megnő az értéke 1-el.
        }

        // Lehet metódus is statikus.
        public static void StartRace()
        {
            Console.WriteLine("The race has begun.");
        }
    }
>>>>>>> 6875615233be6f20d185d7782a6d4ca90ae4555c
}