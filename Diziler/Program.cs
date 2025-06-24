// *** DİZİLER (ARRAYS) ***

// Diziler sabit boyutlu veri yapılarıdır.
// aynı türden birden fazla veriyi tek bir değişken altında saklamamızı sağlar.
// bellekte ardışık olarak saklanır ve her bir elemanına indeks numarası ile erişilir.
// C# dilinde diziler sıfırdan başlayarak indekslenir.
// Diziler sabit boyutlu oldukları için oluşturulduktan sonra boyutları değiştirilemez.
// Diziler, C# dilinde "[]" sembolü ile tanımlanır.
// Diziler, C# dilinde "new" anahtar kelimesi ile de oluşturulur.
// C# dilinde "Length" özelliği ile dizilerin boyutları öğrenilebilir.

//  "foreach(en yaygin yontem)" ve "for" döngüsü ile elemanlarına erişilebilir.

// "Array" sınıfı ile kullanılabilir.
// "Array.Sort()" metodu ile sıralanabilir.
// "Array.Reverse()" metodu ile tersine çevrilebilir.
// "Array.IndexOf()" metodu ile eleman aranabilir.
// "Array.Copy()" metodu ile kopyalanabilir.
// "Array.Resize()" metodu ile boyutları değiştirilebilir. -> yeni bir dizi oluşturularak
// "Array.Clear()" metodu ile elemanları temizlenebilir.

// ÖRNEK : 
//string[] isimler = {"Umut", "Ali", "Ayşe", "Fatma", "Mehmet"};
//Console.WriteLine("Dizinin Boyutu: " + isimler.Length); // isimler.Length ile dizinin boyutunu öğreniyoruz.
//Console.WriteLine("İlk Eleman: " + isimler[0]); // isimler[0] ile dizinin ilk elemanına erişiyoruz.
//Console.WriteLine("Son Eleman: " + isimler[isimler.Length - 1]); // isimler[isimler.Length - 1] ile dizinin son elemanına erişiyoruz.

//Array.Sort(isimler);  //isimler dizisini alfabetik sıralar.
//Array.Clear(isimler, 0, isimler.Length); // isimler dizisini temizler.
//Array.Reverse(isimler); // isimler dizisini tersine çevirir.
//Array.IndexOf(isimler, "Ali"); // isimler dizisinde "Ali" elemanının indeksini bulur.

// ÖRNEK : 
// int [] sayilar = {1, 2, 3, 4, 5};
// Her veri tipinden dizi oluşturulabilir.

// ÖRNEK : -> dizinin tüm elemanlarını yazdıran foreach döngüsü ve new anahtar sözcüğü ile örnek

// string[] meyveler = new string[5]; // 5 elemanlı bir string dizisi oluşturur.
// meyveler[0] = "Elma"; // dizinin ilk elemanına "Elma" değerini atar.
// meyveler[1] = "Armut"; // dizinin ikinci elemanına "Armut" değerini atar.
// meyveler[2] = "Muz"; // dizinin üçüncü elemanına "Muz" değerini atar.
// meyveler[3] = "Çilek"; // dizinin dördüncü elemanına "Çilek" değerini atar.
// meyveler[4] = "Kivi"; // dizinin beşinci elemanına "Kivi" değerini atar.

// Console.WriteLine("Meyve Listesi:");

// foreach (string meyve in meyveler) // foreach döngüsü ile dizinin elemanlarını yazdırır.
// {
//     Console.WriteLine(meyve); // her bir meyve elemanını yazdırır.
// }

// ÖRNEK :  -> for döngüsü  ile dizinin elemanlarını yazdıran örnek

// int[] sayilar = new int[5]; // 5 elemanlı bir int dizisi oluşturur.

// sayilar[0] = 10; // dizinin ilk elemanına 10 değerini atar.
// sayilar[1] = 20; // dizinin ikinci elemanına 20 değerini atar.
// sayilar[2] = 30; // dizinin üçüncü elemanına 30 değerini atar.
// sayilar[3] = 40; // dizinin dördüncü elemanına 40 değerini atar.
// sayilar[4] = 50; // dizinin beşinci elemanına 50 değerini atar.

// Console.WriteLine("Sayı Listesi:");

// for(int i = 0; i < sayilar.Length; i++) // for döngüsü ile dizinin elemanlarını yazdırır.
// {
//     Console.WriteLine(sayilar[i]); // her bir sayi elemanını yazdırır.
// }



