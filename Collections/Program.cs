using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Emre", "Halil" }; // sabit uzunlukludur, tek sefer tanımlanır.
            //names[4] = "Eren"; // hata verir, dizi sınırı aşıldı.

            List<string> names2 = new List<string> { "Engin", "Murat", "Emre", "Halil" };
            names2.Add("Eren"); // List boyutu arttırılabilir. 
            Console.WriteLine(names2[4]);


        }
    }
}
