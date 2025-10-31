using System;
using System.Net.Http.Headers;

namespace hello
{
    internal class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("hello everyvone");
        }
        public static void greetWhite()
        {
            Console.WriteLine("hello white");
        }
        public static void greetBlack()
        {
            Console.WriteLine("hello black");
        }
        public static void Main(string[] args)
        {
            SayHello();
            greetBlack();
            greetWhite();
        }
    }
}