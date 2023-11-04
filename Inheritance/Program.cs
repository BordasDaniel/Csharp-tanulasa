using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // öröklés = 1 vagy több gyerekosztály megkapja a mezőket, metódusokat, stb.. a szülő osztálytól.
            // A szülő osztályoknak lehetnek gyerek osztályai és bármilye ami a szülő osztálynak van az most már a gyerek osztálynak is lesz.
            // A lényege ennek, hogy újra lehet használni a kódot.
            // Objektumok létrehozása
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // pl.: Mivel a Car osztály a Vehicle osztály gyereke ezért minden metódusához illetve mezőjéhez von hozzáférési engedélye.
            // Annak ellenére, hogy a kódban a Car osztálynak csak a wheels van megadva.
            Console.WriteLine(car.speed); // A Vehicle osztályban meg lett határozva az értéke 0-ra.
            car.speed = 20; // De meg lehet változtatni és ez nincs hatással a szülő osztályra.
            Console.WriteLine(car.speed);
            Console.WriteLine(vehicle.speed); // Ugyanúgy 0 maradt a Vehicle osztálynak míg a Car osztálynak 20.
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
        // Ezt az int speed-et illetve a go() metódust tudjuk örökölni a Vehicle avagy a szülő osztályból.
    }
    // Gyerek osztályok létrehozása:
    // class GyerekOsztályNeve : SzülőOsztályNeve
    // Így a gyerek osztálynak van hozzáférése a szülő osztály mezőihez illetve a metódusaihoz.
    // Bármit hozzá lehet adni a gyerek osztályhoz.

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }

}