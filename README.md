# C# 9.0 Not Defteri

  - Primitive: temel tipler: int, char, bool, float...
  - @ operatörü: while, static gibi değişken isimleri verilebilir.
  - class içerisinde int a; tanımında a değişkeninin varsayılan değeri olacaktır, metot içerisinde tanımlanın int a; değişkeninde ise olmayacaktır(okunamaz, çağrılamaz). En iyisi - her zaman manuel olarek ilk değeri vermek. Default ile bir tipin atama olmaması durumunda varsayılan değerini almak için kullanılır.
  - Object bir türdür, boxing-unboxing. O türe ait metotları kullanmak için unboxing gerekli, türüne uygun bir şekilde unboxing yapılması gerekir.
  - dynamic: Runtime zamanında türü belli olur. Gelecek tür belli değilse kullanılır.
  - var: Compile zamanında türü belli olur, ilk değeri verilmek zorundadır. var yerine eğer biliyorsak değişken türünü belirtmek performans artışı sağlar. 
  - const ve readonly: readonly ilk değer ataması sadece tanımlandığı yerde ya da constructor'da yapılabilir. const ise ilk tanımlandığında yapılmak zorundadır.
  - Değişken türünü en uygun aralıkta belirlemek performans artışı sağlar.
  - ; operatörü: Kod konseptinin bittiğini anlatır. kodlar satır satır değil konsept konsept çalışır.
  - case 100 when şart: yapabiliriz. when şartı da sağlanmalıdır.

# Tür Dönüşümü
  - parse metodu: Sadece stringi diğer türlere dönüştürürken kullanılır.
  - f.ToString(); sadece stringe dönüştürürken hız kazandırmak için kullanılan bir kullanım şekli.
  - convert metodu: Bütün türler için kullanılabilir.

## Implicit Type Conversion(Bilinçsiz Tür Dönüşümü) & Explicit Type Conversion(Bilinçli Tür Dönüşümü)
  - Bir sayısal değer kendi türünden daha büyük aralığa sahip türe dönüştürülmesine bilinçsiz tür dönüşümü (implicit type conversion) denir, compiler sorumluluğu üstlenir. Kendin türünden daha küçük türe dönüşüm işlemine ise bilinçli tür dönüşümü (explicit type conversion) denir, compiler sorumluluğu geliştiriciye bırakır, cast operatörü kullanılması gerekir (short) gibi. Checked bloğu içerisinde yapılırsa veri kaybına izin vermeden developer'a runtime'de hata fırlatır.
  - bool türü(mantıksal değeri) sayısal türe dönüştürülürse 0 ya da 1 olur. sayısal değeri bool'a dönüştürürken 0 değeri false diğer bütün sayılar 1 şeklinde dönüşür.
  - char -> int dönüşümünde ascii karakterindeki sayıyı verecektir.
  - int -> char dönüşümünde sayının karşılık geldiği ascii karakterine dönüşecektir.
  - Aritmetik operatörlerde farklı türlerde işlemler yaparken sonuç büyük türde dönecektir.
  - Normalde iki aynı türdeki sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç aynı türde dönecekken, bu iki değer byte ise sonuç her daim int dönecektir. Böyle kabul edilmiştir, istisnadır.
  - Cast operatörü şuralarda kullandık: unboxing, bilinçli tür dönüşümü, char ascii karakter - int dönüşümü.

