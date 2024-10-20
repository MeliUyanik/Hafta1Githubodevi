using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyedengirilen4sayinintoplaminiveçarpimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3, sayi4, toplam, carpim;
            
            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dördüncü sayıyı girini: ");
            sayi4 = Convert.ToInt32(Console.ReadLine());
            
            toplam = sayi1 + sayi2 + sayi3 + sayi4;
            carpim = sayi1 * sayi2 * sayi3 * sayi4;
            
            Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
            Console.WriteLine("Girdiğiniz sayıların carpımı: " + carpim);
            Console.ReadKey();
        }
    }
}
