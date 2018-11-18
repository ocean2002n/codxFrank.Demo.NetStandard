using System;
using NetStandardClassLibrary;

namespace NetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is .net core console executing...");
            var cls = new NetStandardClass();
            Console.WriteLine(cls.GetString());
            Console.ReadKey();
        }
    }
}
