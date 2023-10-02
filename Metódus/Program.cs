namespace Metódus
{
    public class Program
    {

        // Nem muszáj ugyanannak lennie a névnek amikor átveszi az argumentumokat.
        static void enekles(string birthdayBOY, int YearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear {0}!", birthdayBOY);
            Console.WriteLine("You are {0} years old!", YearsOld);
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("--------------");
        }

        static void Main(string[] args)
        {
            // metódusok = a kód bizonyos részéért felelnek amikor meghívják
            // előnyei = újrahasználható programsorok és egyszerűen karbantarthatók
            // létrehozás: ( a Main függvényen kívül) static visszatérési érték (ha nincs akkor void) metódus neve( argumentum típusa argumentum(ok)){ törzs }
            // hívása: függvényneve( argumentum(ok) ha van(nak) )


            // pl.: Énekeljünk boldog szülinapot háromszor angolul.


            // Metódus használata nékül ki kell írnunk háromszor.

            /*
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear you!");
            Console.WriteLine("Happy birthday to you!");

             Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear you!");
            Console.WriteLine("Happy birthday to you!");

             Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear you!");
            Console.WriteLine("Happy birthday to you!");
            */

            // hívás

            string név = "Jani";
            int kor = 21;

            // Mivel a metódusok csak az látják ami a kódsorukon belül van ezért át kell adni neki az értéket mint argumentum.

            enekles(név, kor); 
            enekles(név, kor); 
            enekles(név, kor);


            


        }
    }
}