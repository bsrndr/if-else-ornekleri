#region Klavyeden kullanıcı tarafından TL cinsinden para miktarını, yine kullanıcı tarafından girilen Euro ve Dolar kuruna göre TL'nin kaç Euro ve kaç Dolar olduğunu bulan programı yazınız.

double para, eurotopla, dolartopla, dolar, euro;
Console.WriteLine("Lütfen dolar kuru giriniz: ");
dolar = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Lütfen euro kuru giriniz: ");
euro = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Lütfen TL cinsinden para miktarı giriniz: ");
para = Convert.ToDouble(Console.ReadLine());
dolartopla = dolar / para;
eurotopla = euro / para;
Console.WriteLine("Girdiğiniz TL miktarının dolar karşılığı: " + dolartopla + "\nGirdiğiniz TL miktarının euro karşılığı:" + eurotopla);
Console.ReadLine();

#endregion