using System;
using System.Collections.Generic;
using System.Linq;


namespace Return_kulcsszó
{
    class Program
    {

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z; // elem visszatérítés
            // return x * y; rövidebb nem muszáj változóban tárolni az értéket.
        }


        static void Main(string[] args)
        {
            // return = visszaad egy értéket oda ahonnan a metódust hívták.
            // pl.: két szám szorzata amelyeket a felhasználó ad meg.

            Console.Write("Add meg az első számot: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            double y = int.Parse(Console.ReadLine());
            double eredmeny = Multiply(x, y); // a visszatérő érték tárolása változóban.
            Console.WriteLine("Az eredményed: {0}", eredmeny);
            Console.ReadKey();
        }
    }
}