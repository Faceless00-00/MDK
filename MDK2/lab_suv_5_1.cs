using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suvorov5lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int i;
            a = Console.ReadLine();
            b = "";
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] != '*')
                {
                    b += a[i];
                }
                else 
                {
                    b += "";
                }
            }
            for (i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
        }
    }
}
