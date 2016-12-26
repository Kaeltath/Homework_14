using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public interface IMyStack<T> 
    {
            void Push(T toPushValue);
            T Pop();
            T Peek();

     }
    
}
