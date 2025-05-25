//Değişkenler bir bilginin bellekteki konumunu temsil eden sembolik isimlerdir.
//Program çalıştırıldığında değişkene ve bu değişkenin türüne göre bellekte yer ayrılır.

// Değişkenler veri türü + değişken adı = değer şeklinde tanımlanır.
// örnek: int(veri türü) sayi(isteğe bağlı değişken adı) = 10(değer);

// ***TEMEL VERİ TÜRLERİ***
// C# dilinde temel olarak veri tipleri ikiye ayrılır.

// 1. Değer Tipi (Value Type) 

// Değer tipleri RAM' in stack bölgesinde tutulur.
// Değer tipleri, değişkenin kendisinde veriyi tutar.
// Bir değişkene atandığında, değeri kopyalanır.

// Değer tipleri :
// singed olarak işaretlenmiş tipler - değerler alabilirken ,
// unsinged tipler 0'dan başlayarak değer alabilirler.
// (tiplerin başındaki u ve s , singed ve unsingedi ifade eder.)

// byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool

// int tam sayıları tutmak için kullanılır. Değer aralığı -2,147,483,648 ile 2,147,483,647 arasındadır.
// örnek : int sayi = 10; // int veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// int sayi2 = 22222222222; kod hata verir çünkü int veri türü 2,147,483,647'den büyük bir değer alıyor.

// uint 0 ile 4,294,967,295 arasında tam sayı değer alabilir. 4 byte = 32 bit //unsinged tip
// örnek : uint sayi = 10; // uint veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// uint sayi2 = -10; // kod hata verir çünkü uint veri türü 0 ile 4,294,967,295 arasında değer alabilir.

// byte 0 ile 255 arasında değer alabilir. 1 byte = 8 bit
// örnek : byte sayi = 125; // byte veri türünde bir değişken tanımlanıyor ve 125 değeri atanıyor.
// byte sayi2 = 256; // kod hata verir çünkü byte veri türü 0 ile 255 arasında değer alabilir.

//sbyte -128 ile 127 arasında değer alabilir. 1 byte = 8 bit
// örnek : sbyte sayi = -10; // sbyte veri türünde bir değişken tanımlanıyor ve -10 değeri atanıyor.
// sbyte sayi2 = 128; // kod hata verir çünkü sbyte veri türü -128 ile 127 arasında değer alabilir.

// short -32,768 ile 32,767 arasında tam sayı değer alabilir. 2 byte = 16 bit
// örnek : short sayi = 10; // short veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// short sayi2 = 32768; // kod hata verir çünkü short veri türü -32,768 ile 32,767 arasında değer alabilir.

// ushort 0 ile 65,535 arasında tam sayı değer alabilir. 2 byte = 16 bit //unsinged tip
// örnek : ushort sayi = 10; // ushort veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// ushort sayi2 = 65536; // kod hata verir çünkü ushort veri türü 0 ile 65,535 arasında değer alabilir.

// long -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında tam sayı değer alabilir. 8 byte = 64 bit
// örnek : long sayi = 3000000; // long veri türünde bir değişken tanımlanıyor ve 3000000 değeri atanıyor.
// long sayi2 = 9223372036854775808; // kod hata verir çünkü long veri türü -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında değer alabilir.

// ulong 0 ile 18,446,744,073,709,551,615 arasında tam sayı değer alabilir. 8 byte = 64 bit //unsinged tip
// örnek : ulong sayi = 3000000; // ulong veri türünde bir değişken tanımlanıyor ve 3000000 değeri atanıyor.
// ulong sayi2 = -3000000; // kod hata verir çünkü ulong veri türü 0 ile 18,446,744,073,709,551,615 arasında değer alabilir.

// float ondalıklı sayıları tutabilir. float tanımlarken değerin sonuna bir f hari eklememiz gerekir. 4 byte = 32 bit
// örnek : float sayi = 10.5f; // float veri türünde bir değişken tanımlanıyor ve 10.5 değeri atanıyor.
// float sayi2 = 10.5; // kod hata verir çünkü float veri türü ondalıklı sayıları tutabilirken,
// float tanımlarken değerin sonuna bir f harfi eklememiz gerekir.

