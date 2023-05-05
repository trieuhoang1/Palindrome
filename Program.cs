using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The word is a palindrome.");
        }
        else
        {
            Console.WriteLine("Sorry, the word is not a palindrome :( ");
        }

        Console.ReadKey();
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}