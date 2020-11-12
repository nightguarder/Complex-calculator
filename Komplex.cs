using System;
using System.Numerics;
//Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
//Neokopiroval jsem ani neopsal jsem cizí zdrojove kody
//Nikdo me pri vypracovani neradil
//Pokud nektery radek porusuje toto pravidlo je oznacek komentarem
//NENI MOJE TVORBA
//Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENI ZE STUDIA
// Cyril Steger uco. 36830

namespace Priklad_3._4
{
    class Komplex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program dokaze spocitat komplexni cisla");
            double x = 5.2; double y = 1.6;         //realna cisla
            double xi = 3.25; double yi = -4;       //imaginarni cisla

            double secti = (x + y);         //scitani
            double sectii = (xi + (yi));

            double odecti = (x - y);        //odecitani
            double odectii = (xi - yi);

            double nasobeni = ((x * y) + xi * (yi * -1));     //nasobeni
            double nasobenii = (x*yi)+(xi*y);                 // (a+bi)*(c+di) = ac-bd +(ad+bc)i

            secti = Math.Round(secti,2);                //zaokrouhleni na 2 deset.mista
            nasobenii = Math.Round(nasobenii, 2);
            Console.WriteLine("Vysledek po scitani (x,y) = " +secti +" " +sectii +"i");
            Console.WriteLine("Vysledek po odcitani (x,y) = " +odecti + " " +odectii +"i");
            Console.WriteLine("Vysledek po nasobeni (x,y) = " +nasobeni +" " +nasobenii +"i");
            
        }
    }
}
