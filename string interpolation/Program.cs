namespace string_interpolation
{
   class Program
    {
        static void Main(string[] args)
        {
            // string interpolation avagy szöveg beszúrás = Megengedi, hogy beszúrjunk egy változót egy szöveg literálba kapcsos zárójelek között.
            // string literál létrehozása: $ az elején pl.: $"Hali"
            // {érték, space száma (alapból 0)} = helymegtartók amelyekbe lehet változót, értékeket beszúrni.

            string firstName = "Bro";
            string lastName = "Code";
            int age = 21;

            // Alap: 
            Console.WriteLine("Hello" + firstName + " " + lastName + ".");
            Console.WriteLine("You're " + age + " years old.");

            // String literál:
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You're {age} years old.");
            Console.WriteLine($"You're {age, 10} years old."); // 10 space lesz elötte.
            Console.WriteLine($"You're {age, -10} years old."); // 10 space lesz utána.


        }
    }
}