using System;

namespace Node
{
    public class Node<T>
    {
        public T Value { get; private set; }

        public Node<T> Next { get; set; }

        public Node<T> Prev { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }

    }
}
