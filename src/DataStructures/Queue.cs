namespace DataStructures;

public class Queue<T>
{
    private readonly LinkedList<T> _list = new();

    public bool IsEmpty => _list.IsEmpty;

    public T Dequeue()
    {
        if (_list.IsEmpty)
        {
            throw new InvalidOperationException("Unable to dequeue value; the queue is empty.");
        }

        var value = _list.GetHead();
        _list.RemoveFromHead();

        return value;
    }

    public void Enqueue(T item) => _list.AddToTail(item);

    public T Peek()
    {
        if (_list.IsEmpty)
        {
            throw new InvalidOperationException("Unable to peek at first value; the queue is empty.");
        }

        return _list.GetHead();
    }
}
