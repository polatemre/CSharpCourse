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
            MyClass myClass = new()
            {
                MyProperty = 10,
                MyProperty2 = 12
            };
            #endregion


        }
    }

    /// <summary>
    /// Bu bir örnek classtır.
    /// </summary>
    class MyClass
    {
        public int a; //field

        /// <summary>
        /// Bu bir propertydir.
        /// </summary>
        public int MyProperty { get; set; } //property
        public int MyProperty2 { get; set; } //property

        /// <summary>
        /// Bu bir metottur.
        /// </summary>
        public void X() { } //method

        /// <summary>
        /// Bu bir örnek metot overloadıdır.
        /// </summary>
        /// <param name="a">a parametresi...</param>
        public void X(int a) { } //method

        public int this[int a] //indexer
        {
            get { return 0; }
        }

        public class MyClass2 // nested class
        {

        }
    }
}
