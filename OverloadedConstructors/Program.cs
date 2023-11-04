using System;

namespace OverloadedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = Egy teknika, hogy létreohzzunk többféle konstruktort is.
            // Különböző paraméterekkel.
            // Így minden objektumnak sajátos mérete lehet.
            // név + paraméterek = aláírás
            // Minden konstruktornak egyedi aláírással kell rendelkeznie úgy mint a metódus túlterhelésnél.
            
            // Pl.: Pizza feltéttel:

            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
            
            // Pizza feltét nélkül:
            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "mozzarella");

            // Pizza sajt nélkül:
            Pizza pizza3 = new Pizza("stuffed crust", "red sauce");

            // Pizza szósz nélkül:
            Pizza pizza4 = new Pizza("stuffed crust");


            Console.ReadKey();
        }
    }
    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(string bread)
        {
            this.bread = bread;
        }
    }

}