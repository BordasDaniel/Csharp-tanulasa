namespace Hiba_Kezelés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exception = hibák amelyek futtatásban (közben) jelennek meg.

            // pl.: Szöveget ütünk be amikor számot kellene.

            // try = megpróbál lefuttatni egy kódsort amelyek "veszélyesek (lehet hibába ütközik a felhasználó) "
            // Használat: try { törzs }
            
            // catch = megfogja és kezeli a hibákat amikor megtörténnek.
            // Használat: try után catch (HibaTípusa RandomVáltozó(általában ex)) { törzs }
            // Ezeket lehet egymás alatt stackelni.

            // finally = mindig lefut a kódsor attól függetlenül, hogy történt-e hiba vagy sem
            // Általában fájl bezárásra használják vagy valaminek a visszaállítására.

            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: {0}", result);
            }
            catch (FormatException ex) // FormatException = nem megengedett típus
            {
                Console.WriteLine("Enter only numbers please!");
            }
            catch (DivideByZeroException ex) // DivideByZeroException = 0-val való osztás
            {
                Console.WriteLine("You can't divide by zero.");
            }
            catch (Exception ex) // Exception megfog minden hibát viszont ez nehezebbé teszi a javítását.
                                 // Nem ajánlatos önmagában használni, elvégre nem tudjuk a pontos hibát.
                                 // Érdemes először konkrét hibákra hivatkozni és utána Exception-t használni.

            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }

            Console.ReadKey();


        }
    }
}