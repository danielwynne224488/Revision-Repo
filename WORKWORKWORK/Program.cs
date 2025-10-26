Console.WriteLine("Programming Portfolio Score Calculator");
Console.Write("What was the digital portfolio mark (out of 30)");
int portfolioMark = int.Parse(Console.ReadLine());

if (portfolioMark < 0 || portfolioMark > 30)
{
    while (portfolioMark < 0 || portfolioMark > 30)
    {
        Console.Write("Invalid mark. Please enter a mark between 0 and 30: ");
        portfolioMark = int.Parse(Console.ReadLine());
    }

}

float portfolioPercentage = (portfolioMark / 30.0f) * 100;
Console.Write("What was the Capstone Project mark (out of 100)");
int capstoneMark = int.Parse(Console.ReadLine());

if (capstoneMark < 0 || capstoneMark > 100)
{
    while (capstoneMark < 0 || capstoneMark > 100)
    {
        Console.Write("Invalid mark. Please enter a mark between 0 and 100: ");
        capstoneMark = int.Parse(Console.ReadLine());
    }
}

float capstonePercentage = (capstoneMark / 100.0f) * 100;
Console.Write("What was the Open Book Programming Exam mark (out of 20)");
int examMark = int.Parse(Console.ReadLine());

if (examMark < 0 || examMark > 20)
{
    while (examMark < 0 || examMark > 20)
    {
        Console.Write("Invalid mark. Please enter a mark between 0 and 20: ");
        examMark = int.Parse(Console.ReadLine());
    }
}

float examPercentage = (examMark / 20.0f) * 100;

float finalScore = (portfolioPercentage * 0.5f) + (capstonePercentage * 0.25f) + (examPercentage * 0.25f);

if (capstonePercentage < 40 && finalScore > 34)
{
    finalScore = 34;
}

