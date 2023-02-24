#region Girilen sayının tek mi çift mi olduğunu bulan console uygulaması
int sayi;
Console.WriteLine("Lütfen bir sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir");
}
else
{
    Console.WriteLine("Girilen sayı tektir");
}
Console.ReadLine();
#endregion