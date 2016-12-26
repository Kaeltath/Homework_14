using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
   public class DynamicQueue<T> : Buffer<T>, IMyQueue<T> , IPrintable
    {
        private int MaxSize = 39;
        DynamicArray<T> Buffer = new DynamicArray<T>();

        public DynamicQueue(int maxsize) 
        {
            MaxSize = maxsize;
        }

        public void Enqueue(T ElementToEnqueue)
        {
            if (Buffer.Size < MaxSize)
            {
                Buffer.Add(ElementToEnqueue);
            }
            else 
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Dequeue()
        {
            T temp = Buffer.Get(0);
            Buffer.Remove(0);
            return temp;
        }
    }
}
