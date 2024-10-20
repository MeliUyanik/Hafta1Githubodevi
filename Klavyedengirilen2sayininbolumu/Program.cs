using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyedengirilen2sayininbolumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, bolum;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            
            bolum = sayi1 / sayi2;

            Console.WriteLine("Girdiiniz sayıların bölümü: " + bolum);
            Console.ReadKey();
        }
    }
}
