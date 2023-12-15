using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mini ATM Uygulamasi yapalim, kullancidan bir deger alalim ve aldigimiz degere göre islemler yapalim (Switch Case) kullanacagiz
            //1- Bakiye görüntüle
            //2- Para cek
            //3- Para yatir
            //4- Cikis yap
            //1-2-3-4 disinda bir deger girilmis ise hata versin

            int bakiye = 700;

            Console.WriteLine("ATM ye hosgeldiniz...");
            Console.WriteLine("Lüften bir islem seciniz");

            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Cek");
            Console.WriteLine("3- Para Yatir");
            Console.WriteLine("4- Cikis Yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz :" + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Cekmek istediginiz tutari giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para cekemezsiniz");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz :" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatirmak istediginiz tutari giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni bakiyeniz :" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;


                case "4":
                    Console.WriteLine("Hesabinizdan cikis yapiliyor iyi Günler");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen gecerli bir deger giriniz");
                    Console.ReadLine();
                    break;
                   

            }

        }
    }
}
