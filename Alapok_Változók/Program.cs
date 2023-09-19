using System;

namespace Alapok_Változók
{
    public class Program
    {
        public static void Main(string[] args) {
            // A változók különböző fajta adatok tárolására szolgálnak.
            // Nagyon speciális tipúsu adatokat fogunk használni.
            // Hogy engedélyezzenek bizonyos funkciókat ellátni azon a típuson
            // Vagy ne pazaroljunk tárhelyet a memóriában.


            // Változó létrehozására a szintaxis:
            // típusa neve = értéke;

            // bool (logikai) = true, false
            bool szavazhatok = true;
            // int (lehetnek 32 valamint 64 bitesek) = számok
            // {index}: Helyörző itt a legvégén megadott paramétert fogja behelyezni a helyére sorrendben index szerint.
            // pl.:
            Console.WriteLine("Az én nevem {0}\nA korom {1}\nA város ahol születtem {2}", "József", 12, "Erdély");
            
            Console.WriteLine("A legnagyobb szám: {0}", int.MaxValue); // A legnagyobb tárolható szám
            Console.WriteLine("A legkisebb szám: {0}", int.MinValue); // A legkisebb tárolható szám

            // long = ezek is számok csak kifejezetten 64 bitet foglalnak le.

            Console.WriteLine("A legnagyobb long: {0}", long.MaxValue);
            Console.WriteLine("A legkisebb long: {0}", long.MinValue);

            // decimal = tizedes pontosságú számok.
            // M-el a végén kell lezárni.
            // 128 bites értéket tárolnak = 28 számjegyű pontosságra képesek

            decimal decPiÉrtéke = 3.14159265358979323846M;
            decimal decNagySzam = 3.0000000000000000000000000011M;
            Console.WriteLine("DEC : PI + NagySzam = {0}", decPiÉrtéke + decNagySzam);
            Console.WriteLine("A legnagyobb decimal: {0}", decimal.MaxValue);
            Console.WriteLine("A legkisebb decimal: {0}", decimal.MinValue);

            // double = 64 bites float tipusú számok
            // 32 bites = 14 számjegy pontosságú
            Console.WriteLine("A legnagyobb double {0}", double.MaxValue);
            Console.WriteLine("A legkisebb double {0}", double.MinValue);
            double dblPiÉrtéke = 3.14159265358979;
            double dblNagySzam = 3.00000000000000002;
            Console.WriteLine("DBL : PI + NagySzam = {0}", dblPiÉrtéke + dblNagySzam);

            // float = tizedes pontosságú számok.
            // F-el a végén le kell zárni.
            // 6 számjegy pontosságú
            Console.WriteLine("A legnagyobb float {0}", float.MaxValue);
            Console.WriteLine("A legkisebb float {0}", float.MinValue);
            float floatPiÉrtéke = 3.14159265358979F;
            float floatNagySzam = 3.00000000000000002F;
            Console.WriteLine("Float : PI + NagySzam = {0}", floatPiÉrtéke + floatNagySzam);

            // Más adattípusok:

            // byte: 8-bit csak pozitiv szám(int) 0-tól 255-ig
            Console.WriteLine("A legnagyobb byte: {0}\nA legkisebb byte: {1}", byte.MaxValue, byte.MinValue);

            // char: 16-bit unicode karakter (egy karakter)

            // sbyte: 8-bit pozitiv/negatív szám(int) 127-től -128-ig
            Console.WriteLine("A legnagyobb sbyte: {0}\nA legkisebb sbyte: {1}", sbyte.MaxValue, sbyte.MinValue);

            // short: 16-bit pozitiv/negativ szám(int) -32768-tól 32767-ig
            Console.WriteLine("A legnagyobb short: {0}\nA legkisebb short: {1}", short.MaxValue, short.MinValue);

            // uint: 32-bit csak pozitiv szám(int) 0-tól 4294967295-ig
            Console.WriteLine("A legnagyobb uint: {0}\nA legkisebb uint: {1}", uint.MaxValue, uint.MinValue);

            // ulong: 64-bit csak pozitiv szám(int) 0-tól 18446744073709551615-ig
            Console.WriteLine("A legnagyobb ulong: {0}\nA legkisebb ulong: {1}", ulong.MaxValue, ulong.MinValue);

            // ushort: 16-bit csak pozitiv szám(int) 0-tól 65535-ig
            Console.WriteLine("A legnagyobb ushort: {0}\nA legkisebb ushort: {1}", ushort.MaxValue, ushort.MinValue);

            // Típus módosítás:

            // típusAmireSzeretnénk.Parse();
            // érték.ToTípusAmireSzeretnénk();
            // (típusAmireSzeretnénk)érték pl.: (int)1.32

            // változó.GetType() változó típusának lekérdezése.

            // Szövegből bool: Logikai érték lesz (csak true és false lehet a paraméter).
            bool StrbőlBool = bool.Parse("true");
            Console.WriteLine("StrbőlBool: {0}\nTípusa: {1}", StrbőlBool, StrbőlBool.GetType());

            // Számból szöveg
            int IntbőlString = int.Parse("100");
            Console.WriteLine("IntbőlString: {0}\nTípusa: {1}", IntbőlString, IntbőlString.GetType());

            // Dblből szöveg
            double DblbőlString = double.Parse("1.234");
            Console.WriteLine("DblbőlString: {0}\nTípusa: {1}", DblbőlString, DblbőlString.GetType());

            // Dblből szöveg
            string strÉrték = DblbőlString.ToString();
            Console.WriteLine($"Adat típus: {strÉrték.GetType()}");

            // Explicit konverzió:

            // Azt nevezzük explicit konverziónak amikor néhány adatot elvesztünk

            // Doublből int: Elvesztem az összes tizedesjegyet amit belül tárolt.
            double Dblszam = 12.345;
            Console.WriteLine($"Szám: {(int)Dblszam}"); // .345 elfog veszni.


            // Implicit konverzió:

            // Azt nevezzük implicit konverziónak amikor kisebb meretű tipusból nagyobbra váltunk.
            // Ilyenkor nem veszítünk semmilyen adatot.

            int IntSZAM = 10;
            long LongSZAM = IntSZAM;
            Console.WriteLine(LongSZAM);
        } 
    }
}
