using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace SyncLock
{
    public class Account
    {
        private object syncObject = new object();

        public int Sum { get; set; } = 1000;
        public string Name { get; set; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Process(object sum)
        {
            Sum += (int)sum;
            Console.WriteLine(@"{0} {1}-а {2} {3}, итог: {4}", (int)sum > 0 ? "К счету" : "Со счета", Name, (int)sum > 0 ? "пополнено" : "снято", sum, Sum);
        }
    }
}
