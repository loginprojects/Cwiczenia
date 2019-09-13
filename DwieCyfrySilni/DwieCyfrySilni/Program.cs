using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwieCyfrySilni
{
    class Program
    {
        //dla zadanej liczby n wyznacza dwie ostatnie cyfry n!
        //i drukuje na konsoli

        static void Rozwiazanie(int n)
        {
            if (n==1)
            {
                Console.WriteLine("0 1");
            }
            else if (n==2)
            {
                Console.WriteLine("0 2");
            }
            else if (n == 3)
            {
                Console.WriteLine("0 6");
            }
            else if(n == 4)
            {
                Console.WriteLine("2 4");
            }
            else if(n == 5)
            {
                Console.WriteLine("2 0");
            }
            else if(n == 6)
            {
                Console.WriteLine("2 0");
            }
            else if(n == 7)
            {
                Console.WriteLine("4 0");
            }
            else if(n == 8)
            {
                Console.WriteLine("2 0");
            }
            else 
            {
                Console.WriteLine("0 0");
            }
        }

        static int silnia(int n)
        {
            if (n == 1) return 1;
            int iloczyn = 1;
            for (int i = 1; i <=n; i++)
            {
                iloczyn *= i;
            }
            return iloczyn;
            
        }
        static void Main(string[] args)
        {
            int liczbaPrzypadkow;
            liczbaPrzypadkow = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczbaPrzypadkow; i++)
            {
                int n = int.Parse(Console.ReadLine());
                //Console.WriteLine(silnia(n));
                Rozwiazanie(n);
            }
        }
    }
}
