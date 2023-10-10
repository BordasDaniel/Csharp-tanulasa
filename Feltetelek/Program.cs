<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Feltetelek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // if / else / else if:

            // Relációs operátorok: >, <, >=, <=, ==, !=
            // Logikai operátorok: &&, ||, !

            // Szintaxis: if vagy else if (feltétel) { törzs }
            // Szintaxis else: else { törzs }

            int kor = 17;
            if (kor >= 5 && kor <= 7)
            {
                Console.WriteLine("Menj általános iskolába.");
            }
            if (kor > 7 && kor < 13)
            {
                Console.WriteLine("Menj középiskolába.");
            }
            if (kor > 13 && kor < 19)
            {
                Console.WriteLine("Menj főiskolába.");
            }
            else
            {
                Console.WriteLine("Menj kollégiumba.");
            }

            if (kor < 14 || kor > 67)
            {
                Console.WriteLine("Nem kellene dolgoznod.");
            }
            Console.WriteLine("! true = " + (!true)); // Karakterláncok összefűzése.
                                                      // !true = false és !false = true


            // Hármas operátor avagy ternary operator:

            // Szintaxis: feltétel ? Érték ha igaz : Érték ha hamis.
            // pl.: Hozzá akarunk rendelni egy értéket attól függően, hogy az állítás igaz-e vagy sem.

            bool Vezethet = kor >= 16 ? true : false;
            Console.WriteLine(Vezethet);


            // Switch:

            // Akkor használatos amikor nagyon korlátozott a választási opciók száma.

            switch (kor)
            {
                case 1:
                case 2:
                    Console.WriteLine("Menj a szüleidhez.");
                    break; // Meg fog állni a switch ezen a ponton (kifog lépni belőle).
                case 3:
                case 4:
                    Console.WriteLine("Menj az előiskolába");
                    break;
                case 5:
                    Console.WriteLine("Menj óvodába.");
                    break;
                default:
                    Console.WriteLine("Menj egy másik iskolába.");
                    goto MásikIskola;
            }

        MásikIskola:
            Console.WriteLine("Általános, Közép, Egyetem");

        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Feltetelek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // if / else / else if:

            // Relációs operátorok: >, <, >=, <=, ==, !=
            // Logikai operátorok: &&, ||, !

            // Szintaxis: if vagy else if (feltétel) { törzs }
            // Szintaxis else: else { törzs }

            int kor = 17;
            if (kor >= 5 && kor <= 7)
            {
                Console.WriteLine("Menj általános iskolába.");
            }
            if (kor > 7 && kor < 13)
            {
                Console.WriteLine("Menj középiskolába.");
            }
            if (kor > 13 && kor < 19)
            {
                Console.WriteLine("Menj főiskolába.");
            }
            else
            {
                Console.WriteLine("Menj kollégiumba.");
            }

            if (kor < 14 || kor > 67)
            {
                Console.WriteLine("Nem kellene dolgoznod.");
            }
            Console.WriteLine("! true = " + (!true)); // Karakterláncok összefűzése.
                                                      // !true = false és !false = true


            // Hármas operátor avagy ternary operator:

            // Szintaxis: feltétel ? Érték ha igaz : Érték ha hamis.
            // pl.: Hozzá akarunk rendelni egy értéket attól függően, hogy az állítás igaz-e vagy sem.

            bool Vezethet = kor >= 16 ? true : false;
            Console.WriteLine(Vezethet);


            // Switch:

            // Akkor használatos amikor nagyon korlátozott a választási opciók száma.

            switch (kor)
            {
                case 1:
                case 2:
                    Console.WriteLine("Menj a szüleidhez.");
                    break; // Meg fog állni a switch ezen a ponton (kifog lépni belőle).
                case 3:
                case 4:
                    Console.WriteLine("Menj az előiskolába");
                    break;
                case 5:
                    Console.WriteLine("Menj óvodába.");
                    break;
                default:
                    Console.WriteLine("Menj egy másik iskolába.");
                    goto MásikIskola;
            }

        MásikIskola:
            Console.WriteLine("Általános, Közép, Egyetem");

        }
    }
>>>>>>> 983a3c25d2b03837ca9c74d1d8d18f12c09030e5
}