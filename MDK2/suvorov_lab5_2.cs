using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_suv_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n = 2;
            string a, b= "";
            a = Console.ReadLine();
            string[] mas = a.Split(' ');
            for (i = 2; i < mas.Length; i++)
            {
                mas[i] = " ";
            }
            for (i = 0; i < mas.Length; i++)
            {
                b += mas[i];
                b += ' ';
            }
            Console.WriteLine(b);
        }
    }
}
