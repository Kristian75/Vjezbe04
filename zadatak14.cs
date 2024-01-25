using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = { 1, 2, 3, 4, 5 };
            int[] niz2 = { 1, 2, 5, 4, 5 };

            int brojClanova = 0;

            for (int i = 0; i < niz1.Length; i++)
            {
                if (niz1[i] == niz2[i])
                {
                    brojClanova++;
                }
            }

            Console.WriteLine("Broj članova s istim indeksom i vrijednošću: " + brojClanova);

            Console.ReadKey();
        }
    }
}
