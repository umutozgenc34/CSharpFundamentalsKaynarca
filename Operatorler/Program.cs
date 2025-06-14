﻿// *** OPERATORLER ***

// Operatörler, programlama dillerinde değişkenler üzerinde işlem yapmamızı sağlayan sembollerdir.

// Operatörler, matematiksel işlemler, karşılaştırmalar ve mantıksal işlemler gibi birçok farklı işlevi yerine getirebilir.

// 1. Aritmetik Operatörler
// Aritmetik operatörler, sayısal değerler üzerinde matematiksel işlemler yapmamızı sağlar. En yaygın aritmetik operatörler şunlardır:

// + , - , * , / , % , ++ , --

// int a = 10;
// int b = 5;
// int toplam = a + b; // Toplama output : 15
// int fark = a - b; // Çıkarma output : 5
// int carpim = a * b; // Çarpma output : 50
// int bolum = a / b; // Bölme output : 2
// int kalan = a % b; // Modül output : 0  % işareti mod alma işlemini sağlar 10 bölü 5 işleminde kalan 0'dır.
// a++; // Artırma output : 11
// b--; // Azaltma output : 4

// 2. Karşılaştırma Operatörleri
// Karşılaştırma operatörleri, iki değeri karşılaştırarak boolean (true/false) sonuçlar döndürür. En yaygın karşılaştırma operatörleri şunlardır:

// == , != , > , < , >= , <=

// int x = 10;
// int y = 20;

// bool esitMi = (x == y); // Eşitlik kontrolü output : false
// bool farkliMi = (x != y); // Farklılık kontrolü output : true
// bool buyukMu = (x > y); // Büyüklük kontrolü output : false
// bool kucukMu = (x < y); // Küçüklük kontrolü output : true
// bool buyukEsitMi = (x >= y); // Büyüklük veya eşitlik kontrolü output : false
// bool kucukEsitMi = (x <= y); // Küçüklük veya eşitlik kontrolü output : true

// 3. Mantıksal Operatörler
// Mantıksal operatörler, boolean değerler üzerinde işlem yapmamızı sağlar. En yaygın mantıksal operatörler şunlardır:

// && , || , !

//AND (&&) - Ve Operatörü
//İki koşulun da true olması gerekir.
// bool sonuc = (5 > 3) && (10 > 7);  // true
// bool sonuc2 = (5 > 3) && (10 < 7); // false

//OR (||) - Veya Operatörü
//En az bir koşulun true olması yeterlidir.
// bool sonuc = (5 > 3) || (10 < 7);  // true
// bool sonuc2 = (5 < 3) || (10 < 7); // false

//NOT (!) - Değil Operatörü
//Bir koşulun tersini alır.
// bool sonuc = !(5 > 3); // false

// 4.Atama Operatörleri

// Atama operatörleri, bir değişkene değer atamak için kullanılır. En yaygın atama operatörü = işaretidir.

// = , += , -= , *= , /= , %=

//int a = 10;

// a += 5; // a = a + 5; output : 15
// a -= 3; // a = a - 3; output : 12
// a *= 2; // a = a * 2; output : 20
// a /= 4; // a = a / 4; output : 2
// a %= 3; // a = a % 3; output : 1

// 5. Bit Düzeyinde Operatörler -- Şimdi Değil --


// UYGULAMALAR

// ÖRNEK : x değerini y ye y değerini x e atayan algoritma (ek bir değişken oluşturarak)

// int x = 5;
// int y = 10;
// int z = y; // z değişkeni y değerini tutar
// y = x; // y değişkeni x değerini alır
// x = z; // x değişkeni z değerini alır (y'nin eski değeri)

// Console.WriteLine(x); -> output : 10
// Console.WriteLine(y); -> output : 5


// ÖRNEK: Karenin çevresini hesaplayan algoritma
// Karenin çevresi, kenar uzunluğunun 4 katıdır.

// Console.WriteLine("Karenin kenar uzunluğunu giriniz:");
// int kenarUzunlugu = Convert.ToInt32(Console.ReadLine()); -> kullanıcıdan alına değer 5 varsayalım
// int cevre = 4 * kenarUzunlugu; // Karenin çevresi 4 * kenar uzunluğu // output : 20
// Console.WriteLine($"Karenin çevresi {cevre}"); -> output : Karenin çevresi 20

// ÖRNEK: Dikdörtgenin çevresini hesaplayan algoritma
// Dikdörtgenin çevresi (2 * (uzunluk + genişlik)) formülü ile hesaplanır.

// Console.WriteLine("Dikdörtgenin uzun kenarını giriniz:");
//int uzunKenar = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alına değer 10 varsayalım
// Console.WriteLine("Dikdörtgenin kısa kenarını giriniz:");
// int kisaKenar = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alına değer 5 varsayalım
// int cevre = 2 * (uzunKenar + kisaKenar); // Dikdörtgenin çevresi 2 * (uzun kenar + kısa kenar) // output : 30
// Console.WriteLine($"Dikdörtgenin çevresi {cevre}"); // output : Dikdörtgenin çevresi 30

// ÖRNEK: Karenin alanını hesaplayan algoritma
// Karenin alanı, kenar uzunluğunun karesidir.

// Console.WriteLine("Kenar uzunluğunu giriniz");
// int kenar = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alına değer 5 varsayalım
// int alan = kenar * kenar;  // output : 25
// Console.WriteLine($"Karenin alanı {alan}"); // output : Karenin alanı 25

// ÖRNEK: Dikdörtgenin alanını hesaplayan algoritma
// Dikdörtgenin alanı (uzunluk * genişlik) formülü ile hesaplanır.

// Console.WriteLine("Dikdörtgenin uzun kenarını giriniz");
// int uzunKenar = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alına değer 10 varsayalım
// Console.WriteLine("Dikdörtgenin kısa kenarını giriniz");
// int kisaKenar = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alına değer 5 varsayalım
// int alan = uzunKenar * kisaKenar; // Dikdörtgenin alanı (uzun kenar * kısa kenar) // output : 50
// Console.WriteLine($"Dikdörtgenin alanı {alan}"); // output : Dikdörtgenin alanı 50

