using System;
using System.Numerics;
using System.Text;

namespace Komplexni_cislo
{
    class Complex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Komplexni cisla");
            Console.WriteLine("Zadejte Realna cisla: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte Imaginarni cisla: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadana cisla jsou: " +"("+a +" "+c+")"+" " +"("+b+ "i " +d+"i"+")");
            Console.WriteLine("Vyberte operaci:\n" +"scitani= +\n" +"odecitani= -\n" +"nasobeni= *\n" +"deleni= /\n");
            string uzivatel = Console.ReadLine();       //Convert to Int? 
            
            if (uzivatel == "+")
            {
                System.Numerics.Complex number = new System.Numerics.Complex(a, b);
                System.Numerics.Complex number2 = new System.Numerics.Complex(c, d);
                Console.WriteLine(System.Numerics.Complex.Add(number, number2));
                Console.WriteLine("{0}" + " "+"{1}",number,number2);
                return;
            }
            else if (uzivatel == "-")
            {
                System.Numerics.Complex number1 = new System.Numerics.Complex(a, b);
                System.Numerics.Complex number2 = new System.Numerics.Complex(c, d);
                Console.WriteLine(System.Numerics.Complex.Subtract(number1, number2));
                return;
            }
            else if (uzivatel == "*")
            {

                System.Numerics.Complex number = new System.Numerics.Complex(a, b);
                System.Numerics.Complex number2 = new System.Numerics.Complex(c, d);

                Console.WriteLine(System.Numerics.Complex.Multiply(number, number2));
                return;
            }
            else if (uzivatel == "/")
            {
                System.Numerics.Complex number = new System.Numerics.Complex(a, b);
                System.Numerics.Complex number2 = new System.Numerics.Complex(c, d);

                Console.WriteLine(System.Numerics.Complex.Divide(number, number2));
                Console.WriteLine("{0}" + " " + "{1}", number, number2);
                return;
            }
            Console.WriteLine("Děkuji za použití Komplexní kalkulačky.Hezky +den.");
        }
       
    }
}
