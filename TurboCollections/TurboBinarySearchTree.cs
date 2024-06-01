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
            if (root == null)
            {
                root = new Node<T>(value);  // Creates a node if the tree is empty
                return;
            }
            
            // Start process starting from the root
            Node<T> current = root;
            while (true)
            {
                //Compare value with the current nodes value
                if (comparer.Compare(value, current.Value) > 0)
                {
                    //if the value is greater, move to he right side of the tree
                    if (current.RightChild == null)
                    {
                        current.RightChild = new Node<T>(value);  //if there is no node on the right side, create one
                        break;
                    }
                    else
                    {
                        current = current.RightChild; //if there already is a right child, move to it for further traversal.
                    }
                }
                else
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = new Node<T>(value);  // same functions only on the opposite side
                        break;
                    }
                    else
                    {
                        current = current.LeftChild;
                    }
                }
            }
        }


    }

    
