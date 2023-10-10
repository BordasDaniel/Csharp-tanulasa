using System;
using System.Collections.Generic;
using System.Linq;


namespace Osztályok
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = Egy csoport összefüggő kódsor.
            // Használható mint tervrajz, hogy elemeket csináljunk. (OOP)
            // Egy osztály létrehozható a Program osztályon kívül vagy egy külön c# fájlban.
            // Fájlon kívüli: View > Solution Expolorer >  jobb katt a namespacen > Add > class > c# class és nevezd el valaminek.
            // Ha használni akarjuk valamelyik metódust amely a messages osztályon belül van ahhoz létre kell hozni egy objektumot vagy statikusnak kell lennie az osztálynak.
            // Nem láthatóak ha nem publikusak.
            


            // Ez a Main metódus a Program osztályon belül van.
            // A lényege ennek, hogy egy csoportba rakja a programomat.
            // De vannak más osztályok is amelyeknek van használata:
            // pl.: Math

            Math.Round(3.14);
            Math.Abs(-3.14);
            Math.Pow(2, 3);

            // A lényege a Math osztálynak, hogy tartalmazzon egy csomó hasznos metódust amelynek köze van a matekhoz.

            // Egy metódus hívása: osztály.metódus();

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }

    // Ez a fájlon belüli class.
    // Egy osztály amely üzenetekről szól.

    /*
    class Messages
    {
        void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program!");
        }


        void Waiting()
        {
            Console.WriteLine("I am waiting for someting!");
        }

        void Bye()
        {
            Console.WriteLine("Thanks for visiting!");
        }

    }
    */

}