using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String türü değişken gibi kullanılsa da aslında dizidir.

            //int[] sayilar = { 3, 5, 12, -45, 7 };
            //sayilar[1] = 123;
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine("Eleman sayısı = " + sayilar.Length);

            //string isim = "Alp Sarıkışla ";
            ////isim[4] = "C";
            //isim += "İbrahim ";
            //Console.WriteLine("Karakter Sayısı = " + isim.Length);
            //Console.WriteLine(isim[4]);
            //Console.WriteLine(isim);

            #endregion

            #region Konsoldan alınan yazı kaç karakterlidir?

            //Console.WriteLine("Lütfen adınızı giriniz");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Adınız = " + isim.Length + " karakterlidir.");

            #endregion

            #region Konsoldan alınan yazının başındaki boşlukları silme

            // Console.WriteLine("Lütfen yazı giriniz");
            // string metin = Console.ReadLine();

            // string bosluksuz = "";
            //int baslangic = 0;

            // for (int i = 0; i < metin.Length; i++)
            // {
            //     if (metin[i]!= ' ')
            //     {
            //         baslangic = i;
            //         break;
            //     }
            // }

            // for (int i = baslangic; i < metin.Length; i++)
            // {
            //     bosluksuz += metin[i];
            // }
            // Console.WriteLine(bosluksuz);





            #endregion

            #region Karakter Index'i Bulma

            ////Yazı alınacak
            ////aranan karakter alınacak
            ////aranan karakter hangi indexlerde

            //Console.WriteLine("Lütfen bir yazı giriniz ");
            //string yazi = Console.ReadLine();

            //Console.WriteLine("Aranacak karakteri giriniz ");
            //char karakter = Convert.ToChar(Console.ReadLine());

            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    if (yazi[i]==karakter)
            //    {
            //        Console.WriteLine(i + ". indexte");
            //    }

            //}


            #endregion

            #region Konsoldan alınan karakter büyük karakter mi küçük karakter mi?

            ////65 - 90 Büyük karakterler
            ////97 - 122 Küçük karkterler

            //Console.WriteLine("Karakter giriniz");
            //char karaktter = Convert.ToChar(Console.ReadLine());
            //int sayisal = (int)karaktter;

            //if (sayisal >= 65 && sayisal <= 90)
            //{
            //    Console.WriteLine("Karakter Büyük");
            //}
            //else if (sayisal >= 97 && sayisal <= 122)
            //{
            //    Console.WriteLine("Karakter Küçük");
            //}
            //else
            //{
            //    Console.WriteLine("Sembol girdiniz");
            //}

            #endregion

            #region Konsoldan alınan karakter büyük ise küçük, küçük ise büyük halini yazdırınız.

            //Console.WriteLine("Karakter giriniz");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //int sayisal = (int)karakter;

            //if (sayisal >65 && sayisal <= 90)
            //{
            //    char kucuk = (char)(sayisal + 32);
            //    Console.WriteLine(kucuk);
            //}
            //else if (sayisal >= 97 && sayisal <= 122)
            //{
            //    char buyuk = (char)(sayisal -32);
            //    Console.WriteLine(buyuk);
            //}
            //else
            //{
            //    Console.WriteLine("Sembol girildi.");
            //}

            #endregion

            #region Metin içindeki tüm küçük karakterleri büyütün

            //MevLüt KoYuNCu

            //Console.WriteLine("Metin giriniz");
            //string metin = Console.ReadLine();
            //string buyuk = "";

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    int sayisal = (int)metin[i];
            //    if (sayisal >= 97 && sayisal <= 122)
            //    {
            //        int buyuksayisal = sayisal - 32;

            //        buyuk += (char)buyuksayisal;
            //    }
            //    else
            //    {
            //        buyuk += metin[i];
            //    }
            //}
            //Console.WriteLine(buyuk);

            #endregion

            #region Metin içindeki tüm küçük karakterleri küçültün

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    int sayisal = (int)metin[i];
            //    if (sayisal >= 65 && sayisal <= 90)
            //    {
            //        int buyuksayisal = sayisal + 32;
            //        buyuk += (char)buyuksayisal;
            //    }
            //    else
            //    {
            //        buyuk += metin[i];
            //    }
            //}
            //Console.WriteLine(buyuk);


            #endregion

            #region İlk Karakter index'i bulma 

            //Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine();

            //Console.WriteLine("Aranacak karakteri giriniz");
            //char karakter = Convert.ToChar(Console.ReadLine());

            //int index = -1;

            //for (int i = 0; i < metin.Length; i++)
            //{

            //    if (metin[i]==karakter)
            //    {
            //        index = i;
            //        Console.WriteLine(index + ". indexte");                                          //İNDEX -1 OLAMAZ. BOOL İLE YAZMADAN ORTAK NOKTA BULABİLİRİZ.
            //        break;
            //    }
            //}

            //if (index == -1)
            //{
            //    Console.WriteLine("Karakter bulunamadı");
            //}

            #endregion

            #region Metin içinde metin bulma

            //Console.WriteLine("Metin giriniz");
            //string metin = Console.ReadLine();

            //Console.WriteLine("Aranacak metni giriniz");
            //string aranacak = Console.ReadLine();

            ////i metnin index numaralarını gezicek

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    bool buldukmu = true;
            //    for (int j = 0; j < aranacak.Length; j++)
            //    {
            //        if (metin[i + j] != aranacak[j])
            //        {
            //            buldukmu = false;
            //            break;
            //        }

            //        if (buldukmu == true)
            //        {
            //            Console.WriteLine("aranacak" + i + ". indexte başlıyor");
            //            break;
            //        }
            //    }
            //}

            #endregion

            #region Konsoldan alınan kelime polindrom mudur?



            #endregion

            #region Bin iki yüz otuz dörtü, 1234 şeklinde yazdır.



            #endregion



        }
    }
}
