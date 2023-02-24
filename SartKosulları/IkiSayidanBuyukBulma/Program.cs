#region Girilen iki sayıdan büyük olanı bulan program

int sayi1, sayi2;
Console.WriteLine("Lütfen ilk sayıyı giriniz:");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
sayi2 = Convert.ToInt32(Console.ReadLine());
if (sayi1 > sayi2)
{
    Console.WriteLine("Sayı-1 sayı-2 den büyüktür");
}
else if (sayi1 < sayi2)
{
    Console.WriteLine("Sayı-2 sayı-1 den büyüktür");
}
else if (sayi1 == sayi2)
{
    Console.WriteLine("Sayı-1 sayı-2 eşittir");
}
Console.ReadLine();
#endregion