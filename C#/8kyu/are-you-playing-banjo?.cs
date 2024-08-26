/*
Create a function which answers the question "Are you playing banjo?".
If your name starts with the letter "R" or lower case "r", you are playing banjo!

The function takes a name as its only argument, and returns one of the following strings:

name + " plays banjo" 
name + " does not play banjo"

Names given are always valid strings.
*/

//My solution

using System;

public class Kata
{ 
    public static string AreYouPlayingBanjo(string name)
    {
        if (name.StartsWith('R') || name.StartsWith('r')) //searching if the name start with R or r  
        {
            return $"{name} plays banjo"; //if start with r or R, you play banjo! 
        }
        else
        {
            return $"{name} does not play banjo"; //if don't, you doesnt play banjo
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Your name is: "); //asking for the name
        string name = Console.ReadLine(); //save the name in the string
        
        Console.WriteLine(Kata.AreYouPlayingBanjo(name));
    }
}