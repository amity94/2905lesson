using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2906hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(multiplynumbers);
            Thread t2 = new Thread(ThreadWork);
            t.Start();
            t2.Start();
                
        }

        private static void ThreadWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            }
        }

        private static void multiplynumbers()
        {
            Random r = new Random();
            int a = r.Next(9);
            int b = r.Next(9);
            Console.WriteLine($"{a} * {b}");

            int input = 0;
            while(input != a*b)
            {
                Console.WriteLine("input answer");
                input = int.Parse(Console.ReadLine());
            }
            if(input == a*b)
                Console.WriteLine("You Are Great");
        }
    }
}
