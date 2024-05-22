
using System.Collections;

namespace TurboCollections;

public interface ITurboQueue<T> : IEnumerable<T> 
{
    int Count {get;} // returns the current amount of items contained in the stack.
    void Enqueue(T item);   // adds one item to the back of the queue.
    T Peek(); 
    T Dequeue();
    void Clear();
}


public class TurboLinkedQueue<T> : ITurboQueue<T>
{
    class Node 
    {
        public T Value;
        public Node Next;
    }
    Node FirstNode;

    public int Count
    {
        get
        {
            int count = 0;
            var customer = FirstNode;
            while (customer != null)
            {
                count++;
                customer = customer.Next;
            }

            return count;
        }
    }

    public void Enqueue(T value)
    {
        Node newNode = new()
        {
            Value = value,
            Next = null
        };
        if (FirstNode == null)
        {
            FirstNode = newNode;
        }

        else
        {
            var customer = FirstNode;
            while (customer.Next != null)
            {
                customer = customer.Next;
            }

            customer.Next = newNode;
        }
    }

    public T Peek() // returns the item in the front of the queue without removing it.
    {
        if (FirstNode == null)
            throw new InvalidOperationException("The queue is empty.");
        return FirstNode.Value;
    }

    public T Dequeue() // returns the item in the front of the queue and removes it at the same time.
    {
        var temp = FirstNode;
        FirstNode = temp.Next;
        return temp.Value;

    }

    public void Clear()  // removes all items from the queue.
    {
        FirstNode = null;
    }
    
    //Iterate over all nodes and yield return the current node's value
    public IEnumerator<T> GetEnumerator()
    {
        var customer = FirstNode;
        while (customer != null)
        {
            yield return customer.Value;
            customer = customer.Next;
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    // Everything else is super similar to the TurboLinkedStack!
}