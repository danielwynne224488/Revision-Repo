using System;
using System.IO;

Console.WriteLine("How many items do you need to buy?");

int numberOfItems = int.Parse(Console.ReadLine());

string[] shoppingList = new string[numberOfItems];

for (int j = 0; j < numberOfItems; j++)
{
    Console.WriteLine("What is item number " + (j + 1));
    shoppingList[j] = Console.ReadLine();
}

string filename;

Console.WriteLine("What file would you like to save your shopping list to?");

filename = "../../../" + Console.ReadLine();

using (StreamWriter writer = new StreamWriter(filename))
{
    writer.WriteLine("Shopping List " + DateTime.Now.Date);
    foreach (string item in shoppingList)
    {
        writer.WriteLine(item);
    }

}