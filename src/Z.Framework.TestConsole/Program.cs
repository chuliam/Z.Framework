using System;
using Z.Framework.Extension;

namespace Z.Framework.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123".SafeToInt32());
            Console.ReadLine();
        }
    }
}