# null kontrolü
  - variable is type: Bir değerin tipini kontrol etmek için kullanılır. (x is bool)
  - variable is null, variable is not null: Null olup olmadığını kontrol eder. sadece null olabilen türlerde kullanılabilir. (x is null, x is not null)
  - Değer türlü değişkenler null değeri alamaz int a = null olamaz.
  - as operatörü: As operatörü ise is operatörü ile benzer bir şekilde çalışmaktadır. Arasındaki fark, is operatörü kontrol ile bool bir değer döndürürken as operatörü ilgili tipin referansını döndürmektedir. Eğer yapılan cast işlemi hatalı ise null değerini döndürmektedir.Türüne uygun olmayan unboxing işlemi yapmaya da yarar ancak bu durumla karşılaştığında null değere dönüşür. Bu operatör sayesinde program akışını runtime hatası verdirmeden devam ettirebiliriz. Ancak değer türlü değişkenlerde kullanılamaz.
  - "x is var a" -> Runtime zamanında türü belli olur.
  - Bir değer türlü değişkenin null değer alabilmesi için Nullable(?) kullanılır. int? a = null diyerek yapabiliriz. Nullable yapıldığında is null, as gibi null ile çalışan operatörleri kullanabiliriz.
  - Null-Coalescing: Elimizdeki değişkenin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür. 
  - örn: string a = null; a ?? "Merhaba"
  - a değişkeninin değeri null değilse a'nın değerini yazdır, eğer null ise Merhaba yazdır. a == null ? "Merhaba" : a işleminin kısa halidir. Her iki taraftaki değişkenin türü de aynı olmalıdır.
  - Null-Coalescing Assignment: 
  - örn: a ??= "Merhaba" 
  - a null değilse kendisini null ise "Merhaba" değerini yazar ve a değişkeninin yeni değeri "Merhaba" olur.

# Array Sınıfı Fonksiyonları
  - Array sınıfı bütün dizilerin atasıdır, base classtır. 
  - Array.CreateInstance(): dizi tanımlamayı metot üzerinden sağlar.
  - Array.Clear(): dizideki değerlere default değer verir.
  - Array.Copy(): başka bir dizideki elemanları yeni diziye kopyalamaya yarar.
  - Array.IndexOf(): dizide arama yapar bulursa index numarası döner bulamazsa -1 döner.
  - Array.Reverse(): diziyi tersine çevirir.
  - Array.Sort(): diziyi tersine a-z'ye sıralar.
  - Array.IsReadOnly: Dizi'nin değerleri sadece okunabilir mi diye kontrol eder.
  - Array.IsFixedSize: Dizinin eleman sayısı sabit mi diye kontrol eder. dizilerde sabittir. Örneğin ArrayList sabit değildir.
  - Array.Length: Dizinin boyutunu gönderir.
  - Array.Rank: Dizinin derecesini gönderir. tek boyutlu dizilerde 1 verir.

# System.Index ve System.Range Sınıfı
  - System.Index: dizideki index'e tekabül eder. Index index = 3; 0-1-2-(3), Index index = ^3; 3-2-1 sondan 3. ^ Index'e özel operatördür, sondan ve 1'den başlar.
  - System.Range: belirli bir index aralığını diziden çekmek için kullanılır. Range range = ^8..^3
  - type bildirimi typeof(int) şeklinde yapılır.

# Düzensiz Diziler
  - Her bir dizi içerisinde bir dizi tanımlanıyorsa bu düzensiz dizidir. Çok boyutlu dizilerin sütun sayısı aynı olurken, düzensiz dizilerde sütun sayısı birbirinden farklı olabilir.
  - int[,] dizi = new int[2,3] -> çok boyutlu dizi (2 boyutlu, 2 satır 3 sütun)
  - int[][] dizi = new int[3][] -> düzensiz dizi (3 adet int dizi tutacak)

# Nullable & Empty 
  - Referans türlü olduğu halde programlama dilinde keyword olarak kullanılan tek tür string'tir.
  - Herhangi bir değişken/nullable/referans null ise bir alan tahsis edilmemiş demektir.
  - Herhangi bir değişken/nullable/referans empty ise bir alan tahsis edilmiş fakat değer girilmemiş demektir.
  - Referans türlü değerler null olabilir ya da nullable hale getirilirse onlar da null olabilir örn: int? a = null olabilir.
  - Default değerler empty olarak geçer. int=0, bool=false, char=\0 int[] x = new int[55], string=null default değeridir ancak string=""'da boş sayılır lakin hafızada yer kaplar. string.Empty değeri de "" değerine tekabül eder.
  - null olan bir değer üzerinde işlem yapmaya çalıştığımızda runtime hatası verir. Ancak empty bir değer üzerinde işlem yapabiliriz.
  - string.IsNullOrEmpty(stringDeger): Null ya da empty ise true dönecektir.
  - string.IsNullOrWhiteSpace(stringDeger): null, empty ya da "    " ise true dönecektir.

