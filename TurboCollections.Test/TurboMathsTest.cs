

namespace TurboCollections.Test;

public static class TurboMathsTests
{
    [Test]
    public static void SayHelloExists()
    {
        TurboMaths.SayHello();
        Assert.Pass();
    }

    //P1_3

    [Test]
    public static void TestGetEvenNumbers()
    {
        CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8, 10, 12 }, TurboMaths.GetEvenNumbers(12));
        CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8, 10, 12, 14 }, TurboMaths.GetEvenNumbers(15));
        CollectionAssert.AreNotEqual(new[] { 0 }, TurboMaths.GetEvenNumbers(-1));
        CollectionAssert.AreEqual(new[] { 0 }, TurboMaths.GetEvenNumbers(0));
    }


    [Test]
    public static void TestGetEvenNumbersList()
    {
        CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8, 10, 12 }, TurboMaths.GetEvenNumbers(12));
        CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8, 10, 12, 14 }, TurboMaths.GetEvenNumbers(15));
        CollectionAssert.AreNotEqual(new[] { 0 }, TurboMaths.GetEvenNumbers(-1));
        CollectionAssert.AreEqual(new[] { 0 }, TurboMaths.GetEvenNumbers(0));
    }
}