namespace Feltételes_operátor_avagy_hármas_operátor
{
    class Program
    {
        static void Main(string[] args)
        {
            // feltételes operátor = használt feltételes hozzárendelésben ha a feltétel igaz/hamis
            // Használat: (feltétel) ? HaIgaz : HaHamis
            // Nem tartalmazhat olyan elemeket amelyeknek a végén pontosvessző van pl.: Console.WriteLine();
            // Az állítástól függően a true vagy false-ban megfogalmazott értékkel tér vissza.


            // pl.: más üzenet a hőmérséklet alapján

            double temperature = 20;
            string message;

            // if, else -vel

            if (temperature >=  15) 
            {
                message = "It's warm outside";
            }
            else
            {
                message = "It's cold outside";
            }

            Console.WriteLine(message);

            // Rövidítve feltételes operátorral:

            temperature = 10;

            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";

            Console.WriteLine(message);

            // Még jobban rövidítve:

            temperature = 20;

            Console.WriteLine((temperature >= 15) ? "It's warm outside" : "It's cold outside");

            Console.WriteLine("The temperature outside is: {0}.", (temperature > 0)? "Good": "Bad");


            Console.ReadKey();
        }
    }
}