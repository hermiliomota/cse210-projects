using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public int WordCount { get; set; } // Exceeding requirement

    public Entry() { }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
        WordCount = response.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public string ToFileString()
    {
        return $"{Date}~|~{Prompt}~|~{Response}~|~{WordCount}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        return new Entry
        {
            Date = parts[0],
            Prompt = parts[1],
            Response = parts[2],
            WordCount = int.Parse(parts[3])
        };
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Word Count: {WordCount}");
        Console.WriteLine();
    }
}
