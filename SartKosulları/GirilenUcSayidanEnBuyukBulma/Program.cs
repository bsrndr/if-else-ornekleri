#region Girilen 3 sayıdan en büyüğünü bulan console uygulaması

int sayi1, sayi2, sayi3, enbuyuk;
Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
sayi3 = Convert.ToInt32(Console.ReadLine());
enbuyuk = sayi1;

if (sayi2 > enbuyuk)
{
    enbuyuk = sayi2;
}
if (sayi3 > enbuyuk)
{
    enbuyuk = sayi3;
}
Console.WriteLine("En büyük sayı: " + enbuyuk);
Console.ReadLine();

//2.yöntem

if (sayi1 > sayi2)
{
    if (sayi1 > sayi3)
    {
        Console.WriteLine("En büyük sayı birinci sayıdır");
    }

}
if (sayi2 > sayi1)
{
    if (sayi2 > sayi3)
    {
        Console.WriteLine("En büyük sayı ikinci sayıdır");
    }

}
if (sayi3 > sayi1)
{
    if (sayi3 > sayi2)
    {
        Console.WriteLine("En büyük sayı üçüncü sayıdır");
    }

}
Console.ReadLine();
#endregion