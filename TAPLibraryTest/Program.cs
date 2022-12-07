using System;

namespace TAPLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var starting = "RVing100!";
            //var starting = "Actr$01#";
            var starting = "P@ssword.1";

            Console.WriteLine(TAPLibrary.Ext.Decrypt("Jk/5eizR9xL5LjURZqd4iQ=="));
            Console.WriteLine(TAPLibrary.Ext.Decrypt("4jvkRwQq2rOAqoWKRiQBpw=="));

            //            Console.WriteLine(TAPLibrary.Ext.Encrypt(starting));

            Console.WriteLine(TAPLibrary.Ext.Decrypt("O6oPwK2nBppnvBNhRElLOQ=="));
            Console.WriteLine(TAPLibrary.Ext.Decrypt("tYw8Y5rO9gUD3W1u8Jkj5Q=="));


            Console.WriteLine(TAPLibrary.Ext.Decrypt("ni5NIXb6VGWtFgZ7fyAniA=="));
            Console.WriteLine(TAPLibrary.Ext.Decrypt("tYw8Y5rO9gUD3W1u8Jkj5Q=="));

            Console.ReadKey();
        }
    }
}
