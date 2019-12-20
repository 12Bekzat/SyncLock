using System;
using System.Collections.Generic;
using System.Threading;

namespace SyncLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>{
            new Account{Name = "Бекзат"},
            new Account{Name = "Алихан"},
            new Account{Name = "Борис"},
            new Account{Name = "Наиль"}
            };
            for (int i = 0; i < 1000; i++)
            {
                int chooise = new Random().Next(0, 2);
                int index = new Random().Next(0, 4);
                if (chooise == 0)
                {

                    ThreadPool.QueueUserWorkItem(accounts[index].Process, 100);
                }
                else if (chooise == 1)
                {
                    ThreadPool.QueueUserWorkItem(accounts[index].Process, -100);
                }
            }
            Console.ReadLine();
        }
    }
}
