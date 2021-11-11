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

            #region Static Constructor
            //new MyClass();
            //new MyClass();
            #endregion-

            #region Singleton Design Pattern
            //var database1 = Database.GetInstance;
            //var database2 = Database.GetInstance;
            //var database3 = Database.GetInstance;

            //database1.ConnectionString = "asdasd";
            #endregion

            #region Positional Record
            //MyRecord1 m = new("asdasd", "asdasd");
            //var (n, s) = m;
            #endregion


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
        // this: Sınıftaki diğer constructorlara erişmemizi sağlar.
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
        // Singleton Design Pattern'de kullanılabiliyor.

        public MyClass()
        {
            // Bu sınıftan nesne üretilirken ilk tetiklenecek olan metottur.
            Console.WriteLine("MyClass constructor'ı tetiklenmiştir.");
        }
        static MyClass()
        {
            // Bu sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur.
            // Üretilen ilk nesnenin dışında bir daha tetiklenmez.
            Console.WriteLine("MyClass static constructor'ı tetiklenmiştir.");
            // static constructor'ın tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static yapılanmanın da tetiklenmesi static const. tetiklenemsini sağlayacaktır.
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

    #region Singleton Design Pattern
    // Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design patterndır.

    class Database
    {
        Database() //private constructor
        {

        }

        public string ConnectionString { get; set; }

        static Database database;
        static public Database GetInstance
        {
            get
            {
                return database;
            }
        }

        static Database()
        {
            database = new Database();
        }
    }
    #endregion

    #region Positional Record
    // Bir record üzerinde constructor ve deconsturct yapılanmasını hızlı bir şekilde oluşturmamızı sağlayan bir semantik sağlamaktadır.
    // Paramatrelerin karşılıkları olan propertyleri manuel oluşturmak zorunda değiliz.
    // Paramatrelerin karşılığı propertyler compiler seviyesinde otomtik oluşturulacaktır. Bu propertyler init olarak oluşturulur.

    //record MyRecord1(string Name, string Surname)
    //{
    //    public MyRecord1(): this("asdasd","qwdasd")
    //    {

    //    }

    //    public MyRecord1(string name): this()
    //    {

    //    }
    //}
    #endregion

    #region Inheritence
    // Kalıtım sınıflar özel bir niteliktir.
    // Bir sınıfın sadece tek bir base class'ı olabilir.
    // Recordlar'da kalıtım alır lakin kendi aralarında. Ayrıca Object sınıfından da kalıtım alabilirler.
    // abstract class, interface, struct gibi yapılar da kendi aralarında kalıtımsal operasyonları mevcuttur.
    // Kalıtım veren sınıfa Base/Parent Class, kalıtım alan sınıf Derived/Child Class denir.
    // Kalıtım alınan sınıflarında nesnesi üretilir, heapte tutulur.

    #region Kalıtım'da Nesnelerin Oluşma Sırası
    //// Bir sınıftan nesne oluştururken kalıtım aldığı sınıflar varsa eğer önce o sınıflardan sırayla nesne oluşturulur. En üst kalıtım ilk önce oluşturulur.
    //class A
    //{
    //    // İlk önce bu nesne oluşturulacak.
    //}
    //class B : A
    //{
    //    // İkinci olarak bu nesne oluşturulacak.
    //}
    //class C : B
    //{
    //    // Üçüncü olarak bu nesne oluşturulacak.
    //}
    #endregion
    #region Base Keyword
    // Base classtaki constructor parametresine değer göndermek için kullanılır. Kalıtım alınan sınıftaki constructor metoduna : base(value) şeklinde kullanılır. Base classta sadece parametreli constructor var ise base kullanılması zorunludur.
    // Bir classın constructor'ının yanına : base( ) getirirsek base classın constructorlarını getirecek ve değer gönderebileceğiz.
    // Kalıtım alan(derived class)'da base keywordu ile base classtaki field, property, metotlara erişim sağlayabiliriz. base.Y() -> base classtaki Y metodunu çağıracaktır.

    //class A
    //{
    //    int a;
    //    public int b;
    //    public int MyProperty { get; set; }
    //}
    //class B : A
    //{
    //    int c;
    //    public void X()
    //    {
    //        // this keywordü ile base class(erişime açık) ve bu classtaki memberlara erişebiliriz
    //        // base keywordü ile sadece base classtaki erişime açık memberlara erişebiliriz
    //        // base classtaki memberlara direk isimlerini yazarak da erişebiliriz

    //        //int _a = this.a; // base classta private, erişemeyiz.

    //        int _b = this.b;
    //        int __b = base.b;
    //        int ___b = b; // compilar başına base koyacaktır.

    //        int _myProperty = this.MyProperty;
    //        int __myProperty =  base.MyProperty;
    //        int ___myProperty = MyProperty; // compilar başına base koyacaktır.


    //        // zaten bu classa ait olduğu için erişebiliriz.
    //        int _c = this.c; // bu classtan
    //        this.X(); // bu classtan
    //    }
    //}

    #endregion
    #region Object Class
    // Bütün sınıflar object classından türetilmiştir. (Delegate'ler hariç)
    // Bu nedenle her türlü türü karşılayabilmektedir.

    #endregion
    #region Name Hiding
    // Base class ile aynı isimde bir member tanımlarsak. Base classtaki o member'a erişemeyiz. Buna Name Hiding denir.
    // Eskiden kalıtım alan sınıftaki bu member'ı new ile işaretlememiz gerekiyordu ancak şu an bu gerekmemekte.

    //class A
    //{
    //    public int X { get; set; }
    //}
    //class B : A
    //{
    //    public int X { get; set; }
    //}
    //class C : A
    //{
    //    public new int X { get; set; } // compiler'ın uyarı vermemesini sağlamış oluruz.
    //}
    #endregion
    #endregion

    #region Sanal Yapılar (virtual & override)
    // Bir nesne üzerinde var olan tüm memberların tamamı derleme zamanında belirgindir.
    // Sanal yapılar ile derleme zamanında kesin bilinen bu bilgi run time(çalışma zamanın)da belirlenebilmektedir. Yani ilgili nesnenin hangi metodu kullanacağı bilgisi kararlaştırılır. 
    // Sanal yapılar, bir sınıf içerisinde bildirilmiş olan ve o sınıftan türeyen alt sınıflarda da tekrar bildirilebilen yapılardır.
    // 
    #endregion
}
