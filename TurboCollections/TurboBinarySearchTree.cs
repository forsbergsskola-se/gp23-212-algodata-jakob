using System.Collections;

namespace TurboCollections;

public class TurboBinarySearchTree<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Value;
            public Node LeftChild;
            public Node RightChild;

            public Node(T value)
            {
                Value = value;
                LeftChild = null;
                RightChild = null;
            }
        }
        private Node root; //root node for the tree
        private Comparer comparer; //comparing value types of T
        
        public TurboBinarySearchTree(Comparer comparer)
        {
            root = null; //Sets the root to null
            this.comparer = comparer;
        }
        
        //INSERT METHOD
        public void Insert(T value)
        {
            root = InsertHelper(root, value);
        }

        private Node InsertHelper(Node node, T value)
        {
            // If the current node is null, create a new node with the given value
            if (node == null)
            {
                return new Node(value);
            }

            // Compare the value with the current node's value
            if (comparer.Compare(value, node.Value) > 0)
            {
                // If the value is greater, put it in the right tree
                node.RightChild = InsertHelper(node.RightChild, value);
            }
            else
            {
                // If the value is less or equal, put it in the left tree
                node.LeftChild = InsertHelper(node.LeftChild, value);
            }

            // Return the updated node
            return node;
        }

        //SEARCH METHOD
        public bool Search(T value)
        {
            //Start searching from the root node
            Node current = root;
            
             // it continues searching until the current node is null   
            while (current != null)
            {
                var comparison = comparer.Compare(value, current.Value);
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
        
        //DELETE METHOD:
        public bool Delete(T value)
        {
            // Call the helper method to perform the delete operation
            bool found;
            (root, found) = DeleteHelp(root, value);
            return found;
        }

        private (Node, bool) DeleteHelp(Node node, T value)
        {
            // If the current node is null, return null and indicate that the node was not found
            if (node == null)
            {
                return (null, false);
            }

            // Compare the value to be deleted with the current node's value
            var comparison = comparer.Compare(value, node.Value);
            
            if (comparison < 0)
            {
                // If the value is less than the current node's value, move to the left subtree 
                (node.LeftChild, bool found) = DeleteHelp(node.LeftChild, value);
                return (node, found);
            }
            else if (comparison > 0)
            {
                // If the value is greater than the current node's value, move to the right subtree
                (node.RightChild, bool found) = DeleteHelp(node.RightChild, value);
                return (node, found);
            }
            else
            {
                // Node to be deleted found
                
                // Node with only one child or no child

                if (node.LeftChild == null)
                {
                    return (node.RightChild, true);
                }
                else if (node.RightChild == null)
                {
                    return (node.LeftChild, true);
                }

                // Node with two children
                Node replace = MinValueNode(node.RightChild);
                
                node.Value = replace.Value;
                
                (node.RightChild, _) = DeleteHelp(node.RightChild, replace.Value);
                
                return (node, true);
            }
        }

        private Node MinValueNode(Node node)
        {
            Node current = node;
            while (current.LeftChild != null)
            {
                current = current.LeftChild;
            }
            return current;
        }


        
        //ITERATOR PATTERNS:
        
        // Inorder traversal method
        private IEnumerable<T> InOrderTraversal(Node node)
        {
            if (node == null)
                yield break;
            {
                // Traverse the left subtree
                foreach (var n in InOrderTraversal(node.LeftChild))
                    yield return n;
                
                // Yield the current node's value
                yield return node.Value;
                
                // Traverse the right subtree
                foreach (var n in InOrderTraversal(node.RightChild))
                    yield return n;
            }
            
        }
        
        //  implementing inorder traversal
        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal(root).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
