using System;
using System.IO;

Console.WriteLine("People List Program");

Person Julia = new Person();
Julia.name = "blue";
Julia.age = 2;
Julia.gender = "Woman";
Console.WriteLine(Julia.name);
Console.WriteLine(Julia.age);
Console.WriteLine(Julia.gender);

Person Mark = new Person();
Mark.name = Console.ReadLine();
Mark.age = int.Parse(Console.ReadLine());
Mark.gender = Console.ReadLine();
Console.WriteLine(Mark.name);
Console.WriteLine(Mark.age);
Console.WriteLine(Mark.gender);


class Person
{
    public string name;
    public int age;
    public string gender;
}