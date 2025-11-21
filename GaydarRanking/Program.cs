using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Collections.Generic;

List<user> users = new List<user>();

int i = 0;
while (i < 1)
{
    Console.WriteLine("Do you wish to add a new user? y/n");
    if (Console.ReadLine() == "n")
    {
        break;
    }
    else
    {
        users.Add(retrieval());
    }

}

foreach (user u in users)
{
    Console.WriteLine("User birthday: " + u.birthday);
    Console.WriteLine("User Name: " + u.userName);
}

Console.ReadLine();

user retrieval()
{
    user New = new user();
    Console.WriteLine("Enter user Name");
    New.userName = Console.ReadLine();
    Console.WriteLine("Enter user birthday (day/month/year)");
    New.birthday = Console.ReadLine();
    return New;
}

class user
{
    public string birthday;
    public string userName;
}