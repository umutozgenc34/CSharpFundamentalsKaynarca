// C# da karar yapıları belirli bir koşulun doğru (true) veya yanlış (false) olmasına göre farklı işlemler gerçekleştirmemizi sağlar. 
// Bu yapılar, programın akışını kontrol etmek ve belirli koşullara bağlı olarak farklı kod bloklarını çalıştırmak için kullanılır.
// C# dilinde bu yapıların temeli if, else if, else, switch, ternary gibi ifadelerle atılır.

// *** if ***

// if ifadesi, belirli bir koşulun doğru olup olmadığını kontrol eder.
// Eğer koşul doğruysa, if bloğundaki kod çalıştırılır.

// if (koşul)
//{
// Koşul doğruysa çalışacak kod
//}

// Örnek: 

//int sayi = 10;

//if (sayi > 5)
//{
//    Console.WriteLine("Sayı 5'ten büyüktür.");
//}

// *** else ***
// else ifadesi, if koşulu yanlış olduğunda çalışacak kod bloğunu tanımlar.
// Eğer if koşulu yanlışsa, else bloğundaki kod çalıştırılır.

// ÖRNEK: 

//Console.WriteLine("Yaşınızı giriniz");
//int yas = Convert.ToInt32(Console.ReadLine());

//if (yas >= 18)
//{
//    Console.WriteLine("Ehliyet alabilirsiniz.");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamazsınız.");
//}

// Yukarıdaki örnekte, kullanıcıdan yaş bilgisi alınıyor ve eğer yaş 18 veya daha büyükse "Ehliyet alabilirsiniz."
// mesajı, aksi halde "Ehliyet alamazsınız." mesajı gösteriliyor.

// ÖRNEK : 

//Console.WriteLine("1. Yazılıyı giriniz");
//int yazili1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. Yazılıyı giriniz");
//int yazili2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3. Yazılıyı giriniz");
//int yazili3 = Convert.ToInt32(Console.ReadLine());
//int ortalama = (yazili1 + yazili2 + yazili3) / 3;

//if(ortalama >= 50)
//{
//    Console.WriteLine($"Ortalamanız : {ortalama}. Geçtiniz :)");
//}
//else
//{
//    Console.WriteLine($"Ortalmaanız : {ortalama}.  Kaldınız");
//}

// Yukarıdaki örnekte üç yazılı notu alınıyor ve ortalaması hesaplanıyor.
// Eğer ortalama 50 veya daha büyükse "Geçtiniz" mesajı, aksi halde "Kaldınız" mesajı gösteriliyor.

// ÖRNEK :

//Console.WriteLine("Bir sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//if (sayi % 2 == 0)
//{
//    Console.WriteLine("Sayı çifttir.");
//}
//else
//{
//    Console.WriteLine("Sayı tektir.");
//}

// Yukarıdaki örnekte, kullanıcıdan bir sayı alınıyor ve bu sayının çift mi yoksa tek mi olduğu kontrol ediliyor.
// Eğer sayı çiftse "Sayı çifttir." mesajı, tekse "Sayı tektir." mesajı gösteriliyor.

// *** else if ***

// else if ifadesi, birden fazla koşulu kontrol etmek için kullanılır.
// Eğer if koşulu yanlışsa, else if bloğundaki koşul kontrol edilir.
// Eğer else if koşulu doğruysa, o bloğun kodu çalıştırılır.
// Eğer tüm if ve else if koşulları yanlışsa, son olarak else bloğu çalıştırılır.

// ÖRNEK:

//Console.WriteLine("Sıcaklık değerini giriniz");
//int sicaklik = Convert.ToInt32(Console.ReadLine());

//if (sicaklik < 10)
//{
//    Console.WriteLine("Dışarı çıkarken mont giyin.");
//}else if (sicaklik >= 11 && sicaklik < 20)
//{
//    Console.WriteLine("Dışarı çıkarken ceket giyin.");
//}else if (sicaklik >= 21 && sicaklik < 35)
//{
//    Console.WriteLine("Dışarı çıkarken tişört giyin.");
//}
//else
//{
//    Console.WriteLine("Dışarı çıkmasan daha iyi olur gibi :)");
//}

// Yukarıdaki örnekte, kullanıcıdan sıcaklık değeri alınıyor ve bu değere göre giyinme önerileri yapılıyor.
// Eğer sıcaklık 10 dereceden düşükse mont, 11-20 arası ise ceket, 21-35 arası ise tişört giyilmesi öneriliyor.
// Eğer sıcaklık 35 dereceden yüksekse dışarı çıkmaması öneriliyor.
