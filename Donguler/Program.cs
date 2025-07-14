// ************ DÖNGÜLER (Loops) ************

// C# dilinde döngüler, bir kod parçasının tekrar tekrar çalışmasını sağlamak için kullanılır.
// Yani, bir koşul sağlandığı sürece aynı işlemi tekrar yapmayı sağlarlar. C#'ta 4 tür döngü vardır:

// 1. for döngüsü
// 2. while döngüsü
// 3. do-while döngüsü
// 4. foreach döngüsü

//***** 1. for Döngüsü *****

// for döngüsü belirli bir koşul sağlandığı sürece kodun tekrar çalışmasını sağlar.
// Bu döngüde genellikle bir sayacı artırarak veya azaltarak belirli bir sayıda tekrar yapılır.
// Aşağıda for döngüsünü söz dizimi ve örnek bir kullanımı verilmiştir.

//for (başlangıç_değeri; koşul; artış_veya_azalış)
//{
//    // Döngü bloğu
//}

// ÖRNEK: 
// 1'den 10'a kadar olan sayıları ekrana yazdıran bir for döngüsü

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

// int i = 1; burada döngüye başlarken i değişkeni 1 olarak başlatıldı.
// i <= 10; koşulu, döngü devam etmeden önce i'nin 10'a kadar olup olmadığını kontrol eder.
// i++; ifadesi, her döngü sonunda i'nin 1 artmasını sağlar.


// ÖRNEK:
// 1'den 10'a kadar olan sayıların toplamını hesaplayan bir for döngüsü

//int toplam = 0;
//for (int i = 1; i <= 10; i++)
//{
//    toplam += i; // toplam = toplam + i;
//}
//Console.WriteLine($"1'den 10'a kadar olan sayıların toplamı: {toplam}");

// ÖRNEK:
// 1 ile 100 arasındaki tek sayıları yazdıran for döngüsü

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 != 0)  
//    {
//        Console.WriteLine(i);
//    }
//}

// ÖRNEK: 
// Bir kelimenin her harfini ayrı satırlarda yazdıran for döngüsü

//string kelime = "Umut";
//for (int i = 0; i < kelime.Length; i++)
//{
//    Console.WriteLine(kelime[i]);
//}

// ÖRNEK:
// Bir dizinin elemanlarını for döngüsü ile yazdırma

//string[] meyveler = { "Elma", "Armut", "Muz", "Çilek" };
//for (int i = 0; i < meyveler.Length; i++)
//{
//    Console.WriteLine(meyveler[i]);
//}

// ÖRNEK:
// Bir dizinin elemanlarının toplamını for döngüsü ile hesaplama

//int[] dizi = { 1, 2, 3, 4, 5 };
//int toplam = 0;

//for (int i = 0; i < dizi.Length; i++)
//{
//    toplam += dizi[i];
//}

//Console.WriteLine("Dizinin elemanlarının toplamı: " + toplam);

// ÖRNEK:
// Kullanıcıdan 5 sayı alıp ortalmasını alma for döngüsü ile

//int toplam = 0;

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine("Lütfen bir sayı giriniz.");
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    toplam += sayi;
//}

//int ortalama = toplam / 5;
//Console.WriteLine($"Sayıların ortalaması {ortalama}");


// **** 2. foreach *****

// foreach döngüsü, bir koleksiyonun (dizi, liste, vb.) elemanlarını tek tek dolaşmak için kullanılır.
// Bu döngü, koleksiyonun her bir elemanını otomatik olarak alır ve belirli bir işlem yapar.
// Söz dizimi şu şekildedir:
// foreach (veri_tipi eleman in koleksiyon)
// {
//     // Döngü bloğu
// }

// ÖRNEK:
// Bir dizinin elemanlarını foreach döngüsü ile yazdırma
//string[] meyveler = { "Elma", "Armut", "Muz", "Çilek" };
//foreach (string meyve in meyveler)
//{
//    Console.WriteLine(meyve);
//}

// ÖRNEK:
// Bir dizinin elemanlarının toplamını foreach döngüsü ile hesaplama
//int[] dizi = { 1, 2, 3, 4, 5 };
//int toplam = 0;
//foreach (int eleman in dizi)
//{
//    toplam += eleman;
//}
//Console.WriteLine("Dizinin elemanlarının toplamı: " + toplam);