# String Biçimlendirme
  - string bir char dizisidir ancak Array tipinde tutulamaz.
  - String dizisinin karakterlerine for döngüsüyle ulaşabiliriz.
  - + ile string formatlandırmada ternary operatörü kullanılıyorsa () parantez içerisinde yazılması gerekmektedir.
  - + operatörü ile string formatlandırma işlemi oldukça maliyetlidir.
  - string.Format: string sonuc = string.Format("....{0}....{1}....{2}....", x, y, z);
  - $(String Interpolation): Bir string değerin başına $ operatörü koyulursa $"...." string interpolation kullanabiliriz. {{ahmet}} şeklinde yazarsak süslü parantez ezilir {ahmet} çıktısını verir. Ternary operatörünü kullanırken parantez () içinde yazmamız gerekir. $"....{x}...{y}...{z}..." 
  - @ (verbatim) operatörüyle \ kaçış karakteri kullanılması gereken string ifadelerde çift örneğin tırnak için çift yazılması yeterli olacaktır. @""string"" -> "string" şeklinde olacaktır.
  - @ operatörüyle: Satır satır string ifade yazılabilir. @ olmasaydı + operatörüyle birleştirilmesi gerekecekti.
  - string interpolation ve verbatim birlikte kullanılabilir.
  - @$"Merhaba {isim} 
  - nasılsınız";

# String Fonksiyonları:
  - deger.Contains(deger2): metinsel değer içerisinde verilen değerin olup olmadığını kontrol eder. Bool döndürür.
  - deger.IndexOf(deger2): metinsel değer içerisinde verilen değerin olup olmadığını kontrol eder. Geriye int index numarasını döndürür. Aradığımız ifade bir kelime ise kelimenin ilk harfinin index numarasını döndürür. Birden fazla değer var ise ilk eşleyen değerin indexini döndürür. Değer yoksa -1 döndürür.
  - deger.StartsWith(deger2): metinsel değerin verilen değer ile başlayıp başlamadığını kontrol eder. Bool döndürür.
  - deger.EndsWith(deger2): metinsel değerin verilen değer ile bitip bitmediğini kontrol eder. Bool döndürür.
  - deger.Equals(deger2): metinsel değer verilen ifadeye eşit mi diye kontrol eder. Bool döndürür.
  - string.Compare(deger1, deger2): metinsel değerleri kendi aralarında karşılaştırma yapabiliyoruz. İnt olarak 3 sonuç döner.0: her iki değer eşittir. 1: soldaki sağdakinden alfanumerik olarak büyük. -1:soldaki sağdakinden alfanumerik olarak küçük
  - deger.CompareTo(deger2): Compare ile aynı işlevi görür.
  - deger.Insert(index, deger2): Elimizdeki metinsel ifadede belirtilen yere bir değer ekleyebilmemizi sağlar. String olarak eklenmiş halini yeniden üreterek döndürür. Metinin orijinal hali değişmeyecektir.
  - deger.Remove(index): metinsel değer içerisinde indexsel olarak silme işlemi yapacaktır. String döndürür. Insert metodu gibi orijinal hali değişmeyecektir.
  - deger.Replace(deger2): verilen karakter ya da metinsel ifadeyi başka bir karakter ya da metinsel ifade ile değiştirip geriye değişmiş olan string ifadeyi geri dönecektir. Orijinal hali aynı kalacaktır.
  - deger.Split(ayrac1,ayrac2): metinsel ifadeyi verilen karaktere göre parçalayan ve geriye string dizisi döndüren bir fonksiyondur.
  - deger.Substring(index, uzunluk): metinsel ifadenin belirli bir aralığını elde etmemizi sağlar. string döner.
  - deger.ToLower(): verilen değeri bütün karakterlerini küçük yapacaktır. string döner.
  - deger.ToUpper(): verilen değeri bütün karakterlerini büyük yapacaktır. string döner.
  - deger.Trim(): verilen değerin solundaki ve sağındaki bütün boşlukları silecektir. string döner.
  - deger.TrimEnd(): verilen degerin sonundaki bütün boşlukları silecektir. string döner.
  - deger.TrimStart(): verilen değerin başındaki bütün boşlukları silecektir. string döner.

