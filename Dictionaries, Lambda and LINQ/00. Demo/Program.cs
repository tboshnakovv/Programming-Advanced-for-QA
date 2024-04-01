List<int> testList = new() { 1, 2, 3, 4, 5, 6 };
List<string> testListStrings = new() { "hello", "world", "Maybe?" };

Console.WriteLine(testList.Min());
Console.WriteLine(testListStrings.Min());

Console.WriteLine(testList.Max());
Console.WriteLine(testList.Sum());
Console.WriteLine(testList.Average());