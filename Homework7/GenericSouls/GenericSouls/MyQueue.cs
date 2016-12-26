using System;

namespace GenericSouls
{
    public class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int tail;
        private int head;

        public MyQueue() 
        {
            Maximum = 5;
        }

        public MyQueue(int max) 
        {
            Maximum = max;
            ItemsList[0] = default(T);
        }
      
        public void Enqueue(T elementToEnqueue)
        {
            counter++;
            if (IsFull())
            {
                Console.WriteLine(" item overlaped...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (tail < ItemsList.Length - 1)
            {
                ItemsList[tail] = elementToEnqueue;
                tail++;

            }
            else
            {
                ItemsList[tail] = elementToEnqueue;
                tail = 0;
            }
        }

        public T Dequeue()
        {
            T value;
            if (head < ItemsList.Length - 1)
            {
                value = ItemsList[head];
                head++;
                counter--;
                return value;
            }

            value = ItemsList[head];
            head = 0;
            counter--;
            return value;
        }
        public override bool IsFull()
        {
            if (counter > ItemsList.Length)
            {
                return true;
            }

            return false;
        }
    }
}