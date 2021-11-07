using System;
using System.Collections;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch Expression
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapılacak işlemi belirtiniz (+,-,/,*): ");
            //char islem = char.Parse(Console.ReadLine());

            //int sonuc = islem switch
            //{
            //    '+' => sayi1 + sayi2,
            //    '-' => sayi1 - sayi2,
            //    '*' => sayi1 * sayi2,
            //    '/' => sayi1 / sayi2,
            //    _ => 0
            //};
            //Console.WriteLine(sonuc);
            #endregion

            #region Faktoriyel Bulma

            //int sayi = 0;
            //int fakt = 1;

            //Console.Write("Lütfen faktoriyeli alınacak sayıyı giriniz: ");

            //try
            //{
            //    sayi = int.Parse(Console.ReadLine());
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Yanlış değer girdiniz: " + ex.Message);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Bir hata ile karşılaşıldı: " + ex.Message);
            //}

            //for (int i = sayi; i > 0; i--)
            //{
            //    fakt *= i;
            //}

            //Console.WriteLine("Sonuç: " + fakt);

            #endregion

            #region String İşlemleri
            #region Adımızın ilkten 3, soyadımızın sondan 5.karakterini getirelim

            #region 1.Çözüm

            //string adSoyad = "Emre Polat";
            //string _adSoyad = adSoyad[2..^4];

            //Console.WriteLine(_adSoyad[0]);
            //Console.WriteLine(_adSoyad[_adSoyad.Length - 1]);
            #endregion

            #region 2.Çözüm

            //string adSoyad = "Emre Polat";
            //Console.WriteLine(adSoyad[2]);
            //Console.WriteLine(adSoyad[adSoyad.Length - 5]);

            #endregion

            #endregion
            #region Girilen metin içerisinde kaç adet 'n' karakterinin geçtiğini hesaplayalım

            #region 1.Çözüm

            //Console.Write("Lütfen bir metin giriniz: ");
            //string metin = Console.ReadLine();

            //int toplam = 0;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i].Equals('n'))
            //    {
            //        toplam++;
            //    }
            //}

            //Console.WriteLine(toplam);

            #endregion

            #region 2.Çözüm

            //Console.Write("Lütfen bir metin giriniz: ");
            //string metin = Console.ReadLine();

            //int toplam = 0;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == 'n')
            //    {
            //        toplam++;
            //    }
            //}

            //Console.WriteLine(toplam);

            #endregion


            #endregion
            #region Girilien metindeki kelime sayısını bulalım

            #region 1.Çözüm

            //Console.Write("Lütfen bir metin giriniz: ");
            //string metin = Console.ReadLine();

            //string[] kelimler = metin.Split(' ');

            //Console.WriteLine(kelimler.Length);

            #endregion

            #region 2.Çözüm

            //Console.Write("Lütfen bir metin giriniz: ");
            //string metin = Console.ReadLine();

            //int toplam = 1;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i].Equals(' '))
            //    {
            //        toplam++;
            //    }
            //}

            //Console.WriteLine($"Kelime sayısı: {toplam}");

            #endregion

            #endregion
            #region Kelimeleri CamelCase dönüştürme
            //public static string CamelCase(string str)
            //{
            //    string pattern = @"(\w)+";
            //    string result = null;
            //    foreach (Match m in Regex.Matches(str, pattern))
            //    {
            //        if (m.Index == 0)
            //        {
            //            result = m.Value;
            //            continue;
            //        }

            //        string tmp = m.Value.Substring(0, 1).ToUpper();
            //        tmp = tmp + m.Value.Substring(1).ToLower();
            //        result = result + tmp;
            //    }

            //    return result;
            //}
            #endregion
            #region Saat çevirme örneği(bitmedi)
            //public static string CountingMinutesI(string str)
            //{
            //    string[] time = str.Split('-');
            //    Console.WriteLine(Convert.ToDateTime(time[0].ToString("HH:mm")));
            //    int firstTimeHour = Convert.ToInt32(time[0].Substring(0, 2));
            //    int firstTimeMinute = Convert.ToInt32(time[0].Substring(3, 2));
            //    int secondTimeHour = Convert.ToInt32(time[1].Substring(0, 2));
            //    int secondTimeMinute = Convert.ToInt32(time[1].Substring(3, 2));

            //    string[] secondTime = time[0].Replace("am", "").Split(":");

            //    code goes here
            //    return str;

            //}
            #endregion
            #region Parantez Sayma
            //public static bool func(string str)
            //{
            //    int parantez = 0;

            //    foreach (char chr in str)
            //    {
            //        if (chr.Equals('('))
            //        {
            //            parantez++;
            //        }
            //        else if (chr.Equals(')'))
            //        {
            //            parantez--;
            //        }
            //    }

            //    if (parantez != 0)
            //    {
            //        return false;
            //    }

            //    return true;
            //}
            #endregion
            #endregion

            #region Regular Exporessions Operators
            #region ^ Operatörü
            //Satır başının istenilen ifadeyle başlamasını sağlar

            //string text = "91asdqwdadlpl12p1lpas";

            //Regex regex = new Regex("^91");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True

            #endregion
            #region \ Operatörü
            // \    : Belirli karakter gruplarını içermesini istiyorsak kullanırız.

            // \D   : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
            // \d   : Metinsel değerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir.

            // \W   : Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiği belirtilir. Alfanümerik karakterler: a-z A-Z 0-9
            // \w   : Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir.

            // \S   : Metinsel değerin ilgili yerinde boşluk karakterleri(tab/space) dışında herhangi bir karakterin olabileceği belirtilir.
            // \s   : Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir.

            // Örn: 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmyan bir düzenli ifade oluşturalım.

            //string text = "91 23123pasdğaqd";
            //Regex regex = new Regex(@"^9\d\S");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //False
            #endregion
            #region + Operatörü
            //Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılacaktır.

            // Örn: 9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmyan bir düzenli ifade oluşturalım.
            //string text = "912312a3d123123d";
            //Regex regex = new Regex(@"^9\d+\S");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True

            #endregion
            #region | Operatörü
            //Verilen karakterlerden biri olması yeterli.

            //string text = "zqawqwd";
            //Regex regex = new Regex(@"a|b|c");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True


            #endregion
            #region {n} Operatörü
            //Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli.

            //507-7514592
            //string text = "507-7514592";
            //Regex regex = new Regex(@"\d{3}-\d{6}");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True
            #endregion
            #region ? Operatörü
            //Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.
            //string text = "234BBA";
            //Regex regex = new Regex(@"\d{3}B?A");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //False
            #endregion
            #region . Operatörü
            // İlgili yerde herhangi bir karakterin kullanılabileceğini belirtir.
            // Kullanıldığı yerde \n karakteri dışında herhangi bir karakter bulunabilir.

            //string text = "123'A";
            //Regex regex = new Regex(@"\d{3}.A");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True
            #endregion
            #region \b \B Operatörleri
            // \B: Bu ifade ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir.
            // \b: Bu ifade ilgili kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar.

            //string text3 = "dır123"; //False
            //string text2 = "123dır"; //False
            //string text = "123dır123"; //True
            //Regex regex = new Regex(@"\d{3}dır\B");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True

            #endregion
            #region [n] Operatörleri
            // [n] : karakter aralığı belirtilebilir
            // Ayrıca özel karakterlerin yerinde yazılmasını da ifade eder.

            //string text2 = "123D"; //False
            //string text = "123A"; //True
            //Regex regex = new Regex(@"\d{3}[A-E]");

            //string text3 = "(507) 751 45 92"; //False
            //Regex regex3 = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");

            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success); //True

            #endregion
            #region Match Sınıfı Özellikleri

            //string text3 = "(507) 751 45 92";
            //Regex regex3 = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
            //Match match = regex3.Match(text3);

            //Console.WriteLine($"Success : {match.Success}"); // Patternin doğrulanma sonucu
            //Console.WriteLine($"Value : {match.Value}"); // doğrulanan metin
            //Console.WriteLine($"Index : {match.Index}"); // doğrulamanın hangi indexten başladığını bize bildirir.
            //Console.WriteLine($"Length : {match.Length}"); // doğrulamanın kısmın uzunluğu

            #endregion
            #endregion

            #region Collections: ArrayList
            //int[] yaslar = new int[17];
            //ArrayList _yaslar = new ArrayList();

            //yaslar[5] = 10;
            //_yaslar.Add(10);

            //for (int i = 0; i < 17; i++)
            //{
            //    yaslar[i] = i + 10;
            //    _yaslar.Add(i + 10);
            //}

            //Console.WriteLine(yaslar[5]);
            //Console.WriteLine(_yaslar[5]);

            ////ArrayList, verilen datayı boxing işlemine tabi tutar.
            ////ArrayList içerisindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir. Dolayısıyla kendi türünde işlem yapabilmek için unboxing işlemine tabi tutmamız gerekir. Diziden bir adım geride olduğu tek konu budur. Generic koleksiyonlar buradaki sınırlılıktan dolayı çıkmış gibi düşünebiliriz.
            //// Koleksiyonlarda eleman sayısını Count propertysi ile öğrenebilmekteyiz.

            //int toplam = 0;
            //for (int i = 0; i < _yaslar.Count; i++)
            //{
            //    if (_yaslar[i] is int)
            //    {
            //        toplam += (int)_yaslar[i];
            //    }
            //}

            ////ArrayList Collection Initializers
            //ArrayList arrayList = new ArrayList()
            //{
            //    "Ahmet",
            //    123,
            //    'a',
            //    true
            //};

            #endregion

            #region DateTime Struct

            //Console.WriteLine(DateTime.Now); //O anın tarih ve saat,dakika,saniye bilgisini getirir.
            //Console.WriteLine(DateTime.Today); //O anın tarih bilgisini getirir.

            //DateTime tarih1 = new DateTime(2021, 01, 01);
            //DateTime tarih2 = new DateTime(2022, 01, 01);
            //int result = DateTime.Compare(tarih1, tarih2); //Tarih bilgilerinde karşılaştırma yapar.-1,0,1 döner

            //if (result < 0)
            //{
            //    //1.tarih daha küçük yani geride demektir.
            //    Console.WriteLine($"{tarih1} küçüktür {tarih2}");
            //}
            //else if(result == 0)
            //{
            //    //Her iki tarih eşittir.
            //    Console.WriteLine($"{tarih1} eşittir {tarih2}");

            //}
            //else
            //{
            //    Console.WriteLine($"{tarih1} büyüktür {tarih2}");

            //}

            //zamanın üzerine ekleme işlemi yapmak için kullanılır.
            //tarih1.AddYears(1);
            //tarih1.AddMonths(1);
            //tarih1.AddHours(1);
            //tarih1.AddMilliseconds(1);
            //tarih1.AddDays(1);

            //yasHesapla();

            #endregion

            #region TimeSpan Struct

            //İki tarih arasındaki fark TimeSpan türünde geri dönecektir.
            //DateTime t1 = DateTime.Now;
            //DateTime t2 = new DateTime(2000, 1, 1);

            //TimeSpan span = t1 - t2;
            //Console.WriteLine(span.Days);

            #endregion


            Console.ReadKey();
        }

        static public void yasHesapla()
        {
            Console.WriteLine("Lütfen doğum tarihi giriniz.");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());

            int gun = (DateTime.Now - dogumTarihi).Days;

            int yas = gun / 365;
            int kalan = gun % 365;

            Console.WriteLine($"Yaş: {yas} | {yas + 1} yaşınıza kalan gün sayısı : {365 - kalan + (yas / 4)}");
        }
    }
}
