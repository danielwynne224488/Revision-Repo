// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int NumberSelect = int.Parse(Console.ReadLine());

switch (NumberSelect)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
        Console.WriteLine("4");
        break;
    case 5:
        Console.WriteLine("5");
        break;
    default:
        Console.WriteLine("Number not in range");
        break;
}