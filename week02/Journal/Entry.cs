using System;

public class Entry 
{
public string DateCreated {get;}
public string Content {get;}

public Entry (string dateInput, string content)
{
DateCreated = dateInput;
Content = content;
}

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateCreated}");
        Console.WriteLine($"Content: {Content}\n");
    }

}