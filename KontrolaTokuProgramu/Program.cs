using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaTokuProgramu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SectiForCyklus(3, 9));
            Console.WriteLine(SectiWhileCyklus(3, 9));
            Console.WriteLine(SectiDoWhileCyklus(3, 9));
            Console.WriteLine(SectiRekurentni(3, 12, 1, 1));
            Console.ReadKey();
        }
        public static int Factorial(int x)
        {
            if (x < 0) throw new System.ArgumentException("Argument je zaporny", "x");
            if (x < 2) return 1;
            return x * Factorial(x - 1);
        }

        public static int SectiForCyklus(int numberX, int max) 
        {
            int vysledek = 1;
            for (int i = 1; i < max; i++)
                vysledek += numberX * i / Factorial(i);
            return vysledek;
        }

        public static int SectiWhileCyklus(int numberX, int max)
        {
            int vysledek = 1;
            int pp = 1;
            while (max > pp)
                vysledek += numberX * pp / Factorial(pp++);
            return vysledek;
        }

        public static int SectiDoWhileCyklus(int numberX, int max)
        {
            int vysledek = 1;
            int pp = 1;
            do
            {
                vysledek += numberX * pp / Factorial(pp++);
            } while (max > pp);
            return vysledek;
        }

        public static int SectiRekurentni(int numberX, int max, int vysledek, int pp)
        {
            if (max > pp)
                return SectiRekurentni(numberX, max, vysledek + (numberX * pp / Factorial(pp)), ++pp);
            return vysledek;
        }
    }
}