# ArraySegment & StringSegment
  - Bu string fonksiyonları geriye bir string değer döndürürken, dizinin belli bir alanını kullanırken yeni dizi oluşturuyorsak, + opeartörüyle string formatlama işlemi yapıyorsak bellekte yeni bir alan tahsis etmiş oluruz. Ancak bu maliyetli bir durumdur. Dizileri çoğaltmak yerine dizide istediğimiz alanı referans etmek, işaret etmek bu maliyeti ortadan kaldırır. Bunun için ArraySegment(tüm dizilerde) ve StringSegment(stringlerde) kullanmalıyız. Bunlar struct'tır. Dizilerin birden çok bölümünü, birden çok referansla temsil etmeye yarar. Tek bir dizi üzeride çalışabiliyoruz.
  - ArraySegment: Bir dizinin bütününden ziyade belirli bir kısmına yahut parçasına ihtiyaç dahilinde ilgili diziyi kopyalamak yerine (bu maliyetlidir) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan yapıdır.
  - int[] sayilar = new int[] {1, 2, 5, 76, 6, 124, 453}
  - ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); //sayilar dizisinin tamamını farklı bir referans ile göstermiş olduk.
  - ArraySegment<int> segment1 = new ArraySegment<int>(sayilar, 2, 5); //sayilar dizisinin 2.indexten 5.sıraya kadar olan kısmı farklı bir referans ile göstermiş olduk.
  - ArraySegment Slicing(dilimleme): Bir dizi üzerinde birden fazla parçada çalışacaksan eğer her bir parçayı ayrı bir ArraySegment olarak tanımlayabiliriz. Bu tanımlamaların dışında diziyi tek bir ArraySegment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz. Yani ilgili diziyi tek bir segment üzerinden daha rahaht bir şekilde parçayabiliriz. Bu durum da bize yazılımsal açıdan efektiflik kazandırmış olacaktır.
  - ArraySegment<int> segment = new ArraySegment<int>(sayilar);
  - ArraySegment<int> segment1 = segment.Slice(0, 3) //(index, sıra)
  - ArraySegment<int> segment2 = segment.Slice(4, 7)
  - ArraySegment<int> segment3 = segment.Slice(5, 10)
  - StringSegment: ArraySegment'in string değerler nezdindeki bir muadilidir. Esasında metinsel değerlerdeki analitik opersayonlardan bizleri kurtarmakta ve Substring vs. gibi fonksiyonlar yerine string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür. String fonksiyonlarına nazaran maliyeti azaltan bir türdür. Microsoft.Extension.Primitive paketinin eklenmesi gereklidir. Bir sınıftır.
  - string text = "Emre Polat";
  - StringSegment segment = new StringSegment(text);
  - StringSegment segment1 = new StringSegment(text, 2, 5);

# StringBuilder 
  - StringBuilder, string birleştirme operasyonlarında + operatörüne nazaran yüksek maliyeti absorbe edebilmek için arka planda StringSegment algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri olabilecek en az maliyetle birleştirip döndüren bir sınıftır.
  - StringBuilder builder = new StringBuilder();
  - builder.Append(isim); //+ operatörü yerine birleştirme yapar.
  - builder.Append(" ");
  - builder.Append(soyisim);
  - Console.WriteLine(builder.ToString());

