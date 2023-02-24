#region Kullanıcı şifreyi doğru girdiğinde “Giriş Başarılı”, yanlış girdiğinde “Girdiğiniz şifre hatalı” yazdıran console uygulaması
string sifre = "abc";
string girilensifre;
Console.WriteLine("Lütfen şifrenizi giriniz: ");
girilensifre = Console.ReadLine();

if (sifre == girilensifre)
{
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("Girdiğiniz şifre hatalı");
}
Console.ReadLine();
#endregion