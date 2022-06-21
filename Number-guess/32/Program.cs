using System;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int tutulanSayi = rnd.Next(1, 101);
            int sayac = 1;

            Console.WriteLine("**** SAYI TAHMİN OYUNU *****");
            yenitahmin: Console.WriteLine("Lütfen 1-100 arası bir sayı giriniz");
            int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            
            if (sayac <=10)
            {

                if (tahminEdilenSayi == tutulanSayi)
                {
                    Console.WriteLine("Tebrikler " + sayac + " tahminde bildiniz...");
                }
                else if (tahminEdilenSayi < tutulanSayi)
                {
                    Console.WriteLine("Küçük sayı tahmin ettiniz. Lütfen daha büyük bir sayı giriniz");
                    sayac++;
                    goto yenitahmin;

                }
                else if (tahminEdilenSayi > tutulanSayi)
                {
                    Console.WriteLine("Büyük sayı tahmin ettiniz. Lütfen daha küçük bir sayı giriniz");
                    sayac++;
                    goto yenitahmin;
                }
            }
            else
            {
                Console.WriteLine("10 tahmin hakkınızı da kullandınız. Artık birdahaki sefere...");
            }
            

        }
    }
}
