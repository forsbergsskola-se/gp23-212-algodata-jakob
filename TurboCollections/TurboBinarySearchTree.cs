namespace TurboCollections;

    public class Node <T>
    {
        public T Value;
        public Node <T> LeftChild;
        public Node <T> RightChild;

        public Node(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }

    public class TurboBinarySearchTree<T> : IEnumerable<T>
    {
        private Node<T> root; //root node for the tree
        private Comparer<T> comparer; //comparing value types of T

        public TurboBinarySearchTree(Comparer<T> comparer)
        {
            root = null; //Sets the root to null
            this.comparer = comparer;
        }
        
        public void Insert(T value)
        {
            root = InsertDirection(root, value);
        }

        private Node<T> InsertDirection(Node<T> node, T value)
        {
            // If the current node is null, create a new node with the given value
            if (node == null)
            {
                return new Node<T>(value);
            }

            // Compare the value with the current node's value
            if (comparer.Compare(value, node.Value) > 0)
            {
                // If the value is greater, put it in the right tree
                node.RightChild = InsertDirection(node.RightChild, value);
            }
            else
            {
                // If the value is less or equal, put it in the left tree
                node.LeftChild = InsertDirection(node.LeftChild, value);
            }

            // Return the updated node
            return node;
        }


    }

    
