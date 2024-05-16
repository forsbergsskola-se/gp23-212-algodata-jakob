
namespace TurboCollections;

public interface ITurboQueue<T> : IEnumerable<T> {
    int Count {get;} // returns the current amount of items contained in the stack.
    void Enqueue(T item);   // adds one item to the back of the queue.
    T Peek();  // returns the item in the front of the queue without removing it.
    T Dequeue(); // returns the item in the front of the queue and removes it at the same time.
    void Clear(); // removes all items from the queue.
}

public class TurboLinkedQueue<T> : ITurboQueue<T>

{
    class Node {
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
        // This is a bit more complicated. You need to let the last Node in the Queue know who's next after him.
        // No other choice but looping through your Nodes until you reach the end.
        // You know that you've reached the end, if the current Node's Next Node is null.
        // Then, you assign a new Node containing the value to the current node's Next field.

        // Analogy: In our store, we always remember who's the first that arrived. When a new customer arrives, we tell the last customer, that the new customer will be after them.
        // However, we only know, who's the first customer. And each customer knows, who comes after them. So we continue asking each customer, who comes after them, until one says: "No one! I'm last in the Queue" and we can tell them: "Not anymore! This new customer is now last in the queue"
    }

    // Everything else is super similar to the TurboLinkedStack!
}