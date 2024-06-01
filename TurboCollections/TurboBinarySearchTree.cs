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

    public class TurboBinarySearchTree <T> : IEnumerable<T>
    {
        private Node<T> root; //root node for the tree
        private Comparer<T> comparer;

        public TurboBinarySearchTree(Comparer<T> comparer)
        {
            root = null;
            this.comparer = comparer;
        }
    }
