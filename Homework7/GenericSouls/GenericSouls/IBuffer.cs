using System;

namespace GenericSouls
{
    public interface IBuffer <T> : IPrintable
    {
        bool IsFull();
        bool IsEmpty();
    }
}
