using Node;
using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private Node<T> head;
    private Node<T> tail;
    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        var newNode = new Node<T>(element);
        if (this.Count==0)
        {
            this.head = newNode;
            this.tail = newNode;
        }
        else
        {
            this.head.Prev = newNode;
            newNode.Next = this.head;
            this.head = newNode;

        }
        this.Count++;
    }

    public void AddLast(T element)
    {
        throw new NotImplementedException();
    }

    public T RemoveFirst()
    {
        throw new NotImplementedException();
    }

    public T RemoveLast()
    {
        throw new NotImplementedException();
    }

    public void ForEach(Action<T> action)
    {
        var currNode = this.head;

        while (currNode != null)
        {
            action(currNode.Value);
            currNode = currNode.Next;
            
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public T[] ToArray()
    {
        throw new NotImplementedException();
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}
