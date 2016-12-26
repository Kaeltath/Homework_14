using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSouls
{
    class BubbleSorter<T>: Sorter<T> where T: IComparable
    {
        private T[] itemsList;

        public BubbleSorter(T[] itemsList)
            : base(itemsList)
        {
            this.itemsList = itemsList;
        }
        public override void Sort()
        {
            bool swap = true;
            int i = 0;
            while (swap && i < itemsList.Length)
            {
                for (int j = 0; j < itemsList.Length - i - 1; j++)
                {
                    if (itemsList[j].CompareTo(itemsList[j + 1])>0)
                    {

                        Swap(j, j + 1);
                        swap = true;
                        continue;
                    }
                    swap = false;


                }
                i++;
            }
        }
    }
}
