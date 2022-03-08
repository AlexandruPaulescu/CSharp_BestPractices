using System;

namespace Prestige.Biz
{
    public class Program
    {
        public const int ConstNumber = 100;
        public static readonly int ReadOnlyNumber = 0;

        static Program()
        {
            ReadOnlyNumber = 12;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(ConstNumber);
            //Console.WriteLine(ReadOnlyNumber);
            Agency agency = null;
            Console.WriteLine(agency?.Name);
        }
    }
}
