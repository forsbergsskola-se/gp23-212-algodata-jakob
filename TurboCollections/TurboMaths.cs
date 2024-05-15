namespace TurboCollections;

public static class TurboMaths
{
    public static void SayHello()
    {
        Console.WriteLine($"Hello, I'm {typeof(TurboMaths).FullName}");
    }

    public static IEnumerable<int> GetEvenNumbers(int maxNubmer)
    {
        for (int i = 0; i <= maxNubmer; i+= 2)
        {
            yield return i;
        }
    }

    public static List<int> GetEvenNumbersList(int maxNumber)
    {
        List<int> evenList = new List<int>();
        for (int i = 0; i < maxNumber; i+= 2)
        {
            evenList.Add(i);
        }

        return evenList;
    }
}