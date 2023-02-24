#region Klavyeden kullanıcı tarafından dik kenarları girilen bir üçgenin alanını hesaplayan program.
//Klavyeden kullanıcı tarafından dik kenarları girilen bir üçgenin alanını hesaplayan program.
int taban;
double yükseklik, alan;
Console.WriteLine("Lütfen taban uzunluğunu giriniz:");
taban = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yüksekliği giriniz:");
yükseklik = Convert.ToDouble(Console.ReadLine());
alan = (taban * yükseklik) / 2;
Console.WriteLine("Alan: " + alan);
Console.ReadLine();
#endregion