using System;
using System.Threading;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD!");
           // Calling.GenericEqual();
           // Calling.AreEqualMethod();

            CoparisionCls.Init();
            Console.ReadKey();
            //Thread.Sleep(3000);
        }
    }
}
