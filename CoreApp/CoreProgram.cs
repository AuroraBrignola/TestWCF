using System;
using System.IO;
using ClassLibrary;

namespace CoreApp
{
    class CoreProgram
    {
        static void Main(string[] args)
        {
            Class1 client = new Class1();
            
            Console.WriteLine(client.GetLength(@"C:\FileStorageSource\aurora.txt"));
            
            Console.ReadLine();
        }
    }
}
