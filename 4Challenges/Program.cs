using System.ComponentModel.Design;

void NumericNurseryRhymes()
{
    int PickANurseryRhyme()
    {
        Console.WriteLine("Please select a nursery rhyme to display:");
        Console.WriteLine("1. Speckled Frogs");
        Console.WriteLine("2. Fat Sausages");
        int selection = int.Parse(Console.ReadLine());

        if (selection == 1 || selection == 2)
        {
            return selection;
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
            return PickANurseryRhyme();
        }
    }

    void DisplaySpeckledFrogs(int StartingNumberOfFrogs)
    {
        Console.WriteLine(StartingNumberOfFrogs + " speckled frogs sat on a log\nEating some most delicious bugs.\nOne jumped into the pool where it was nice and cool,\nThen there were " + (StartingNumberOfFrogs - 1) + " speckled frogs.\n");
    }

    void DisplayFatSausages(int StartingNumberOfSausages)
    {
        Console.WriteLine(StartingNumberOfSausages + " fat sausages sizzling in a pan.\nOne went pop and then there were " + (StartingNumberOfSausages - 1) + " fat sausages sizzling in a pan.\n");
    }

    int choice = PickANurseryRhyme();


    if (choice == 1)
    {
        Console.WriteLine("How many speckled frogs are there to start with?");
        int StartingNumberOfFrogs = int.Parse(Console.ReadLine());
        DisplaySpeckledFrogs(StartingNumberOfFrogs);
    }

    else if (choice == 2)
    {
        Console.WriteLine("How many fat sausages are there to start with?");
        int StartingNumberOfSausages = int.Parse(Console.ReadLine());
        DisplayFatSausages(StartingNumberOfSausages);
    }
}
 
void PrimeNumbersInRange()
{
    Console.WriteLine("Please enter a number to be the start of the range:");
    int startRange = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter a number to be the end of the range:");
    int endRange = int.Parse(Console.ReadLine());

    int PrimeNumbersInRange = 0;

    for (int i = startRange; i < endRange; i++)
    { bool isPrime;
        isPrime = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime && i > 1)
        {
            PrimeNumbersInRange++;
        }
    }

    Console.WriteLine("There are " + PrimeNumbersInRange + " prime numbers between " + startRange + " and " + endRange + ".");
}
 
void NumberOfVowelsInString()
{
    Console.WriteLine("Please enter a string:");
    string inputString = Console.ReadLine();
    int vowelCount = 0;
    foreach (char c in inputString.ToLower())
    {
        if ("aeiou".Contains(c))
        {
            vowelCount++;
        }
    }
}
 
void PigLatin()
{

}
 
void DisplayChallenges()
{
    int challengeSelection = 0;
    do
    {
        Console.WriteLine("1. Numeric Nursery Rhymes");
        Console.WriteLine("2. Number of Prime Numbers in Range");
        Console.WriteLine("3. Number of Vowels in a String");
        Console.WriteLine("4. Pig Latin");
        Console.WriteLine("5. Exit");
        challengeSelection = int.Parse(Console.ReadLine());
 
        if (challengeSelection == 1)
        {
            NumericNurseryRhymes();
        }
        else if (challengeSelection == 2)
        {
            PrimeNumbersInRange();
        }
        else if (challengeSelection == 3)
        {
            NumberOfVowelsInString();
        }
        else if (challengeSelection == 4)
        {
            PigLatin();
        }
        else if (challengeSelection == 5)
        {
            Console.WriteLine("Have a nice day. Goodbye!");
            break;
        }
 
    } while (true);
}
 
DisplayChallenges();