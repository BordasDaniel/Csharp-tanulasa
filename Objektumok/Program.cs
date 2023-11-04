<<<<<<< HEAD
﻿using System;

namespace Objektumok
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = egy osztály példánya
            // Egy osztályt fel lehet használni mint tervrajz hogy létrehozzunk objektumokat. (OOP)
            // Objektumoknak lehetnek mezői & metódusai (characteristics & actions)
            // Mezők = pl.: Mehatározó attribútumai annak, amit minden embernek van. (név, kor)
            // Pédányosítás: OsztályNeve ObjektumEgyediNeve = new OsztályNeveMegint();
            // A mezői és metódusai nem láthatóak ezért publicnak kell lenniük. (Vagyis publikusan elérhetők egy másik osztályból)
            // Az osztályokat többször is fel lehet használni, hogy létrehozzunk objektumokat.
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



            Console.ReadKey();
        }
    }

    class Human
    {
        public string name; // Mezők
        public int age;


        public void Eat()
        {
            Console.WriteLine($"{name} is eating.");
        }
        
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }
    }
=======
﻿using System;

namespace Objektumok
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = egy osztály példánya
            // Egy osztályt fel lehet használni mint tervrajz hogy létrehozzunk objektumokat. (OOP)
            // Objektumoknak lehetnek mezői & metódusai (characteristics & actions)
            // Mezők = pl.: Mehatározó attribútumai annak, amit minden embernek van. (név, kor)
            // Pédányosítás: OsztályNeve ObjektumEgyediNeve = new OsztályNeveMegint();
            // A mezői és metódusai nem láthatóak ezért publicnak kell lenniük. (Vagyis publikusan elérhetők egy másik osztályból)
            // Az osztályokat többször is fel lehet használni, hogy létrehozzunk objektumokat.
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



            Console.ReadKey();
        }
    }

    class Human
    {
        public string name; // Mezők
        public int age;


        public void Eat()
        {
            Console.WriteLine($"{name} is eating.");
        }
        
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }
    }
>>>>>>> 6875615233be6f20d185d7782a6d4ca90ae4555c
}