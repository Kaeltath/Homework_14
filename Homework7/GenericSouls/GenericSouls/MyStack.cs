using System;

namespace GenericSouls
{
    public class MyStack<T>: Buffer<T>, IMyStack<T>
    {

        public MyStack() 
        {
            Maximum = 5;            
        }

        public MyStack(int max) 
        {
            Maximum = max;            
        }

        public void Push(T toPushValue)
        {
            if (IsFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            ItemsList[counter] = toPushValue;
            counter++;
        }

        public T Pop()
        {
            counter--;
            return ItemsList[counter];
        }

        public T Peek()
        {
            return ItemsList[counter - 1];
        }
        public override bool IsFull()
        {
            if (counter == ItemsList.Length)
            {
                return true;
            }
            return false;

        }
    }
}
