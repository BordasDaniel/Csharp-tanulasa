using System;
using System.Collections.Generic;
using System.Linq;

namespace Constans
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // konstansok = megváltoztathatatlan értékek amelyek futtatási időben ismert
            // és nem változnak meg a program végéig.
            // Használata: const kulcsszó a változó adás legelején.
            // Ha egy olyan elemet akarsz konstanssá tenni amelynek értéke nem futtatási időben ismert pl.: változó, azt nem lehet azzá tenni
            // pl.: const string[] tomb = másikVáltozó; Hibát eredményez ugyanis lista nem lehet const.


            const double PI = 3.14159;
            
            // PI = 34; Hibát eredményez

            Console.WriteLine(PI);

        }
    }
}