using System.Collections;

namespace DataStructures;

public class LinkedList<T> : IEnumerable<T>
{
    private int _count = 0;
    private Node<T>? _head;
    private Node<T>? _tail;

    public LinkedList()
    {

    }

    public LinkedList(IEnumerable<T> values)
    {
        foreach (var value in values)
        {
            AddToTail(value);
        }
    }

    public int Count => _count;

    public bool IsEmpty => _count == 0 && _head is null && _tail is null;

    public void AddAtIndex(int index, T value) => throw new NotImplementedException();

    public void AddToHead(T value)
    {
        var node = new Node<T>(value);

        if (_head is not null)
        {
            node.Next = _head;
            _head.Previous = node;
        }
        else
        {
            // If head is null then this is the first item to be added to the list,
            // therefore, we need to set tail as well.
            _tail = node;
        }

        _head = node;
        ++_count;
    }

    public void AddToTail(T value)
    {
        var node = new Node<T>(value);

        if (_tail is not null)
        {
            _tail.Next = node;
            node.Previous = _tail;
        }
        else
        {
            // If tail is null then this is the first item to be added to the list,
            // therefore, we need to set head as well.
            _head = node;
        }

        _tail = node;
        ++_count;
    }

    public T GetAtIndex(int index) => throw new NotImplementedException();

    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;

        while (current is not null)
        {
            var currentValue = current.Value;
            current = current.Next;
            yield return currentValue;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public T GetHead()
    {
        if (_head is null) 
        {
            throw new InvalidOperationException("Cannot get head; the linked list contains no elements.");
        }

        return _head.Value;
    }

    public T GetTail()
    {
        if (_tail is null)
        {
            throw new InvalidOperationException("Cannot get tail; the linked list contains no elements.");
        }

        return _tail.Value;
    }

    public void RemoveAtIndex(int index) => throw new NotImplementedException();

    public void RemoveFromHead()
    {
        if (_head is null)
        {
            throw new InvalidOperationException("Cannot remove from head; the linked list contains no elements.");
        }

        var newHead = _head.Next;
        _head.Next = null;
        _head = newHead;

        if (_head is not null)
        {
            _head.Previous = null;
        }
        else
        {
            // If current head is null then we removed the last item in the list
            // and we need to set _tail to be null as well.
            _tail = null;
        }

        --_count;
    }

    public void RemoveFromTail()
    {
        if (_tail is null)
        {
            throw new InvalidOperationException("Cannot remove from tail; the linked list contains no elements.");
        }

        var newTail = _tail.Previous;
        _tail.Previous = null;
        _tail = newTail;

        if (_tail is not null)
        {
            _tail.Next = null;
        }
        else
        {
            // If current tail is null then we removed the last item in the list
            // and we need to set _head to be null as well.
            _head = null;
        }

        --_count;
    }

    public void Reverse() => throw new NotImplementedException();

    private class Node<TNode> where TNode : T
    {
        public Node(TNode value)
        {
            Value = value;
        }

        public Node<TNode>? Next { get; set; }

        public Node<TNode>? Previous { get; set; }

        public TNode Value { get; set; }
    }
}
