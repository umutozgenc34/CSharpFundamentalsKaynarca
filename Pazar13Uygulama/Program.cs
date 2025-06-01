//Console.WriteLine("Bir sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi < 0)
//{
//    Console.WriteLine("Girdiğiniz sayı negatiftir.");
//}
//else if (sayi > 0)
//{
//    Console.WriteLine("Girdiğniiz sayı pozitiftir");
//}
//else if (sayi == 0)
//{
//    Console.WriteLine("Girdiğiniz sayı 0 dır.");
//}


using System.ComponentModel.Design.Serialization;

Console.WriteLine("***** HESAP MAKİNESİ *****");
Console.WriteLine("Lütfen Birinci sayıyı gir");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lüten İkinci sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz \n" +
                  "/ , * , + , - ");

string islem = Console.ReadLine();
if (islem == "+")
{
    int toplam = sayi1 + sayi2;
    Console.WriteLine($"Sayıların toplamı : {toplam}");
}
else if (islem == "-")
{
    int cikar = sayi1 - sayi2;
    Console.WriteLine($"Sayıların farkı : {cikar}");
}
else if (islem == "*")
{
    int carpim = sayi1 * sayi2;
    Console.WriteLine($"Sayıların çaprımı : {carpim}");
}else if (islem == "/")
{
    int bolum = sayi1 / sayi2;
    Console.WriteLine($"Sayıların bolumu : {bolum}");
}
else
{
    Console.WriteLine("Lütfen geçerli bir işlem giriniz");
}