// double ondalıklı sayıları tutabilir. değer aralığı float' dan daha büyüktür 8 byte = 64 bit
// örnek : double sayi = 10.5; // double veri türünde bir değişken tanımlanıyor ve 10.5 değeri atanıyor.
// double sayi2 = 10.5f; // kod hata verir çünkü double veri türü ondalıklı sayılı tutarken değerin sonuna bir şey eklememiz gerekmez. 

// decimal büyük ölçekli tam ve ondalıklı sayıları tutabilir. 16 byte = 128 bit
// ondalıklı sayıların sonuna m harfi konulmalıdır
// örnek : decimal sayi = 10.5m; // decimal veri türünde bir değişken tanımlanıyor ve 10.5 değeri atanıyor.
// decimal sayi2 = 10.5; // kod hata verir çünkü decimal veri türü ondalıklı sayıları tutarken sonuna m harfi eklenmelidir.
// örnek : decimal sayi3 = 200 // decimal veri türünde bir değişken tanımlanıyor ve 200 değeri atanıyor.

// bool mantıksal değerleri tutar. true veya false değer alabilir. 1 byte = 8 bit
// örnek : bool durum = true; // bool veri türünde bir değişken tanımlanıyor ve true değeri atanıyor.
// bool durum2 = 1; // kod hata verir çünkü bool veri türü mantıksal değerleri tutarken 1 veya 0 değer almaz.

// char tek bir karakteri tutar ve değer tek tırnak içerisinde gösterilmelidir. 2 byte = 16 bit
// örnek : char karakter = 'A'; // char veri türünde bir değişken tanımlanıyor ve 'A' değeri atanıyor.
// char karakter2 = "A"; // kod hata verir çünkü char veri türü tek bir karakteri tutarken değer tek tırnak içerisinde gösterilmelidir.
// char karakter3 = 'AB'; // kod hata verir çünkü char veri türü tek bir karakteri tutar.

// 2. Referans Tipi (Reference Type) 

// Referans tipleri RAM' in heap bölgesinde tutulur.
// Referans tipleri değişkenin değerini başka bir nesneye referans olarak kullanırlar.
// Yani heap alanında tutulan verilerin adreslerini saklarlar.
//Bir değişkene atandığında, referansı (adres) kopyalanır.

// object , string 

// object tüm veri türlerini tutabilir. 4 byte = 32 bit
// örnek : object sayi = 10; // object veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// object sayi2 = "10"; // object veri türünde bir değişken tanımlanıyor ve "10" değeri atanıyor.
// object sayi3 = 10.5; // object veri türünde bir değişken tanımlanıyor ve 10.5 değeri atanıyor.
// object durum = true; // object veri türünde bir değişken tanımlanıyor ve true değeri atanıyor.


// string metinleri tutar ve değer çift tırnak içerisine yazılır 2 byte = 16 bit
// string metin = "Umut"; // string veri türünde bir değişken tanımlanıyor ve "Umut" değeri atanıyor.
// string metin2 = Umut Özgenç; // kod hata verir çünkü string veri türü metinleri tutarken değer çift tırnak içerisine yazılmalıdır.
// string sayi = "5"; // 5 değeri metinsel bir ifade olarak gözükür ve hata vermez
// string sayi2 = 5; // kod hata verir çünkü string veri türü metinleri tutarken değer çift tırnak içerisine yazılmalıdır.

// *** Değişken İsimlendirme Kuralları ***

// 1. Değişken isimleri harf, rakam ve alt çizgi (_) karakterlerinden oluşabilir.
// örnek: int sayi1_ = 10; // geçerli bir değişken ismidir.
// örnek : int sayi?1 = 10; // kod hata verir çünkü değişken ismi özel karakterler içeremez.

// 2. Değişken isimleri harf veya _ ile başlamalıdır.
// örnek: int _sayi1 = 10; // geçerli bir değişken ismidir.
// örnek: int 1sayi = 10; // kod hata verir çünkü değişken ismi rakam ile başlamaz.
// örnek: int ?sayi = 10; // kod hata verir çünkü değişken ismi özel karakterler içermez.

// 3. Değişken isimleri boşluk içeremez.
// örnek: int sayi 1 = 10; // kod hata verir çünkü değişken ismi boşluk içeremez.

