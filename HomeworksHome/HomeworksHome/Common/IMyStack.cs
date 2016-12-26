using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IMyStack<T>
    {
        void Push(T valueToAdd);
        T Pop();
        T peek();
    }
}
