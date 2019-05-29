using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        private static void Threadwork()
        {
            Console.WriteLine("i am a thread...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}, {i}");
            }
        }

        private static void Threadwork2(object obj)
        {
            Console.WriteLine("i am a thread...");

            int b = (int)obj;
            for (int i = b; i < b+5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}, {i}");
            }
        }

        static void Main(string[] args)
        {
            //Thread t = new Thread(Threadwork);
            //t.IsBackground = true;
            //t.Start();

            
            List<Thread> threads = new List<Thread>();
 

            for (int i = 0; i < 5; i++)
            {
                threads.Add(new Thread(Threadwork2));                
            }

            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Start(i*5+1);
                threads[i].Join();
            }

        }
    }
}