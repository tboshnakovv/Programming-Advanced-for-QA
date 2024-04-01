﻿Dictionary<string, int> resources = new();

string resource = Console.ReadLine();

while (resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
    {
        resources.Add(resource, quantity);
    }
    else
    {
        resources[resource] += quantity;
    }


    resource = Console.ReadLine();
}

foreach (KeyValuePair<string, int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}