// ÖRNEK:
// Rastgele sayıların olduğu dizi de pozitif , negatif ve sıfır sayıları ayırma
// negatif ve pozitif sayıların toplamını hesaplama

//int[] sayilar = { 1, -2, 3, 0, -5, 6, 0, -1 };
//int negatifToplam = 0;
//int pozitifToplam = 0;

//foreach (int sayi in sayilar)
//{
//    if (sayi > 0)
//    {
//        Console.WriteLine($"{sayi} pozitif bir sayıdır.");
//        pozitifToplam += sayi;
//    }
//    else if (sayi < 0)
//    {
//        Console.WriteLine($"{sayi} negatif bir sayıdır.");
//        negatifToplam += sayi;
//    }
//    else
//    {
//        Console.WriteLine($"{sayi} sıfırdır.");
//    }

//}

//Console.WriteLine($"Negatif toplam : {negatifToplam}");
//Console.WriteLine($"Pozitif toplam : {pozitifToplam}");

// *** 3. while Döngüsü ***

// while döngüsü, belirli bir koşul sağlandığı sürece kodun tekrar çalışmasını sağlar.
// Bu döngüde koşul, döngü başlamadan önce kontrol edilir.

// Söz dizimi şu şekildedir:

// while (koşul)
// {
//     // Döngü bloğu
// }

// ÖRNEK:
// 1'den 10'a kadar olan sayıları ekrana yazdıran bir while döngüsü
//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i++; // i'yi 1 artır
//}

// ÖRNEK:
// 1'den 10'a kadar olan sayıların toplamını hesaplayan bir while döngüsü
//int toplam = 0;
//int i = 1;
//while (i <= 10)
//{
//    toplam += i; // toplam = toplam + i;
//    i++; // i'yi 1 artır
//}

//Console.WriteLine($"1'den 10'a kadar olan sayıların toplamı: {toplam}");

// ÖRNEK:
// Doğru şifre girilene kadar kullanıcıdan şifre alan döngü 

//string dogruSifre = "1234";
//string kullanicidanSifre = "";

//while(dogruSifre != kullanicidanSifre)
//{
//    Console.WriteLine("Lütfen şifre giriniz");
//    kullanicidanSifre = Console.ReadLine();

//    if (dogruSifre!= kullanicidanSifre)
//    {
//        Console.WriteLine("Hatalı şifre tekrar deneyiniz");
//    }
//}

//Console.WriteLine("Doğru şifre");

// *** 4. do-while Döngüsü ***

// do-while döngüsü, koşul sağlansa da sağlanmasa da döngü bloğunun en az bir kez çalışmasını sağlar.
// Çünkü önce döngü bloğu çalışır, ardından koşul kontrol edilir.

// Söz dizimi şu şekildedir:

// do
// {
//     // Döngü bloğu
// }
// while (koşul);

// ÖRNEK:
// 1'den 10'a kadar olan sayıları yazdıran bir do-while döngüsü

//int i = 1;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i <= 10);

// ÖRNEK:
// Kullanıcı doğru şifreyi girene kadar şifre isteyen bir do-while döngüsü

//string dogruSifre = "1234";
//string kullanicidanSifre;

//do
//{
//    Console.WriteLine("Lütfen şifre giriniz:");
//    kullanicidanSifre = Console.ReadLine();

//    if (kullanicidanSifre != dogruSifre)
//    {
//        Console.WriteLine("Hatalı şifre, tekrar deneyiniz.");
//    }

//} while (kullanicidanSifre != dogruSifre);

//Console.WriteLine("Doğru şifre");

// ÖRNEK:
// Kullanıcıdan sayı almaya devam eden ve negatif sayı girildiğinde döngüden çıkan program

//int sayi;
//do
//{
//    Console.WriteLine("Bir sayı giriniz (negatif sayı girerseniz çıkılır):");
//    sayi = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Girdiğiniz sayı: {sayi}");

//} while (sayi >= 0);

//Console.WriteLine("Negatif sayı girildi, program sonlandı.");