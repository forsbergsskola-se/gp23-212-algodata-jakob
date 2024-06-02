
using System.Collections;

namespace TurboCollections.Test;

[TestFixture]
public class TurboBinarySearchTreeTests
{
    private Comparer comparer; //Comparer for the BST

    [SetUp]
    public void Setup()
    {
        comparer = Comparer.Default;
    }


    [Test]
    public void InsertTest() 
    {
        //creating a BST
        var tree = new TurboBinarySearchTree<int>(comparer);

        //Insert values in to the tree
        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        //checking if the inserted values exist in the tree
        Assert.IsTrue(tree.Search(5));
        Assert.IsTrue(tree.Search(2));
        Assert.IsTrue(tree.Search(4));
        Assert.IsTrue(tree.Search(8));
        Assert.IsTrue(tree.Search(3));
    }

    [Test]
    public void SearchTest() 
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        //Same as above
        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        // checking if the Search method returns true for a value that exists in the tree
        Assert.IsTrue(tree.Search(3));
        
        //doing the opposite
        Assert.IsFalse(tree.Search(7));
    }

    [Test]
    public void DeleteTest() 
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        //Same as above
        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        // Delete a value from the tree
        Assert.IsTrue(tree.Delete(3));
        
        // checking if the value is still in the tree
        Assert.IsFalse(tree.Search(3));
        
        // attempting to delete a already deleted value returns false
        Assert.IsFalse(tree.Delete(7));
    }

    [Test]
    public void GetEnumeratorTest()
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        //Same as above
        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        //Create a list of the expected order from the tree
        var expectedOrder = new List<int> { 2, 3, 4, 5, 8 };
        
        //Get the tree values in order and compare to the expected order
        var actualOrder = new List<int>(tree);

        Assert.AreEqual(expectedOrder, actualOrder);
    }
    
    [Test]
    public void TreeTest()
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        // same as above
        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(8);
        tree.Insert(1);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(9);
        
        //does an inorder traversal of the tree
        var inOrderTraversal = new List<int>(tree);
        
        //define the expected traversal order
        var expectedTraversal = new List<int> { 1, 2, 3, 5, 7, 8, 9 };
        
        //controlling so both traversal orders matches
        CollectionAssert.AreEqual(expectedTraversal, inOrderTraversal);
    }

}

