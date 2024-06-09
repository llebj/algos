using System.Collections;

namespace Algos;

public class LinkedList<T> : IEnumerable<T>
{
    private Node<T>? _head;

    public LinkedList(IEnumerable<T> values)
    {
        if (!values.Any())
        {
            return;
        }

        Node<T>? previous = null;

        foreach (var value in values)
        {
            var node = new Node<T>(value);

            if (previous is null)
            {
                previous = node;
                _head = node;
            }
            else
            {
                previous.Next = node;
                previous = node;
            }
        }
    }

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
