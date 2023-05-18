using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Suvorov_5_pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            a = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {      
                if (a[i] == '*')
                {
                    i++;
                    continue;
                }
                Console.Write(a[i]);
            }
        }
    }
}
