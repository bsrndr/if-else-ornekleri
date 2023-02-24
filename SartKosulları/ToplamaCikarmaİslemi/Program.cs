#region Kullanıcıdan alınan iki sayıyı, önce Toplama işlemi yapıp ekrana yazdırınız, sonra Çıkarma işlemi yapıp ekrana yazdırınız.
//Kullanıcıdan alınan iki sayıyı, önce Toplama işlemi yapıp ekrana yazdırınız, sonra Çıkarma işlemi yapıp ekrana yazdırınız.
int sayi1, sayi2, topla, cikar;
Console.WriteLine("Lütfen birinci sayıyı giriniz:");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
sayi2 = Convert.ToInt32(Console.ReadLine());
topla = sayi1 + sayi2;
Console.WriteLine("iki sayının toplamı: " + topla);
cikar = sayi1 - sayi2;
Console.WriteLine("iki sayının farkı: " + cikar);
Console.ReadLine();
#endregion