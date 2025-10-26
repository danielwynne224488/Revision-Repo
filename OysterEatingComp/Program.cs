using System.IO;

Console.WriteLine("Oyster Eating Competition");

string filename = "../../../results.txt";
string[] Names;
int[] EatCount;
int competitorCount;

Console.WriteLine("Do you wish to enter new results? y/n");
if (Console.ReadLine().ToLower() == "y")
{

    Console.WriteLine("How many competitors are there?");
    competitorCount = int.Parse(Console.ReadLine());

    Names = new string[competitorCount];
    EatCount = new int[competitorCount];

    for (int i = 0; i < competitorCount; i++)
    {
        Console.WriteLine($"Enter the name of competitor #{i + 1}:");
        Names[i] = Console.ReadLine();
        Console.WriteLine($"How many oysters did {Names[i]} eat?");
        EatCount[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < Names.Length - 1; i++)
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

    using (StreamWriter writer = new StreamWriter(filename))
    {
        for (int i = 0; i < competitorCount; i++)
        {
            writer.WriteLine($"{Names[i]},{EatCount[i]}");
        }
    }

}
else
{
    Console.WriteLine("Displaying previous results...");
}


Console.ReadLine();