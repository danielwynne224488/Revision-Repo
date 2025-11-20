using System.IO;
using System;

string file = SelectFile();
Console.WriteLine(Path.GetFileName(file));
Console.WriteLine(file);
ResultsCalculation(file);
Console.ReadLine();

string SelectFile()
{
    Console.WriteLine("Please select a file to load from the list below:");
    string[] files = Directory.GetFiles("C:\\Users\\mtwki\\source\\repos\\Revision-Repo\\Programming Portfolio Calculator Results\\StudentMarks");
    int selection = -1;
    do
    {
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
        }
        Console.WriteLine("Please select a file.");
        selection = int.Parse(Console.ReadLine());
    } while (selection < 1 || selection > files.Length);
    return (files[selection - 1]);
}

string ResultsCalculation(string file)
{
    string[] lines = File.ReadAllLines(file);

    foreach (string line in lines)
    {
        // Parse student data
        int studentID = ExtractID(line);
        string lastName = ExtractLastName(line);
        string firstName = ExtractFirstName(line);

        // Parse marks
        int[] challenges = ExtractChallenges(line);
        int exam = ExtractExam(line);
        int capstone = ExtractCapstone(line);

        // Calculate total
        int challengeTotal = 0;
        foreach (int mark in challenges)
        {
            challengeTotal += mark;
        }
        int totalMarks = challengeTotal + exam + capstone;

        // Check if passed (adjust criteria as needed)
        bool passed = totalMarks >= 40; // Example: 40% pass mark

        Console.WriteLine($"{firstName} {lastName} (ID: {studentID})");
        Console.WriteLine($"Challenges: {challengeTotal}, Exam: {exam}, Capstone: {capstone}");
        Console.WriteLine($"Total: {totalMarks} - {(passed ? "PASSED" : "FAILED")}");
        Console.WriteLine();
    }

    return "Results calculation complete";
}

int ExtractID(string line)
{
    int start = line.IndexOf("ID:") + 3;
    int end = line.IndexOf(",", start);
    return int.Parse(line.Substring(start, end - start));
}

string ExtractLastName(string line)
{
    int start = line.IndexOf("LastName:") + 9;
    int end = line.IndexOf(",", start);
    return line.Substring(start, end - start);
}

string ExtractFirstName(string line)
{
    int start = line.IndexOf("FirstName:") + 10;
    int end = line.IndexOf("]", start);
    return line.Substring(start, end - start);
}

int[] ExtractChallenges(string line)
{
    int start = line.IndexOf("Challenges:[") + 12;
    int end = line.IndexOf("]", start);
    string[] parts = line.Substring(start, end - start).Split(',');
    int[] challenges = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
        challenges[i] = int.Parse(parts[i]);
    }
    return challenges;
}

int ExtractExam(string line)
{
    int start = line.IndexOf("Exam:") + 5;
    int end = line.IndexOf(",", start);
    return int.Parse(line.Substring(start, end - start));
}

int ExtractCapstone(string line)
{
    int start = line.IndexOf("Capstone:") + 9;
    int end = line.IndexOf("]", start);
    return int.Parse(line.Substring(start, end - start));
}