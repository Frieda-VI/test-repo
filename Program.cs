using System;

class Program 
{
    public static string[] randomMessages = {
        "Frieda is a programmer.",
        "CSharp can be quite confusing.",
        "Multi-dimensional arrays are useful!",
        "The Earth is not flat."
    };

    public static void Main(String[] Args)
    {
        Random randomInteger = new Random();
        int Integer = randomInteger.Next((int) randomMessages.Length);

        Console.WriteLine("Your message is: " + randomMessages[Integer]);
    }
}