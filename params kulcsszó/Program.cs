namespace params_kulcsszó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // params kulcsszó = egy metódus paraméter amely átvesz változó számú argumentumokat.
            // A paraméter típusának egydimenziós listának kell lennie.
            // A pythonban a *args-hoz hasonlóan egy tömb.

            // pl.: Van egy online bolt, van egy metódus a kifizetésre, ahol összeadjuk az összeget és elmondjuk az ügyfélnek.
            // Ha az az ember ki fizet változó számú terméket akar vásárolni ahhoz egy csomó metódust kell írni.

            double total = CheckOut(3.99, 5.75, 15);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        // Ez jobb:
        static double CheckOut(params double[] prices) 
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }



        // Ez rossz!!

        /*
        static double CheckOut(double a)
        {
            return a;
        }

        static double CheckOut(double a, double b)
        {
            return a + b;
        }
        static double CheckOut(double a, double b, double c)
        {
            return a + b + c;
        }
        static double CheckOut(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
        */



    }
}