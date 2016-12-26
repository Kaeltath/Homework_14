using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IMyQueue<T>
    {
        void Enqueue(T ToEnqueueu);
        T Dequeue();
    }
}
