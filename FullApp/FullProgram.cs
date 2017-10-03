using System;
using ClassLibrary;

namespace FullApp
{
    class FullProgram
    {
        static void Main(string[] args)         
        {
            Class1 client = new Class1();

            //client.Configure("http://localhost:8733/Design_Time_Addresses/DwarfsWCF/Service/");
            Console.WriteLine(client.GetLength(@"C:\FileStorageSource\aurora.txt"));

            Console.ReadLine();
        }
    }
}
