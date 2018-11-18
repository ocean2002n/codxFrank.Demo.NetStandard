using NetStandardClassLibrary;
using System;

namespace NetFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is .net framework console executing...");
            var cls = new NetStandardClass();
            Console.WriteLine(cls.GetString());
            Console.ReadKey();
        }
    }
}
