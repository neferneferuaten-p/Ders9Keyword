using System;

namespace Ders9Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keywordler proglamlama dilinin en küçük parçalarıdır
            // Derleyici için ön tanımlı olan, nerede hangi amaca hizmet edeceği bellidir, kod içinde çağrılabileceği noktalar sınırlıdır
            // Operatörler belirli bir operasyonu ve eylemi üslenirken keywordler daha geniş kavramları ifade eder
            // Operatörler aslında keywordtür ama her keyword operatör değildir

            // Konseptli keywordler tek başına anlam ifade etmezler, kullanılan konseptle bir anlam kazanırlar
            #region Yardımcı Manevratik Komutlar
            // Kodu durdurmak, devamını okumamak, var olan bir döngünden çıkış yapmak gibi kodu yönlendirmek için kullanılan metotlardır
            // Manevratik komotlar kodun yönlendirmelerin daha az efor harcayarak daha efektif şekilde yapmamızı sağlar.
            #region break Komutu

            /* Çalışmak istediğinizde bölüm sonundaki kısımla beraber burayı bozun 

            // switch case-döngüler, bu iki yapının içinde kullanılır
            // Kullanılan yapıdan çıkış yapılmasını / sonlandırılmasını sağlar
            switch (10)
            {
                case 5:
                    break;
                case 10:
                    break;
            }


            while (true)
            {
                break;
            }

            do
            {
                if (true)
                {
                    break; // Döngünün içinde olduğumuz için break komutunu kullanabiliriz
                }
            } while (true);
            // Foreach iterasyonunda da kullanılır ilerde görecez
            #region Örnek 1
            // Kullanıcı 't' harfini girene kadar alınan sınırsız sayıda sayıyı toplayan ve ekrana yazdıran uygulamayı yazın
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Lutfen bir sayı girin");
                string girilenDeger = Console.ReadLine();
                
                if (girilenDeger == "t")
                {
                    Console.WriteLine("Toplam sonuç : " + toplam);
                    break;
                }
                else
                {

                    toplam += int.Parse(girilenDeger);

                }
            }
            #endregion
            #region Örnek 2
            // Kullanıcıdan alıbilecek sonsuz adet sayı değerinden 37'nin katı girildiğinde sonlandıran uygulamayı yazalım
            while (true)
            {
                Console.WriteLine("Bir sayı girin");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi % 37 == 0)
                {
                    Console.WriteLine("37'nin katı değer girdiniz");
                    break;
                }
            }
            #endregion

            */ // Çalışmak istediğinizde üst kısımla beraber burayı bozun



            #endregion

            #region Continue

            /*

            // Sadece döngülerde kullanılabi metotdur
            // Döngüde bir sonraki periyoda direkt geçiş yaptırır
            #region Örnek 1

            for (int i = 0; i < 100; i++)
            {
                if (i % 5 !=0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            #endregion
            #region örnek 2
            // Kullanıcının gidiği sonsuz adet sayıdan pozitif olanlarını çarpan ve 't' girildiğinde sonucu ekrana yazdıran programı yazalım
            int carpim = 1;
            while (true)
            {
                
                Console.WriteLine("Lütfen bir sayı girin, Continue Örnek 2");
                string girilenDeger = Console.ReadLine();
                if (girilenDeger == "t")
                {
                    Console.WriteLine(carpim);
                    break;
                }
                else
                {
                    int sayi = int.Parse(girilenDeger);
                    if (sayi < 0)
                    
                        continue;
                    
                        carpim *= sayi;
                    
                }
            }

            #endregion
            #region Örnek 3
            // 1-1000'e kadar 7'nin katı olmayan sayıları ekrana yazdıralım
            for (int i = 1; i < 1000; i++)
            {
                if (i % 7 == 0)

                    continue;
                Console.WriteLine(i);
                
            }
            #endregion
            */ // Çalışmak istediğinizde burayı bozun
            #endregion

            #region Return
            /* Her yerde (Metot içersinde) kullanılabilir, erişilebilir bir keywordtür
             * Nerede çağrılırsa çağrılsın bulunduğu metottan çıkış yapar
             * İleride göreceğimiz metotlar konusunda geriye değer dondurme sorumluluğunuda üstlenir
             */
            /*  while (true)
              {
                  switch (10)
                  {
                      case 10:
                      return; // returndan sonra ne komutu gelirse gelsin işlenmeyecektir
                  break;
                  }

              }
             */


            #endregion

            #region goto
            //  Geleneksel programcılar tarafından pek sevilmez, spagetti koda sebep olduğu idda ediliyor ve programı yavaşlattığıda 
            // -- söylenmektedir.
            // Diller geliştikce bu komutun kalkması doğal bir süreçtir
            switch (10)
            {
                case 5:
                    Console.WriteLine("asdfds");
                case 10:
                    goto case 15;
                case 15:
                    break;
            }
            /*
            a:
            Console.WriteLine("merhaba");
            goto a;
            */

            #endregion

            #endregion

        }
    }
}
