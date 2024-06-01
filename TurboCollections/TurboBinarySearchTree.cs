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
        private IEnumerable<T> _enumerableImplementation;

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

        public bool Search(T value)
        {
            //Start searching from the root node
            Node<T> current = root;
            
             // it continues searching until the current node is null   
            while (current != null)
            {
                //if the current node has a value return true
                if (comparer.Compare(value, current.Value) == 0)
                {
                    return true;
                }
                
                //if the value is greater than current nodes value, it gets move to the right side,
                //similar to the insert method
                else if (comparer.Compare(value, current.Value) > 0)
                {
                    current = current.RightChild;
                }
                
                else
                {
                    //if not moves to the left side
                    current = current.LeftChild;
                }
            }
            // it returns false if the value is not found when traversing the tree
            return false;
        }

        public bool Delete(T value)
        {
            
        }


    }

    
