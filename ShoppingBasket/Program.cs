Console.WriteLine("Welcome to the shopping basket.");
Console.WriteLine("The shopping basket can hold 5 items or less");

string[] basketContents = { "Milk", "Bread", "Eggs", "Coffee", "Bacon" };

bool checkout = false;
do
{
    for (int i = 0; i < basketContents.Length; i++)
    {
        Console.WriteLine((i + 1) + ". " + basketContents[i]);
    }

    // Add your code here!

    Console.WriteLine("Do you wish to replace an item in your basket? Put y for yes.");
    if (Console.ReadLine() == "y")
    {
        Console.WriteLine("Which item number do you want to replace?");
        int itemNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the new item?");
        basketContents[itemNumber - 1] = Console.ReadLine();
    }

    Console.WriteLine("Are you ready to check out? Answer y for yes");
    string input = Console.ReadLine();
    checkout = (input == "y");

} while (!checkout);

Console.Write("Your basket contains ");

foreach (string item in basketContents)
{
    Console.Write(item + " ");
}