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