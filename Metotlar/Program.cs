// ************ METOTLAR (Methods) ************

// Metotlar, bir işi yapan kod bloklarıdır.
// Kodlarımızı daha düzenli, tekrar kullanılabilir ve okunabilir hale getirirler.

// Yani aynı işi birden fazla yerde yapacaksak, bu işi bir metot haline getirip her yerde onu çağırabiliriz.

//C# 9 (.NET5 sonrası)ile gelen top-level statements özelliği sayesinde metotları önce çağırıp sonra tanımlayabiliyoruz.
//Ama klasik C# yapısında bu hata verir.

// *** Metotları Neden Kullanmalıyız? ***

// - Kod tekrarını önler.
// - Kod daha düzenli olur.
// - Hataları bulmak ve düzeltmek kolaylaşır.
// - Kodun okunabilirliği artar.

// Metotlar ikiye ayrılır:
// 1. Geriye değer döndürmeyen metotlar (void olarak tanımlanır)
// 2. Geriye değer döndüren metotlar (return kullanır)


// *** 1. Geriye Değer Döndürmeyen Metot (void) ***

// Bu metotlar bir işlem yapar ama bize sonuç vermez. Yani sadece görevi yapar, sonucunu geri göndermez.
// Metot tanımında void anahtar kelimesi kullanılır.

// Söz dizimi:
// void MetotAdi()
// {
//     // Yapılacak işlemler
// }

// ÖRNEK:
// Ekrana "Merhaba!" yazdıran bir metot

//Metodu çağırmak:
//MerhabaYaz();

//Metodu tanımlamak:
//void MerhabaYaz()
//{
//    Console.WriteLine("Merhaba!");
//}


// ÖRNEK:
// Kullanıcının ismini alıp ekrana yazdıran metot

//void IsimYaz()
//{
//    Console.WriteLine("Adınızı giriniz:");
//    string ad = Console.ReadLine();
//    Console.WriteLine($"Merhaba {ad}!");
//}

//IsimYaz();


// *** 2. Geriye Değer Döndüren Metot (return) ***

//Bu metotlar bir işlem yapar ve sonucunu bize geri verir. Yani bize bir bilgi veya veri gönderir.
//Metot tanımında int, string, bool, double vs. veri türleri kullanılır ve return ile değer döndürülür.

// Söz dizimi:
// veri_tipi MetotAdi()
// {
//     // İşlemler
//     return değer;
// }

// ÖRNEK:
// 2 sayıyı toplayıp sonucu döndüren metot

//int Topla()
//{
//    int sayi1 = 5;
//    int sayi2 = 7;
//    int sonuc = sayi1 + sayi2;
//    return sonuc;
//}

//Console.WriteLine("Toplam: " + Topla());


// ÖRNEK:
// Kullanıcının yaşını alıp geri döndüren metot

//int YasAl()
//{
//    Console.WriteLine("Yaşınızı giriniz:");
//    int yas = Convert.ToInt32(Console.ReadLine());
//    return yas;
//}

//int kullaniciYas = YasAl();
//Console.WriteLine($"Yaşınız: {kullaniciYas}");


// *** Parametre Alan Metotlar ***

// Metotlara dışarıdan veri gönderebiliriz. Bu verilere *parametre* denir.

// Söz dizimi:
// void MetotAdi(veri_tipi parametre1, veri_tipi parametre2)
// {
//     // İşlemler
// }

// ÖRNEK:
// Verilen ismi ekrana yazan metot ** parametre alan ve geriye değer döndürmeyen metot örneği

//IsimYaz("Umut");

//void IsimYaz(string isim)
//{
//    Console.WriteLine($"Merhaba {isim}!");
//}


// ÖRNEK:
// İki sayıyı alıp toplayan ve sonucu döndüren metot ** parametre alan ve geriye değer döndüren metot örneği

//int Topla(int sayi1, int sayi2)
//{
//    return sayi1 + sayi2;
//}

//int sonuc = Topla(10, 20);
//Console.WriteLine("Toplam: " + sonuc);


// ÖRNEK:
// Verilen sayı çift mi tek mi onu kontrol edip sonucu döndüren metot

//string CiftMiTekMi(int sayi)
//{
//    if (sayi % 2 == 0)
//    {
//        return "Çift";
//    }
//    else
//    {
//        return "Tek";
//    }
//}

//Console.WriteLine(CiftMiTekMi(7));  // Tek
//Console.WriteLine(CiftMiTekMi(8));  // Çift


// *** KISA ÖZET ***
// 1. void → işlem yapar, sonuç döndürmez.
// 2. return → işlem yapar ve sonuç verir.
// 3. Parametre → metot dışarıdan veri alır.
// 4. C# 9+ ile metodu önce çağırıp sonra tanımlayabilirsin (top-level).