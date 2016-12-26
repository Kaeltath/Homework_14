using System;

namespace GenericSouls
{
    public abstract class Buffer<T>: IBuffer<T>
    {
        private int max;
        protected int counter;
        private T[] itemsList;


        public int Maximum {
            set { max = value; }
            get { return max; }
        }

        public T[] ItemsList 
        {
            get
            {
                if (itemsList == null) 
                {
                    itemsList = new T[max];
                }
                return itemsList; }

             
        }

        public abstract bool IsFull();

        public bool IsEmpty()
        {
            if (counter == 0)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            string test;
            test = itemsList[0] as string;
            if (test == string.Empty)
            {
                Console.WriteLine("String is empty");
            }
            else{
            foreach (T i in itemsList)
            {
               Console.WriteLine(i);
            }
            Console.WriteLine();
         }
        }
    }
}
