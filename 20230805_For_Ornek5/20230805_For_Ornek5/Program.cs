using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230805_For_Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 5
            //1'den başlayıp kullanıcının girdiği sayıya kadar olan sayıların 2'ye bölünebilenlerini ekrana yazdıralım

            int kullaniciSayi;
            Console.Write("Bir Sayı Giriniz : ");
            kullaniciSayi = int.Parse(Console.ReadLine());

            for (int sayac = 1; sayac <= kullaniciSayi; sayac++)
            {
                if (sayac % 2 == 0)
                {
                    Console.WriteLine(sayac + " Sayısı 2'ye tam bölünüyor");
                }
                else
                {
                    Console.WriteLine(sayac + " Sayısı 2'ye tam bölünmüyor ");
                }
            }

            Console.ReadKey();
        }
    }
}
