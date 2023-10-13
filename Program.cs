using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Word2
{
    internal class PalindromeChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            if (IsWordPalindrome(input))
            {
                Console.WriteLine($"The word '{input}' is a fascinating palindrome!");
            }
            else
            {
                Console.WriteLine($"The word '{input}' is not a palindrome.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static bool IsWordPalindrome(string word)
        {
            word = word.ToLower(); // Make it case-insensitive
            for (int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}