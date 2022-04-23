using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D Arrays
            //Größe ist fix, wenn man mehr braucht, muss man das ändern
            string[] names = new string[4];

            names[0] = "Sabrina";
            names[1] = "Rebekka";
            names[2] = "Amy";
            names[3] = "David";

            string[] names2 = new string[] { "Babara", "Sebastian", "Erik", "Ramona" };


            //2D Arrays

            string[,] products = new string[2, 3];

            //Produkt 1, Zeile 1
            products[0,0] = "Bananen";
            products[1, 0] = "Lebensmittel";

            //Produkt 2, Zeile 2
            products[0, 1] = "Klopapier";
            products[1, 1] = "Haushaltsartikel";

            //Produkt 3, Zeile 3
            products[0, 2] = "PC Games";
            products[1, 2] = "Zeitschriften";

            Console.WriteLine(names[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(products[0,1] + " " +products[1,1]);
            Console.ReadKey();
        }

    }
}
