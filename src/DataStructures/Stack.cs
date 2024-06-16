namespace DataStructures;

public class Stack<T>
{
    private readonly LinkedList<T> _list = new();

    public bool IsEmpty => _list.IsEmpty;

    public T Peek()
    {
        if (_list.IsEmpty)
        {
            throw new InvalidOperationException("Unable to peek at value; the stack is empty.");
        }

        return _list.GetHead();
    }

    public T Pop()
    {
        if (_list.IsEmpty)
        {
            throw new InvalidOperationException("Unable to pop value; the stack is empty.");
        }

        var value = _list.GetHead();
        _list.RemoveFromHead();

        return value;
    }

    public void Push(T value) => _list.AddToHead(value);
}
