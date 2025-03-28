using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_string
{
    class Program
    {
        // 2. Check Palindrome
        static void CheckPalindrome(string str)
        {
            string normalizedStr = str.Replace(" ", "").ToLower();
            string reversedStr = new string(normalizedStr.Reverse().ToArray());
            if (normalizedStr == reversedStr)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }

        // 3. Count Vowels and Consonants
        static void CountVowelsAndConsonants(string str)
        {
            int vowels = 0, consonants = 0;
            foreach (char c in str.ToLower())
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
            }
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }

        // 4. Remove Duplicates
        static void RemoveDuplicates(string str)
        {
            string result = new string(str.Distinct().ToArray());
            Console.WriteLine(result);
        }

        // 5. Find the First Non-Repeating Character
        static void FirstNonRepeatingCharacter(string str)
        {
            foreach (char c in str)
            {
                if (str.Count(x => x == c) == 1)
                {
                    Console.WriteLine(c);
                    return;
                }
            }
            Console.WriteLine("No non-repeating character found");
        }

        // 6. Check Anagram
        static void CheckAnagram(string str1, string str2)
        {
            var sortedStr1 = new string(str1.ToLower().OrderBy(c => c).ToArray());
            var sortedStr2 = new string(str2.ToLower().OrderBy(c => c).ToArray());
            if (sortedStr1 == sortedStr2)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not an Anagram");
        }

        // 7. Word Count
        static void WordCount(string str)
        {
            int wordCount = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Word Count: {wordCount}");
        }

        // 8. Replace a Word in a Sentence
        static void ReplaceWord(string sentence, string oldWord, string newWord)
        {
            string result = sentence.Replace(oldWord, newWord);
            Console.WriteLine(result);
        }

        // 9. Capitalize First Letter of Each Word
        static void CapitalizeFirstLetterOfEachWord(string str)
        {
            var words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }

        // 10. Find the Most Frequent Character
        static void FindMostFrequentCharacter(string str)
        {
            var mostFrequentChar = str.GroupBy(c => c)
                                      .OrderByDescending(group => group.Count())
                                      .First().Key;
            Console.WriteLine($"Most Frequent Character: {mostFrequentChar}");
        }

        static void Main()
        {
            // Test cases for each task
            Console.WriteLine("2. Check Palindrome:");
            CheckPalindrome("madam"); // Palindrome
            CheckPalindrome("hello"); // Not a Palindrome

            Console.WriteLine("\n3. Count Vowels and Consonants:");
            CountVowelsAndConsonants("apple");

            Console.WriteLine("\n4. Remove Duplicates:");
            RemoveDuplicates("programming");

            Console.WriteLine("\n5. Find the First Non-Repeating Character:");
            FirstNonRepeatingCharacter("swiss");

            Console.WriteLine("\n6. Check Anagram:");
            CheckAnagram("listen", "silent"); // Anagram
            CheckAnagram("hello", "world"); // Not an Anagram

            Console.WriteLine("\n7. Word Count:");
            WordCount("C# is awesome");

            Console.WriteLine("\n8. Replace a Word in a Sentence:");
            ReplaceWord("I love C#", "C#", "Java");

            Console.WriteLine("\n9. Capitalize First Letter of Each Word:");
            CapitalizeFirstLetterOfEachWord("hello world");

            Console.WriteLine("\n10. Find the Most Frequent Character:");
            FindMostFrequentCharacter("success");
        }
    }
}
