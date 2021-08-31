using System;
using System.Collections.Generic;

class LinkedList<T>
{
    Node<T> head;

    public LinkedList()
    {
        head = new Node<T>(default);
    }

    // Insert a Node at the end of the list.
    public void Insert(T data)
    {
        Node<T> node = head;
        Node<T> n = new Node<T>(data);

        while (node.next != null) node = node.next;

        node.next = n;
        n.next = null;
    }

    // Delete the first occurence of data found within the list.
    public void Delete(T data)
    {
        Node<T> current = head;
        Node<T> previous = new Node<T>(default);

        if (Search(data))
        {
            while (current != null && !EqualityComparer<T>.Default.Equals(current.data, data))
            {
                previous = current;
                current = current.next;
            }

            previous.next = current.next;
        }
    }

    // Search for data within the list.
    public bool Search(T data)
    {
        Node<T> node = head;
        while (node != null)
        {
            if (EqualityComparer<T>.Default.Equals(node.data, data))
            {
                Console.WriteLine($"{data} exists!");
                return true;
            }

            node = node.next;
        }
        Console.WriteLine($"{data} does not exist!");
        return false;
    }

    // Display the LinkedList.
    public void Display()
    {
        Node<T> node = head;
        while(node != null)
        {
            Console.Write($"[{node.data}]");
            node = node.next;
        }
        Console.WriteLine();
    }
}
