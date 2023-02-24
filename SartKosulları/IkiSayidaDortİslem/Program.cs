#region Kullanıcının yapmış olduğu seçime göre girmiş olduğu 2 sayıyı toplayan, çıkaran, çarpan veya bölme işlemi yapan uygulama.

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

//2.yöntem
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