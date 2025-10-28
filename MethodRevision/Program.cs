void SayHello()
{
    Console.WriteLine("Hello, World!");
}

string GetName()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    return name;
}

void SayHelloWithName(string pName)
{
    Console.WriteLine($"Hello, {pName}");
}

void CopyName()
{
    string name = GetName();
    SayHelloWithName(name);
}

CopyName();

void MessageRepeater(string Message = "Peebody", int Repetitions = 2)
{
    for (int i = 1; i <= Repetitions; i++)
    {
        Console.WriteLine($"{i}. {Message}");
    }
}

MessageRepeater("Hello, World!", 5);
MessageRepeater("Goodbye!", 3);
MessageRepeater();
MessageRepeater(GetName(), 4);

MessageRepeater(Repetitions: 5, Message: "Hello");
MessageRepeater(Message: "Goodbye", Repetitions: 3);