# Span & Memory Türleri (ReadOnlySpan<T> & ReadOnlyMemory<T>)
  - Span: Ram üzerinde herhangi bir alanı temsil edebildiğimiz bir struct'tır. Dizinin ve stringin dışındaki alanlarda da kullanılabilir. ArraySegment gibi bellek üzerindeki bir alanı referans edebiliyoruz ancak farkı sadece dizilerle sınır olmamasıdır. Arrayler normal şartlarda belleğin HEAP'te tutulurken(ardışıl bir şekilde) pointerlar konusunda görebileceğiniz stackalloc keywordü sayesinde arrayleri de stackte tutabiliyoruz. Span ile istersek stackalloc keywordü ile stackte alan tahsisi edebiliriz. İstersek de heap'te alan tahsisi gerçekleştirebiliyoruz. Span stack veyahut heap farketmeksizin, dizi ve string gibi maliyetli veriler üzerinde tümünü yahut bir bölümünü bizler için refere edebilen(kopyalama olmadan, maliyet kaybı olmadan) ve üzerinde işlemler gerçekleştirmemizi sağlayan kullanışlı yapılardır.
  - ReadOnlySpan<T>: Span niteliklerinin tümünü sağlamakta lakin adı üzerinde sadece okunabilir kılmaktadır.
  - Span ile ArraySegment & StringSegment Farkı Nedir?: ArraySegment sadece string ve dizilerde temsiliyet yapabiliyorken, Span bellek üzerinde olan herhangi bir yeri temsil edebilir.
  - ArraySegment'te referans edilen alana her trülü müdahele edilebilirken, ReadOnlySpan'da bu verisel operasyonlar engellenebilir ve sadece okunabilir bir davranış sergielnebilir.
  Sadece string yahut array türler ile çalışılacaksa eğer ArraySegment ve StrignSegment tavsiye edilir.
  - Span<int> span = new Span<int>(sayilar);
  - Span<int> span2 = sayilar // üstteki kod ile aynı işlevi görür.
  - Span<int> span3 = new Span<int>(sayilar, 2, 5);
  Farklı bir Kullanım:
  - Span<int> span4 = sayilar.AsSpan();
  - Span<int> span5 = sayilar.AsSpan(3,5);
  String işlemlerde stringin bir kısmını kullanmak istiyorsak span yerine ReadOnlySpan kullanmamız gerekecektir. 
  - Örn: ReadOnlySpan<char> readOnlySpan = text.AsSpan();
  - Memory Türü Nedir?: Span ref struct olarak tasarlanmış bir struct'tır. Dolayısıyla Heap'te allocation(tahsis) edilememe, object, dynamic yahut interface türleri aracılığıyla referans edilememe yahut bir class içerisinde field veya property olarak tanımlanamama gibi kısıtlamaları vardır. Memory türü Span'ın bu kısıtlamalarından münezzeh versiyonudur.
  - ReadOnlyMemory: Span'ın nasıl ReadOnlySpan'ı varsa Memory'in de ReadOnlyMemory'i vardır. Memory türünün sadece okunabilir halidir.

# Regular Expression:
  - ^ operatörü		: Satır başının istenilen ifadeyle başlamasını sağlar.
  - \ operatörü 	: Belirli karakter gruplarını içermesini istiyorsak kullanırız.\d\D\s\S\w\W
  - \+ operatörü		: Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılacaktır.
  - | operatörü		: (veya operatörü) Verilen karakterlerden biri olması yeterli.
  - {n} operatörü	: Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli
  - ? operatörü		: Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.
  - . operatörü		: İlgili yerde herhangi bir karakterin kullanılabileceğini belirtir. Kullanıldığı yerde \n karakteri dışında herhangi bir karakter bulunabilir.
  - \B operatörü	: Bu ifade ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir.
  - \b operatörü	: Bu ifade ilgili kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar.
  - [] operatörleri	: Karakter aralığı belirtilebilir. Ayrıca özel karakterlerin yerinde yazılmasını da ifade eder.