// 4. Değişken isimleri büyük/küçük harf duyarlıdır.
// örnek: int sayi = 10; 
// örnek: int Sayi = 20; sayi ve Sayi farklı değişkenlerdir.

// 5. Değişken isimleri C# dilinde tanımlı olan anahtar kelimeleri (keyword) içeremez.
// örnek: int class = 10; // kod hata verir çünkü class C# dilinde tanımlı bir anahtar kelimedir.

// 6. Değişken isimlendirme kurallarında Türkçe karakter kullanılabilir ama tavsiye edilmez.
// örnek: int sayı = 10; yerine int sayi = 10; kullanılmalıdır.

// 7. Değişken ismi iki kelime olduğunda ilk kelimenin baş harfi küçük,
// ikinci kelimenin baş harfi büyük olmalıdır.
// buna camelCase yazım kuralı denir.
// örnek: int sayiBir = 10; // zorunlu değildir ama yaygın kullanım bu şekildedir.

// *********
// stringin default değeri null'dır.
// string a = default; // output null
// int'in default değeri 0'dır.
// int a = default; // output 0

// **********

// *** var Keywordu ***
// var anahtar kelimesi ile değişken tanımlanırken veri türü belirtilmez.
// var anahtar kelimesi ile tanımlanan değişkenin veri türü, atanan değere göre belirlenir.

// örnek: var sayi = 10; // var anahtar kelimesi ile bir değişken tanımlanıyor ve 10 değeri atanıyor.
// örnek: var sayi2 = "10"; // var anahtar kelimesi ile bir değişken tanımlanıyor ve "10" değeri atanıyor.
// örnek: var sayi3 = 10.5; // var anahtar kelimesi ile bir değişken tanımlanıyor ve 10.5 değeri atanıyor.
// örnek: var sayi4 = true; // var anahtar kelimesi ile bir değişken tanımlanıyor ve true değeri atanıyor.
// örnek: var sayi5 = 10.3f; // var anahtar kelimesi ile bir değişken tanımlanıyor ve 10.3f değeri atanıyor.
// örnek: var sayi6 = 10.3m; // var anahtar kelimesi ile bir değişken tanımlanıyor ve 10.3m değeri atanıyor.

// değişkenin hangi tipte olduğunu görmek için GetType() metodunu kullanabiliriz.

// örnek: Console.WriteLine(sayi.GetType()); // output : System.Int32
// örnek: Console.WriteLine(sayi2.GetType()); // output : System.String
// örnek: Console.WriteLine(sayi3.GetType()); // output : System.Double
// örnek: Console.WriteLine(sayi4.GetType()); // output : System.Boolean
// örnek: Console.WriteLine(sayi5.GetType()); // output : System.Single
// örnek: Console.WriteLine(sayi6.GetType()); // output : System.Decimal

// *** Const Keywordu ***

// const anahtar kelimesi ile tanımlanan değişkenler sabit değişkenlerdir.
// const anahtar kelimesi ile tanımlanan değişkenlerin değeri sonradan değiştirilemez.
// const anahtar kelimesi ile tanımlanan değişkenlerin değeri tanımlanırken atanmalıdır.
// const anahtar kelimesi ile tanımlanan değişkenlerin veri türü belirtilmelidir.

// örnek: const float pi = 3.14f; // const anahtar kelimesi ile bir değişken tanımlanıyor ve 3.14 değeri atanıyor.
// pi = 3.15f; // kod hata verir çünkü const anahtar kelimesi ile tanımlanan değişkenlerin değeri sonradan değiştirilemez.

// örnek: const sayi a; // kod hata verir çünkü const anahtar kelimesi ile tanımlanan değişkenlerin değeri tanımlanırken atanmalıdır.

//*** String Interpolation ***

// String interpolation, C#'ta metinlerin içine değişken veya ifadeleri doğrudan gömmeyi sağlayan
// modern ve okunabilir bir yazım şeklidir.
// String interpolation kullanmak için metinlerin başına $ işareti eklenir.
// Örnek :
// string ad = "Umut";
// string soyad = "Özgenç";
// Console.WriteLine($"Adım {ad} ve soyadım {soyad}"); // output : Adım Umut ve soyadım Özgenç

