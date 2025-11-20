void Greet(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}

Greet("Alice");
Greet("Bob");
Greet("Charlie");

int AddNumbers(int num1, int num2)
{
    Console.WriteLine($"Adding {num1} and {num2}");
    return num1 + num2;
}

int result1 = AddNumbers(5, 3);
int result2 = AddNumbers(10, 20);
Console.WriteLine(result1);  // Should print 8
Console.WriteLine(result2);  // Should print 30

void GetHighestScore(int[] scores)
{
    int highest = scores[0];
    foreach (int score in scores)
    {
        if (score > highest)
        {
            highest = score;
        }
    }
    Console.WriteLine("The highest score is: " + highest);
}

GetHighestScore(new int[] { 45, 78, 22, 89, 67 });

Console.ReadLine();