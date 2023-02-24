#region Bir mağazadan alınan ürünlerde 100 TL ve üzerinde kargo bedava, 100 TL altında 20 lira kargo ücreti alınmaktadır. Kullanıcıdan alınan toplam ödemeye göre ödenmesi gereken tutarı gösteren console uygulaması
int fiyat, toplam;
Console.WriteLine("Lütfen ürünün fiyatını giriniz:");
fiyat = Convert.ToInt32(Console.ReadLine());
toplam = fiyat + 20;
if (fiyat >= 100)
{
    Console.WriteLine("Toplam ödemeniz gereken tutar: " + fiyat);
}
else
{
    Console.WriteLine("Toplam ödemeniz gereken tutar: " + toplam);
}
Console.ReadLine();
#endregion