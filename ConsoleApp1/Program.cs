using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Bakiye = 1000;
            Console.WriteLine("Atm'ye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");

            Console.WriteLine("1:Bakiye Görüntüleme");
            Console.WriteLine("2: Para Çekme");
            Console.WriteLine("3:Para Yatırma");
            Console.WriteLine("q:Çıkış");

            string secim = Console.ReadLine();

            if (secim == "1")
            {

                Console.WriteLine("Şu anki bakiyeniz:" + Bakiye);
            }

            else if (secim == "2")
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz.");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= Bakiye)
                {
                    Console.WriteLine("Kalan Tutar:" + (Bakiye - cekilecek_tutar));
                }

                else
                {
                    Console.WriteLine("Bakiyeniz Yeterli Değildir.");
                }

            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz:" + (Bakiye + yatırılacak_tutar));

            }

            else if (secim == "q")
            {
                Console.WriteLine("Atm'den Çıkış Yapılıyor");
                Console.WriteLine("Çıkış Yapıldı, İyi Günler...");

            }
            else
            {

                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
            }
            Console.ReadLine();

        }

    }
}
