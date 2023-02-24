#region Klavyeden girilen su sıcaklığına göre katı, sıvı yada gaz yazdıran console uygulaması
int sicaklik;
Console.WriteLine("Lütfen sıcaklık giriniz: ");
sicaklik = Convert.ToInt32(Console.ReadLine());

if (sicaklik < 0)
{
    Console.WriteLine("katı");
}
else if (sicaklik >= 100)
{
    Console.WriteLine("Gaz");
}
else
{
    Console.WriteLine("Sıvı");
}
Console.ReadLine();
#endregion