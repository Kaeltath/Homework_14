using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSouls
{
    class InsertionSorter<T>: Sorter<T> where T: IComparable
    {
        private T[] itemsList;

        public InsertionSorter(T[] itemsList)
            : base(itemsList)
        {
            this.itemsList = itemsList;
        }
        public override void Sort()
        {
            for (int i = 1; i < itemsList.Length; i++)
            {
                int j = i;
                while (j > 0 && itemsList[j].CompareTo(itemsList[j - 1]) < 0)
                    {
                        Swap(j, j - 1);
                        j--;
                    }
               }
            
            }
        }
    }

