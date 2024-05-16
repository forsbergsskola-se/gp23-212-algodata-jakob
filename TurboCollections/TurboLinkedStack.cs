using System.Collections;

namespace  TurboCollections;

public class TurboLinkedStack<T> : IEnumerable<T> {
    class Node {
        public T Value;
        public Node Previous;
    }
    Node LastNode;

    public void Push(T item)
    {
        var newNode = new Node
        {
            Value = item,
            Previous = null
        };
        LastNode.Previous = newNode;
        LastNode = newNode;
    }

    public T Peek()
    {
        return LastNode.Value;
    }

    public T Pop()
    {
        // 1. Save the Last Node locally so we can return the value later.
        T localNode = Peek();
        // 2. Now, assign the Last Node's Previous Node to be the Last Node.
        LastNode = LastNode.Previous;
        // -- This effectively removes the previously Last Node of the Stack
        // -- Imagine LastNode is customer 436
        // -- -- who remembered that customer 435 was before him.
        // -- We assign that before customer 435 to LastNode.
        // -- -- 435 knows that 434 was before him.
        // -- -- But he has no memory of customer 436.

        // Now, return the Value of the Node that you cached in Step 1.
        return localNode;
    }

    public void Clear() {
        // This one is incredibly easy. Just assign null to Field LastNode
        LastNode = null;
        // -- This is like pretending you never new that there is any last customer.
        // -- by forgetting the latest customer, you forget them all.
    }

    public int Count {
        get{
            // Here, you need to do a while loop over all nodes
            // Similar to the previous PrintAllNodes Function
            // But instead of Printing Nodes, you just count how many Nodes you have visited
            // Similar to this:
            int count = 0;
            while(false/* remove false and replace with correct condition...*/){
                count++;
            }
            return count;
        }
    }

    // Iterate over all nodes and yield return the current node's value
    public IEnumerator<T> GetEnumerator() {
        throw new NotImplementedException();
        Node current = LastNode;
        // Now, while the current node is not null, do:
        //     yield return the current node's value
        //     then, assign the current node's previous Node to current
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}