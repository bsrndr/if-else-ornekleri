#region //Girilen sayının kaç basamaklı olduğunu bulan console uygulaması. (En fazla 4 basamaklı sayıya kadar)
//Girilen sayının kaç basamaklı olduğunu bulan console uygulaması. (En fazla 4 basamaklı sayıya kadar)

int sayi;
Console.WriteLine("Lütfen bir sayı giriniz");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi < 10)
{
    Console.WriteLine("1 basamaklı");
}
else if (sayi < 100)
{
    Console.WriteLine("2 basamaklı");
}
else if (sayi < 1000)
{
    Console.WriteLine("3 basamaklı");
}
else if (sayi < 10000)
{
    Console.WriteLine("4 basamaklı");
}
else
{
    Console.WriteLine("Kural dışı bir sayı girdiniz");
}
Console.ReadLine();
#endregion
