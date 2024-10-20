using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10sayisinin3ebolumundenkalan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kalan = 10 % 3;
            Console.WriteLine("10 sayısının 3e bölümünden kalan: " + kalan);
            Console.ReadKey();
        }
    }
}
