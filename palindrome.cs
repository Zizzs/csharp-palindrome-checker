using System;
using System.Collections.Generic;
using System.Linq;

public class Palindrome
{

    public static void PalindromeChecker(string userInput)
    {
        char[] cArray = userInput.ToCharArray();
        string arrayReverse = String.Empty;
        for(int i = cArray.Length - 1; i > -1; i--)
        {
            arrayReverse += cArray[i];
        }
        string outputString = arrayReverse.ToString();
        
        if(userInput == outputString)
        {
            Console.WriteLine("That is a palindrome.");
        }
        else
        {
            Console.WriteLine("That is not a palindrome.");
        }
    }
    public static void Main()
    {
        Console.WriteLine("Enter a String or Integer to check to see if it is a palindrome or not.");
        string userInputMain = Console.ReadLine();
        PalindromeChecker(userInputMain);
    }
}