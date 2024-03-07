using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string ime;
              string prezime;
              string grad;

              //Ispis korisniku
              Console.WriteLine("Unesite ime: ");

              //Iscitavanje sa konzole
              ime = Console.ReadLine();

              Console.WriteLine("Unesite prezime: ");

              prezime = Console.ReadLine();

              Console.WriteLine("Unesite grad: ");

              grad = Console.ReadLine();

              Console.WriteLine("Uneli ste osobu: ");
              Console.WriteLine(ime + " " + prezime + " " + grad);

              Console.ReadKey();
              */

            int a, b, rez;
            string prvi, drugi;
            Console.WriteLine("Unesite prvi broj:");
            prvi = Console.ReadLine();

            Console.WriteLine("Unesite drugi broj:");
            drugi = Console.ReadLine();

            a = int.Parse(prvi);
            b = int.Parse(drugi);

            rez = a + b;
            Console.WriteLine("Rezultat je: ");
            Console.WriteLine(a + "+" + b + "=" + rez);
            Console.ReadKey();
        }
    }
}
