using System.Collections;

namespace Algos;

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

    public bool IsEmpty => _count == 0;

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

    public T GetHead() => throw new NotImplementedException();

    public T GetTail() => throw new NotImplementedException();

    public void RemoveAtIndex(int index) => throw new NotImplementedException();

    public void RemoveFromHead() => throw new NotImplementedException();

    public void RemoveFromTail() => throw new NotImplementedException();

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
