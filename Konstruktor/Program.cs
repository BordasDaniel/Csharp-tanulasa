using System;

namespace Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor = Egy speciális metódus az osztályban.
            // Ugyanaz a neve mint az osztálynak.
            // Használható, hogy hozzárendeljünk a argumentumokat a mezőkhöz amikor létrehozunk egy objektumot.

            // Ha nem hozunk létre egy konstruktort akkor van egy rejtett autómatikus konstruktor ami meg lesz hívva, hogy létrehozzon egy objektumot.
            // Konstruktor létrehozása: public OsztályNeve(){ típus argumentum ... }
            // Egy objektum létrehozásához megfelelő argumentumokat kell átadni.
            // Konstruktoros objektum létrehozása: OsztályNeve EgyediAzonosító = new OsztályNeveMegint(argumentum(ok));


            // Konstruktor nélkül
            /*
            Human human1 = new Human();
            human1.name = "Rick";
            human1.age = 65;
            human1.Eat();
            human1.Sleep();
            

            Human human2 = new Human();
            human2.name = "Morty";
            human2.age = 16;
            human2.Eat();
            human2.Sleep();
            */

            // Konstruktorral:

            Human human1 = new Human("Rick", 65);
            human1.Eat();
            human1.Sleep();

            Human human2 = new Human("Morty", 16);
            human2.Eat();
            human2.Sleep();


            // Autó példa:

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            car1.Drive();

            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            car2.Drive();

            Console.ReadKey();
        }
    }
    

    class Human
    {
        public string name; // Mezők
        public int age;

        public Human(string name, int age) 
        { 
            // Mezőhöz argumentum hozzárendelése: this.Mező = argumentum;
            this.name = name;
            this.age = age;
        }  

        public void Eat()
        {
            Console.WriteLine($"{name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color) 
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }

    }

}
    
