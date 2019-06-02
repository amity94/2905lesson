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
            Random r = new Random();
            int a = r.Next(9);
            int b = r.Next(9);
            Console.WriteLine($"{a} * {b} = ?");

            Thread t = new Thread(() =>
            {
                for (int i = 5; i >= 0; i--)
                {
                    Console.WriteLine($"{i} seconds left");
                    Thread.Sleep(1000);
                }
            });
            t.Start();

            int result = int.Parse(Console.ReadLine());

            if(t.ThreadState != ThreadState.Stopped && result == a*b)
                Console.WriteLine("You Are Great!");
            else
                Console.WriteLine("Booooooo!");
            t.Abort();
        }
    }
}