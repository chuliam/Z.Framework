using System;
using System.Linq;
using System.Collections.Generic;
using Z.Framework.Extension;

namespace Z.Framework.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source = new List<string>();
            //source = source.AsQueryable().OrderByField("", "").ToList();
            Console.WriteLine("123".SafeToInt32());
            Console.ReadLine();
        }
    }
}
