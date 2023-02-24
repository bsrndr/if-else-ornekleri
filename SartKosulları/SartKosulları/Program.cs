using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SartKosulları
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıdan alınan iki sayıyı, önce Toplama işlemi yapıp ekrana yazdırınız, sonra Çıkarma işlemi yapıp ekrana yazdırınız.
            // Kullanıcıdan alınan iki sayıyı, önce Toplama işlemi yapıp ekrana yazdırınız, sonra Çıkarma işlemi yapıp ekrana yazdırınız.
            //int sayi1, sayi2, topla, cikar;
            //Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //topla = sayi1 + sayi2;
            //Console.WriteLine("iki sayının toplamı: " + topla);
            //cikar = sayi1 - sayi2;
            //Console.WriteLine("iki sayının farkı: " + cikar);
            //Console.ReadLine(); 
            #endregion

            #region Klavyeden kullanıcı tarafından dik kenarları girilen bir üçgenin alanını hesaplayan program.
            // Klavyeden kullanıcı tarafından dik kenarları girilen bir üçgenin alanını hesaplayan program.
            //int taban;
            //double yükseklik, alan;
            //Console.WriteLine("Lütfen taban uzunluğunu giriniz:");
            //taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen yüksekliği giriniz:");
            //yükseklik = Convert.ToDouble(Console.ReadLine());
            //alan = (taban * yükseklik) / 2;
            //Console.WriteLine("Alan: " + alan);
            //Console.ReadLine();
            #endregion

            #region Klavyeden kullanıcı tarafından TL cinsinden para miktarını, yine kullanıcı tarafından girilen Euro ve Dolar kuruna göre TL'nin kaç Euro ve kaç Dolar olduğunu bulan programı yazınız.

            //double para, eurotopla, dolartopla,dolar, euro;
            //Console.WriteLine("Lütfen dolar kuru giriniz: ");
            //dolar = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen euro kuru giriniz: ");
            //euro = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen TL cinsinden para miktarı giriniz: ");
            //para = Convert.ToDouble(Console.ReadLine());
            //dolartopla = dolar / para;
            //eurotopla = euro / para;
            //Console.WriteLine("Girdiğiniz TL miktarının dolar karşılığı: " + dolartopla + "\nGirdiğiniz TL miktarının euro karşılığı:" + eurotopla);
            //Console.ReadLine(); 

            #endregion
            #region Girilen iki sayıdan büyük olanı bulan program

            //int sayi1, sayi2;
            //Console.WriteLine("Lütfen ilk sayıyı giriniz:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı-1 sayı-2 den büyüktür");
            //}
            //else if (sayi1 < sayi2)
            //{
            //    Console.WriteLine("Sayı-2 sayı-1 den büyüktür");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("Sayı-1 sayı-2 eşittir");
            //}
            //Console.ReadLine(); 
            #endregion

            #region Girilen sayının tek mi çift mi olduğunu bulan console uygulaması
            //int sayi;
            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı tektir");
            //}
            //Console.ReadLine(); 
            #endregion

            #region Bir mağazadan alınan ürünlerde 100 TL ve üzerinde kargo bedava, 100 TL altında 20 lira kargo ücreti alınmaktadır. Kullanıcıdan alınan toplam ödemeye göre ödenmesi gereken tutarı gösteren console uygulaması
            //int fiyat, toplam;
            //Console.WriteLine("Lütfen ürünün fiyatını giriniz:");
            //fiyat = Convert.ToInt32(Console.ReadLine());
            //toplam = fiyat + 20;
            //if (fiyat >= 100)
            //{
            //    Console.WriteLine("Toplam ödemeniz gereken tutar: " + fiyat);
            //}
            //else
            //{
            //    Console.WriteLine("Toplam ödemeniz gereken tutar: " + toplam);
            //}
            //Console.ReadLine(); 
            #endregion

            #region Kullanıcı şifreyi doğru girdiğinde “Giriş Başarılı”, yanlış girdiğinde “Girdiğiniz şifre hatalı” yazdıran console uygulaması
            //string sifre = "abc";
            //string girilensifre;
            //Console.WriteLine("Lütfen şifrenizi giriniz: ");
            //girilensifre = Console.ReadLine();

            //if (sifre == girilensifre)
            //{
            //    Console.WriteLine("Giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz şifre hatalı");
            //}
            //Console.ReadLine(); 
            #endregion

            #region Klavyeden girilen su sıcaklığına göre katı, sıvı yada gaz yazdıran console uygulaması
            //int sicaklik;
            //Console.WriteLine("Lütfen sıcaklık giriniz: ");
            //sicaklik = Convert.ToInt32(Console.ReadLine());

            //if (sicaklik < 0)
            //{
            //    Console.WriteLine("katı");
            //}
            //else if (sicaklik >= 100)
            //{
            //    Console.WriteLine("Gaz");
            //}
            //else
            //{
            //    Console.WriteLine("Sıvı");
            //}
            //Console.ReadLine(); 
            #endregion

            #region //Girilen sayının kaç basamaklı olduğunu bulan console uygulaması. (En fazla 4 basamaklı sayıya kadar)
            //Girilen sayının kaç basamaklı olduğunu bulan console uygulaması. (En fazla 4 basamaklı sayıya kadar)

            //int sayi;
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi <10)
            //{
            //    Console.WriteLine("1 basamaklı");
            //}
            //else if (sayi< 100)
            //{
            //    Console.WriteLine("2 basamaklı");
            //}
            //else if (sayi < 1000)
            //{
            //    Console.WriteLine("3 basamaklı");
            //}
            //else if (sayi < 10000)
            //{
            //    Console.WriteLine("4 basamaklı");
            //}
            //else
            //{
            //    Console.WriteLine("Kural dışı bir sayı girdiniz");
            //}
            //Console.ReadLine(); 
            #endregion

            #region Girilen 3 sayıdan en büyüğünü bulan console uygulaması

            //int sayi1, sayi2, sayi3, enbuyuk;
            //Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
            //sayi3 = Convert.ToInt32(Console.ReadLine());
            //enbuyuk = sayi1;

            //if (sayi2>enbuyuk)
            //{
            //    enbuyuk = sayi2;
            //}
            //if (sayi3>enbuyuk)
            //{
            //    enbuyuk = sayi3;
            //}
            //Console.WriteLine("En büyük sayı: " + enbuyuk);
            //Console.ReadLine();



            //if (sayi1 > sayi2)
            //{
            //    if (sayi1 > sayi3)
            //    {
            //        Console.WriteLine("En büyük sayı birinci sayıdır");
            //    }

            //}
            //if (sayi2 > sayi1)
            //{
            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine("En büyük sayı ikinci sayıdır");
            //    }

            //}
            //if (sayi3 > sayi1)
            //{
            //    if (sayi3 > sayi2)
            //    {
            //        Console.WriteLine("En büyük sayı üçüncü sayıdır");
            //    }

            //}
            //Console.ReadLine(); 
            #endregion

            #region ÖDEV: Kullanıcının yapmış olduğu seçime göre girmiş olduğu 2 sayıyı toplayan, çıkaran, çarpan veya bölme işlemi yapan uygulama.

            //double sayi1, sayi2, sonuc;
            //Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            //sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Yapmak istediğiniz işlemi giriniz: ");
            //Console.WriteLine("topla=1, çıkar=2, carp=3, bol=4");
            //sonuc = Convert.ToDouble(Console.ReadLine());

            //if (sonuc == 1)
            //{
            //    Console.WriteLine("İşlem sonucu: " + (sayi1 + sayi2));
            //}

            //else if (sonuc == 2)
            //{
            //    Console.WriteLine("İşlem sonucu: " + (sayi1 - sayi2));
            //}

            //else if (sonuc == 3)
            //{
            //    Console.WriteLine("İşlem sonucu: " + (sayi1 * sayi2));
            //}
            //else
            //{
            //    Console.WriteLine("İşlem sonucu: " + (sayi1 / sayi2));
            //}
            //Console.ReadLine();

            #endregion

            double sayi1, sayi2;
            string sonuc;
            Console.WriteLine("Birinci sayı:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayı:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bir işlem seçiniz:");
            Console.WriteLine("topla=+, çıkar=-, carp=*, böl=/");
            sonuc = Console.ReadLine();

            if (sonuc == "+")
            {
                Console.WriteLine("Yapılan işlem sonucu: " + (sayi1 + sayi2));
            }
            else if (sonuc == "-")
            {
                Console.WriteLine("Yapılan işlem sonucu: " + (sayi1 - sayi2));
            }

            else if (sonuc == "*")
            {
                Console.WriteLine("Yapılan işlem sonucu: " + (sayi1 * sayi2));
            }

            else if (sonuc == "/")
            {
                Console.WriteLine("Yapılan işlem sonucu: " + (sayi1 / sayi2));
            }
            Console.ReadLine();

        }

    }
}
