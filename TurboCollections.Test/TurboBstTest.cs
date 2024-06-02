
using System.Collections;

namespace TurboCollections.Test;

[TestFixture]
public class TurboBinarySearchTreeTests
{
    private Comparer comparer;

    [SetUp]
    public void Setup()
    {
        comparer = Comparer.Default;
    }


    [Test]
    public void InsertTest()
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

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

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        Assert.IsTrue(tree.Search(3));
        Assert.IsFalse(tree.Search(7));
    }

    [Test]
    public void DeleteTest()
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        Assert.IsTrue(tree.Delete(3));
        Assert.IsFalse(tree.Search(3));
        Assert.IsFalse(tree.Delete(7));
    }

    [Test]
    public void GetEnumeratorTest()
    {
        var tree = new TurboBinarySearchTree<int>(comparer);

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        var expectedOrder = new List<int> { 2, 3, 4, 5, 8 };
        var actualOrder = new List<int>(tree);

        Assert.AreEqual(expectedOrder, actualOrder);
    }
}

