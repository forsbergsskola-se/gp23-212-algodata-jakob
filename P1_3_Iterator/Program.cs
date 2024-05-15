using TurboCollections;

//Create a List (C#) or vector (C++) with 5 numbers: 1, 1, 2, 3, 5.
//C#: Assign it to a Variable of Type IEnumerable.
//Use GetEnumerator() (C#) a while-Loop to print all elements of the List-Variable 
List<int> numberList = new() { 1, 1, 2, 3, 5 };

IEnumerable<int> numbers = numberList;

IEnumerator<int> iterator = numbers.GetEnumerator();

while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}

int sum = 0;

foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($" the sum is : {sum}");

Console.WriteLine("Even Numbers List: ");
foreach (int number in TurboMaths.GetEvenNumbers(12))
{
    Console.WriteLine($"{number}");
}

Console.WriteLine("Even Number");



