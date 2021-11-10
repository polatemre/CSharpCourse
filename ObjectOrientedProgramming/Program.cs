using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Call Nested Class
            //MyClass.MyClass2 m2 = new MyClass.MyClass2();
            //MyClass myClass = new MyClass();
            //myClass.X()|
            #endregion

            #region Target-Typed New Expressions (C# 9.0)
            //MyClass myClass = new();

            #endregion

            #region Object Initializer - Nesne Oluştururken Propertylere İlk Değer Atama
            //MyClass myClass = new()
            //{
            //    MyProperty = 10,
            //    MyProperty2 = 12
            //};
            #endregion

            #region Deep Copy & Shallow Copy
            #region Değer Türlü Değişkenlerde Deep Copy
            // Değer türlü değişkenlerde default davranış deep copy'dir.
            //int a = 5;
            //int b = a; // a yerine değeri olan 5 gelecektir.
            #endregion
            #region Değer Türlü Değişkenlerde Shallow Copy
            #endregion
            #region Referans Türlü Değişkenlerde Deep Copy
            // Var olan bir nesnenin klonlanmasıdır, çoğaltılmasıdır.
            //MyClass m1 = new();
            //MyClass m2 = m1.Clone();
            #endregion
            #region Referans Türlü Değişkenlerde Shallow Copy
            // Var olan bir nesnenin veya değerin, referansının kopyalanmasıdır. Eldeki değer çoğaltılmaz. Sadece birden fazla referansla işaretlenmiş olur.
            // Referans türlü değişkenlerin / değerlerin default davranışı shallow copy'dir.
            //MyClass m1 = new();
            //MyClass m2 = m1;
            #endregion
            #endregion

            #region Class Members
            #region Field
            // Class'lardaki değişkenlere verilen isimdir.
            // Field'lar türüne özgü varsayılan değeri alırlar. Ancak metot vs. içinde tanımlanırsa varsayılan değer ataması yapılmaz.

            //MyClass m1 = new();
            //Console.WriteLine(m1.a); // 0

            //int a;
            //Console.WriteLine(a); // hata verir.
            #endregion
            #region Property
            //// Nesne içerisinde özellik sağlar.
            //// Özünde bir metottur. Lakin farkı parametre almaması ve get, set bloklarının bulunmasıdır.
            //// Get ve set blokların compile neticesinde get ve set isimli metotlar olarak karşımıza çıkmaktadır.
            //// Nesnelerimiz içerisindeki field'lara direkt erişilmesini istemeyiz. Fieldları kontrollü bir şekilde dışarıya açmak ve kontrollü bir şekilde dışarıdan değer almasını isteriz. Bu durumlar için ayrı metotlar oluşturmak yerine property yapıları geliştirilmiştir.
            //// Encapsulation(kapsülleme,sarmalama): Bir nesne içerisindeki fieldlardaki verilerin dışarıya kontrollü bir şekilde açılması ve kontrollü bir şekilde veri almasıdır. Bunun için geliştirilmiş yapılar property'dir.

            //MyClass myClass = new();
            //Console.WriteLine(myClass.Yas);
            //myClass.Yas = 65;
            //Console.WriteLine(myClass.Yas);

            #region Init-Only Properties - Init Accessor (C# 9.0) & Auto Property Initializer -> İlk Değer Atama Karşılaştırması
            //MyClass myClass1 = new()
            //{
            //    Author = "Emre" // Init-Only Properties - Init Accessor (C# 9.0) / readonly olmasına rağmen object initializer sayesinde değer atayabiliyoruz.
            //};

            //MyClass myClass2 = new()
            //{
            //    Id = 2 // Auto Property Initializer / bu atama işlemine izin vermeyecektir.
            //};
            #endregion
            #region Indexer
            //MyClass myClass1 = new();
            //myClass[5] = 10;
            #endregion

            #endregion
            #endregion

            #region Records
            //MyClass2 m1 = new()
            //{
            //    MyProperty1 = 5
            //};
            //MyRecord m2 = new()
            //{
            //    MyProperty1 = 5
            //};
            //Console.WriteLine(m1.Equals(m2)); // Farklı nesneler olduğu için false dönecektir.

            //MyRecord m3 = new()
            //{
            //    MyProperty1 = 5
            //};
            //MyRecord m4 = new()
            //{
            //    MyProperty1 = 5
            //};
            //Console.WriteLine(m3.Equals(m4)); // Record olduğu için (değerler ön planda) true dönecektir.

            #region With Expression
            //MyClass2 myClass2 = new()
            //{
            //    MyProperty1 = 5
            //};

            ////myClass2.MyProperty1 = 5; //init olduğu için yapamayız.
            ////Eski sistem
            //MyClass2 myClass3 = myClass2.With(15);

            ////Yeni sistem -> Record ile
            //MyRecord myRecord = new()
            //{
            //    MyProperty1 = 5
            //};
            //MyRecord myRecord1 = myRecord with { MyProperty1 = 15 };

            #endregion
            #endregion

            #region Constructor This Keyword
            //new MyClass(5, 10);
            #endregion

            #region Deconstruct
            //MyClass myClass = new()
            //{
            //    Name = "Emre Polat",
            //    Age = 25
            //};

            //var (name, age) = myClass;
            #endregion

            //GC.Collect(); // Garbage Collector'u devreye sokmuş oluyoruz.
        }
    }

    class MyClass
    {
        public int a;

        int yas;

        public string Name { get; set; }
        public int Age { get; set; }


        public void X(int a) { } //method

        #region Constructor
        // Record yapılanmalarında da aynı şekilde constructorları kullanabilmekteyiz.
        #region Private Constructor
        // Eğer constructor private yapılırsa o sınıftan nesne üretilemez. örn: Singleton Design Pattern
        //MyClass()
        //{

        //}
        #endregion
        #region Constructor This Keyword
        // this o anki constructor'ın dışındaki constructorlara erişmemizi sağlar.
        // this() parantez içine sadece constructor parametresinden veya kendimiz manuel değer yazabiliriz.
        //public MyClass()
        //{
        //    Console.WriteLine("1. Constructor");
        //}
        //public MyClass(int a) : this()
        //{
        //    Console.WriteLine($"2. Constructor : a = {a}");
        //}
        //public MyClass(int a, int b) : this(a)
        //{
        //    Console.WriteLine($"2. Constructor : a = {a} | b = {b}");
        //}
        #endregion
        #endregion
        #region Destructor
        // Sadece classlarda kullanılabilir recordlarda kullanılamaz.
        // Parametre alamaz, dönüş tipi yoktur, bir adet tanımlanabilir.
        // Garbage Collector çalışmadan hemen önce tetiklenir.
        // Garbage Collector: Referanssız nesneleri, scope'u bitmiş nesneleri vs. otomatik olarak bellekten temizleyen bir yapıdır. Ne zaman devreye gireceği tahmin edilemez. Bellek optimizasyonunu üstlenir.
        ~MyClass()
        {

        }
        #endregion
        #region Deconstruct
        // Nesne içerisindeki verileri out olarak işaretlernmiş parametreler üzerinden tuple olarak geriye döndürmeye yarar.
        // Compiler metodun isminden özel metod olduğunu anlayacaktır.
        // Geriye değer döndürmüyor.
        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
        #endregion
        #region Static Constructor
        // Bir sınıfta nesne üretilirken ilk tetiklenen fonksiyon static constructor'dır. Amma velakin belirli bir duruma istinaden!!
        // Constructor ilgili sınıftan her nesne üretilirken tetiklenen metottur.
        // Static Constructor ise ilgili sınıftan ilk nesne üretilirken bir kereye mahsus tetiklenin metottur.
        // Bir sınıftan ilk defa nesne üretiliyorsa bir kereye mahsus ilk önce static constructor ardından normal constructor çalışır, daha sonraki üretmelerde normal constructorlar ilk önce çalışır.
        // Static Constructor'da erişim belirleyici olmaz, overloading yapılamaz, bir tane tanımlanabilir, parametre almaz.

        public MyClass()
        {
            // Bu sınıftan nesne üretilirken ilk tetiklenecek olan metottur.
        }
        static MyClass()
        {
             // Bu sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur.
             // Üretilen ilk nesnenin dışında bir daha tetiklenmez.
        }
        #endregion

        // Property'ler void olamazken metotlar void olabilir.
        #region Property
        #region Full Property
        // propfull [tab] [tab] yaparak otomatik şablonu getirebiliriz.
        // Property hangi türden bir fiel'ı temsil ediyorsa o türden olmalıdır.
        // Propertyler temsil ettikleri field'ların isimlerinin baş harfi büyük olacak şekilde isimlendirilir.
        public int Yas
        {
            // Sadece get metodu yazılırsa readonly, sadece set metodu yazılırsa writeonly olur.
            get
            {
                // Property üzerinden değer talep edildiğinde bu blok tetiklenir. Değer buradan gönderilir.
                return yas;
            }
            set
            {
                yas = value;
            }
        }
        #endregion
        #region Prop Property
        // Arka planda ad isminde bir field oluşturacağı için bizim field oluşturmamıza gerek yoktur.
        // readonly olabilir lakin writeonly olamazlar.
        public string isim { get; } //readonly
        public string Ad { get; set; }
        #endregion
        #region Auto Property Initializer (C# 6.0)
        // proplara ilk değer ataması yapılmasını sağlar.
        public bool MedeniHal { get; set; } = true;
        public int Id { get; } = 0; //readonly olanlara da hızlıca değer atamamızı sağlıyor.
        #endregion
        #region Ref Readonly Returns (C# 7.2)
        // Bellek optimizasyonu açısından fayda sağlar. Static yapılanmaya çevirdiğimizde efektif kodlama imkanı sağlar.
        // name field'ına erişmeye çalıştığımızda değerini değil referansını readonly olarak döndürecektir. 
        //string name = "Emre Polat";
        //public ref readonly string Name => ref name;
        #endregion
        #region Computed(Hesaplanmış) Properties
        // İçerisinde türetilmiş bir bağıntı taşır.
        int s1 = 5;
        int s2 = 10;
        public int Topla
        {
            get
            {
                return s1 + s2;
            }
        }
        #endregion
        #region Expression-Bodied Property
        // Tanımlanan property'de Lambda Expression kullanmamızı sağlayan söz dizimidir. Sadece readonly'lerde kullanılır.
        public string Cinsiyet1
        {
            get
            {
                return "Erkek";
            }
        }

        public string Cinsiyet2 => "Erkek";
        #endregion
        #region Init-Only Properties - Init Accessor (C# 9.0)
        // Auto property initializer kullandığımızda object initializer(nesne oluştururken property veya fieldlara ilk değer atama işlemi) işlemi yapamıyorduk. Ancak init-only kullandığımızda nesne oluştururken de ilk değer atama işlemi yapabiliriz.
        public string Author { get; init; } // readonly olması gerekmekte
        #endregion
        #endregion
        #region Indexer
        // Nesneye indexer özelliği kazandıran, fıtrat olarak property ile birebir aynı olan elemandır.
        // this var ise indexer olduğunu anlayabiliriz.
        public int this[int a]
        {
            get
            {
                return a;
            }
            set
            {

            }
        }
        #endregion

        public MyClass Clone()
        {
            // this = oluşturulan nesne.
            return (MyClass)this.MemberwiseClone(); // Nesnenin içindeki değerlerin bir kopyasını oluştur.
        }
    }

    #region Records
    // Eğer ki tek bir property'de readonly'lik sağlanmak isteniyorsa Init-Only Properties özelliği kullanılır
    // Eğer ki bir objeyi bütünsel olarak değişmez yapmak istiyorsak o zaman daha fazlasına ihtiyacımız olacaktır. Bu ihtiyaca istinaden Records yapılanması geliştirilmiştir.
    // İçerisinde bulunan değerler değişmeyeceğinden dolayı objeden ziyade bir değer gözüyle bakılan bir yapıya dönüşmektedir.
    // Nesne ön plandaysa bu class, nesnenin değerleri ön pandaysa bu record'dur.
    // Record'lar özünde bir classtır.
    record MyRecord
    {
        // init kullanmak mecburiyetinde değiliz ancak recordların yapısı gereği böyle kullanmak isteriz.
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
    }

    class MyClass2
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }

        public MyClass2 With(int property2)
        {
            return new MyClass2
            {
                MyProperty1 = this.MyProperty1,
                MyProperty2 = this.MyProperty2
            };
        }
    }
    #endregion
}
