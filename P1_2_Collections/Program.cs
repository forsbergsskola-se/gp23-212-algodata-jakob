using System.Collections;

List<int> numbers = new();
numbers.Add(137);
numbers.Add(1000);
numbers.Add(-200);

for (var i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

ArrayList arrayList = new();
arrayList.Add(true);
arrayList.Add("Forsbergs");
arrayList.Add('a');
arrayList.Add(1000);
arrayList.Add(.12f);

for (var i = 0; i < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}