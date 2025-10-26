Console.WriteLine("Oyster Eating Competition");
Console.WriteLine("How many competitors are there?");
int competitorCount = int.Parse(Console.ReadLine());

string[] Names = new string[competitorCount];
int[] EatCount = new int[competitorCount];

for (int i = 0; i < competitorCount; i++)
{
    Console.WriteLine($"Enter the name of competitor #{i + 1}:");
    Names[i] = Console.ReadLine();
    Console.WriteLine($"How many oysters did {Names[i]} eat?");
    EatCount[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < Names.Length-1; i++)
{
    for (int j = i + 1; j < Names.Length; j++)
    {
        if (EatCount[i] < EatCount[j])
        {
            // Swap EatCount
            int tempEat = EatCount[i];
            EatCount[i] = EatCount[j];
            EatCount[j] = tempEat;
            // Swap Names
            string tempName = Names[i];
            Names[i] = Names[j];
            Names[j] = tempName;
        }
    }
}



for (int i = 0; i < competitorCount; i++)
{
    Console.WriteLine($"{Names[i]} ate {EatCount[i]} oysters.");
}

Console.ReadLine();