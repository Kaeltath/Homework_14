namespace GenericSouls
{
    public interface IMyQueue<T>  
    {
       void Enqueue(T ElementToEnqueue);
       T Dequeue();
    }
}
