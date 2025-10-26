Console.WriteLine("Oyster Eating Competition");
Console.WriteLine("How many competitors are there?");
int competitorCount = int.Parse(Console.ReadLine());

Names = new string[competitorCount];
EatCount = new int[competitorCount];

for (int i = 0; i < competitorCount; i++)
{
    Console.WriteLine($"Enter the name of competitor #{i + 1}:");
    Names[i] = Console.ReadLine();
}

for (int i = 0; i < competitorCount; i++)
{
    Console.WriteLine($"How many oysters did {Names[i]} eat?");
    EatCount[i] = int.Parse(Console.ReadLine());
}

