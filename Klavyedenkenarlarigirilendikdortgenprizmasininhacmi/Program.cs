using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyedenkenarlarigirilendikdortgenprizmasininhacmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunkenar, kisakenar, yukseklik, hacim;
            Console.WriteLine("Dikdörtgen prizmanın uzun kenar uzunluğunu giriniz: ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgen prizmanın kısa kenar uzunluğunu giriniz: ");
            kisakenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgen prizmanın yüksekliğini giriniz: ");
            yukseklik = Convert.ToInt32(Console.ReadLine());

            hacim = uzunkenar * kisakenar * yukseklik;

            Console.WriteLine("Dikdörtgen prizmanın hacmi: " + hacim);
            Console.ReadKey();
        }
    }
}