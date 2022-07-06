using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] name = new string[] { "alper", "burak", "umut", "batu" };
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);
            //Console.WriteLine(name[3]);

            List<string> names = new List<string> { "alper", "burak", "umut", "batu" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names.Add("berk");
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);

        }
    }
}
