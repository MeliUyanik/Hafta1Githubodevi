using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GedikProje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girniiz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            sonuc = sayi1 - sayi2;

            Console.WriteLine("İşlem Sonucu: " + sonuc);
            Console.ReadKey();
        }
    }
}