# Koleksiyon ile diziler arasındaki farklar:
  - Dizilerde tanımlanırken değer atanması gerekirken, koleksiyonlarda atama zorunluluğu yoktur.
  - Dizilerde kullansakta kullanmasakta bellekte alan tahsisinde bulunuluyordu, maliyetli oluyordu. Koleksiyonlarda ne kadar veri eklenirse o kadar alan tahsis edilir.
  - Dizilerde ilk değer atandıktan sonra yeniden dizinin boyutunu büyütemezken, koleksiyonlarda böyle bir sınırlama yoktur.

# Dictionary<key, value>:
  - Key, value değerleri tutulabilir. 
  - Tekrarlı veri tutulamaz.
  
# C# Hazır sınıf ve fonksiyonlar:
  - Math, Random sınıfları
  - Math, Random sınıfları
  - DateTime, TimeSpan struct'ları
  - ...
  
# Metotlar:
  - Metotlarda erişim belirleyici yazılmadığı taktirde varsayılan olarak private olacaktır. Java'da tam tersi public olur.
  - Parametrede in keywordü kullanıldığında o parametredeki değişkeni readonly hale getirir.
  
# Static:
  - Bir sınıf static ise ondan nesne oluşturulamaz. Direk sınıf ismi nokta diyerek üyelere erişilir.
  - Static class'ta static memberlar bulunabilir.
  - Normal classlarda da static member bulunabilir.
  - Constructor static olabilir. Bir defa çalışır.

# Struct:
  - Belleğin stack bölgesinde tutulurlar.
  - Diğer struct ve sınıflardan kalıtım alamaz, interfacelerden kalıtım alabilirler.
  - Class içerisinde struct, struct içerisinde class tanımlanabilir.
  - new referansı oluşturulmadan da kullanılabilir. OrnekStruct ornekStruct;
  - Classlardan farkları: parametresiz constructor kullanamayız, fieldlara ilk değer verilmediğinde kendisi default değerleri atamaz o yüzden ilk değerlerini bizim vermiş olmamız gerekir.
  - 16 byte'a kadar olan bir verimiz var ise structta tutmak daha hızlı olur denilir.

# Enum: 
  - Sabit değerlerle çalışırken okunabilirliği arttırır.
  - Varsayılan olarak 1'den başlarlar. Ancak değiştirilebilir.
  
# Object Oriented Programming
  -  ``new MyClass()`` şeklinde referanssız bir nesne oluşturulursa bir süre sonra bellekten Garbage Collector tarafından temizlenecektir. Bir referans değişkeni nesneyi işaret etmiyorsa tekrardan bu nesneye erişemeyiz.
  - Shallow Copy: Referans türlü değişkenlerin/değerlerin default davranışı shallow copy'dir.
  - Deep Copy: Değer türlü değişkenlerde default davranış deep copy'dir.
  
# Interface:
  - Prototip şablon görevi görürler. Kalıtım verilen sınıfa kullanılacak metotlarını belirtir.
  - Kalıtım verildiği sınıfta metot gövdeleri oluşturulması zorunludur.
  - Newlenemezler.
  - Metodun gövdesi yazılmaz. İmzaları yazılır.
  - Memberlarına erişim belirteci yazılmaz.

# Abstract Class:
  - Normal class ve interfacelerin karışımı gibidir.
  - Sanal yapılarla efektif kullanım olanağı sağlar.
  - Gövdesiz metod tanımlanabilir.
  - Kalıtım verildiği sınıfta interface'ler gibi gövde oluştulması zorunlu değildir. Ancak virtual ile işaretlenmişse onu kalıtım aldığı sınıfta override etmek zorunludur.
