

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

//



