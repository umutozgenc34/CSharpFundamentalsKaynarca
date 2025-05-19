// Proje isimlendirmesinde Türkçe karakterler kullanılmamalıdır.
// C# Case sensitive (Büyük küçük harf duyarlı) bir dildir.
// C# dilinde kod yazarken yazdığımız kodlar, derleyici tarafından okunur ve işlenir.
// C# dilinde aldığımız hatalar Error
// C# dilinde kod yazarken, yazdığımız kodları bitirmek için noktalı virgül (;) kullanırız.
// C# dilinde kod yazarken, kodları gruplamak için süslü parantezler ({}) kullanırız.
// C# dilinde kodlarımızı çalıştırmak için bir "Main" metodu kullanırız.
// .NET6 ve üzeri sürümlerde "Main" metodu "Program" sınıfının içinde gizlenmiş halde yer alır.
// Yanlış yazdığımız kodları geri almak için "Ctrl + Z" tuş kombinasyonunu kullanabiliriz.
// Snippet sık kullanılan kod bloklarını hızlıca eklemeyi sağlayan bir Visual Studio özelliğidir.

// **** KONSOLA YAZDIRMA ****

Console.WriteLine("Hello, World!"); // Konsola "Hello, World!" yazdırır ve ardından bir satır aşağı iner.

Console.WriteLine("Umut");  // Birinci satıra "Umut" yazdırır ve ardından bir satır aşağı iner.
Console.WriteLine("Özgenç");  // İkinci satıra "Özgenç" yazdırır.
                              // output : Umut
                             //           Özgenç
Console.Write("Umut");
Console.Write("Özgenç"); // Konsola "Umut" ve "Özgenç" bitişik yazdırır ve ardından bir satır aşağı inmez.
                         // output : UmutÖzgenç
// Yazdığımız bir kod satırından bir tane daha hızlıca eklemek
// için o satıra bir kez tıklayıp "CTRL + D" tuş kombinasyonunu kullanabiliriz.
// Snippet Örnek : cw + tab tuşlayarak Console.WriteLine() kodunu hızlıca ekleyebiliriz.

// **** YORUM SATIRLARI ****
// C# dilinde yorum satırları  kodun derlenmesini etkilemeyen,
// sadece geliştiricinin anlaması için yazılan açıklamalardır.

// Tek satırlık yorum satırı için "//" kullanılır.
// Örnek : // Console.WriteLine("Hello, World!"); // Bu satır konsola "Hello, World!" yazdırır.
// Çok satırlık yorum satırı için "/*" ile başlar ve "*/" ile biter.
// Örnek : 

/*
Bu birden fazla satır
kapsayan bir yorumdur
*/

// Yorum satırına TODO: yazılırsa bu satırın yapılması gereken bir iş olduğunu belirtir.
// ve TaskList penceresinde görünür.

// Mouse ile seçtiğimiz satırları CTRL + KC kısa yolu ile yorum satırı haline getirebiliriz.
// Aynı şekilde eçtiğimiz yorum satırlarını CTRL + KU kısa yolu ile yorum satırından çıkarabiliriz.