//örnek 2 : string takim = "Beşiktaş";
//int siralama = 4;
//bool sampiyonMu = false;
//Console.WriteLine($"{takim} ligin {siralama}. sırasında ve bu sene şampiyon {sampiyonMu}");
// output : Beşiktaş ligin 4. sırasında ve bu sene şampiyon False

// ***** Console.ReadLine() ******

// Console.ReadLine() metodu, kullanıcıdan girdi almak için kullanılır.
// Kullanıcıdan alınan girdi, string veri türünde bir değişken olarak saklanır.
// Console.ReadLine() metodu, kullanıcıdan girdi alana kadar programın çalışmasını durdurur.
// Kullanıcıdan alınan girdi, Enter tuşuna basıldığında tamamlanır.

// Örnek : Console.WriteLine("İsminizi giriniz");
// string isim = Console.ReadLine(); // kullanıcıdan girdi alınıyor ve isim değişkenine atanıyor.
// Console.WriteLine("Soyadınızı giriniz");
// string soyad = Console.ReadLine(); // kullanıcıdan girdi alınıyor ve soyad değişkenine atanıyor.
// Console.WriteLine($"Adım {isim} ve soyadım {soyad}"); 
// output : Adım Umut(Console.ReadLine() dan alınan değer) ve soyadım Özgenç(Console.ReadLine() dan alınan değer)

// ******* TÜR DÖNÜŞÜMLERİ *******
// **CASTING**
// C# dilinde veri türleri arasında dönüşüm işlemleri yapılabilir.
// Veri türleri arasında dönüşüm işlemleri, casting (tip dönüştürme) olarak adlandırılır.

//1. Implicit Casting (KAPALI) (BİLİNÇSİZ DÖNÜŞÜM)

// Implicit casting, veri türünün daha geniş bir aralığa sahip
// olduğu durumlarda otomatik olarak gerçekleşir.
// Bu durumda veri kaybı olmaz ve
// programın çalışması için herhangi bir ek işlem yapmaya gerek yoktur.

//Örnek : 
// int sayi = 10; // int veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// long uzunSayi = sayi; // int veri türünden long veri türüne otomatik olarak dönüşüm yapılıyor.

// int sayi2 = 20; // int veri türünde bir değişken tanımlanıyor ve 20 değeri atanıyor.
// float ondalikliSayi = sayi2; // int veri türünden float veri türüne otomatik olarak dönüşüm yapılıyor.

//2. Explicit Casting (AÇIK) (BİLİNÇLİ DÖNÜŞÜM)

// Explicit casting, veri türünün daha dar bir aralığa sahip olduğu durumlarda
// yapılır ve bu durumda veri kaybı olabilir.
// Bu durumda programın çalışması için ek işlem yapmaya gerek vardır.
// Atanacak değerin önüne ( veri türü ) yazılarak açık olarak dönüşüm yapılır.

// Örnek :  
// long uzunSayi = 10000000000; // long veri türünde bir değişken tanımlanıyor ve 10000000000 değeri atanıyor.
// int sayi = (int)uzunSayi; // long veri türünden int veri türüne açık olarak dönüşüm yapılıyor.

// float ondalikliSayi = 10.5f; // float veri türünde bir değişken tanımlanıyor ve 10.5 değeri atanıyor.
// int sayi2 = (int)ondalikliSayi; // float veri türünden int veri türüne açık olarak dönüşüm yapılıyor.
// Console.WriteLine(sayi2); // output : 10 (ondalıklı kısım atılır)

// ** BOXING VE UNBOXING **
// Boxing, değer tipinden referans tipine dönüşüm işlemidir.
// Unboxing, referans tipinden değer tipine dönüşüm işlemidir.

// Boxing işlemi, değer tipinin heap bölgesine taşınması anlamına gelir.
// Unboxing işlemi ise, heap bölgesindeki referans tipinin değer tipine geri dönüştürülmesi anlamına gelir.

// BOXING ORNEK : 
// int sayi = 10; // int veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// object obj = sayi; // int veri türünden object veri türüne boxing işlemi yapılıyor.

// UNBOXING ORNEK :
// object obj = 10; // object veri türünde bir değişken tanımlanıyor ve 10 değeri atanıyor.
// int sayi = (int)obj; // object veri türünden int veri türüne unboxing işlemi yapılıyor.
