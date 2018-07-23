using System;
using System.Text;

namespace CodingBasics
{
  class Arrays
  {
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters. What if you can not use additional data structures?
    /// </summary>
    /// <param name="word"></param>
    public void questionOne(string word)
    {
      Console.WriteLine("Question One");
      word = Console.ReadLine();
      int duplicate = 0;

      for (int i = 0; i < word.Length; i++)
      {
        for (int j = i + 1; j < word.Length; j++)
        {
          if (word[i] == word[j])
          {
            duplicate++;
            break;
          }
        }
        if (duplicate > 0) { break; }
      }
      Console.WriteLine((duplicate == 0 ? "No " : "") + "Duplicates found");
    }

    /// <summary>
    /// Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)
    /// </summary>
    /// <param name="cstylestring"></param>
    public void questionTwo(char[] cstylestring)
    {
      char[] reverse = new char[cstylestring.Length];
      Console.WriteLine("Question Two");
      char temp;
      int start = 0;
      int end = 0;
      while (start < end)
      {
        temp = reverse[start];
        reverse[start] = reverse[end];
        reverse[end] = temp;
        start++;
        end--;
      }
      Console.WriteLine(reverse.ToString());

    }

    /// <summary>
    /// Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer.
    /// NOTE: One or two additional variables are fine. An extra copy of the array is not.
    /// FOLLOW UP
    /// Write the test cases for this method.
    /// </summary>
    /// <param name="word"></param>
    public void questionThree(string word)
    {
      Console.WriteLine("Question Three");
      word = Console.ReadLine();
      StringBuilder clean = new StringBuilder();
      foreach (char w in word.ToCharArray())
      {
        if (!clean.ToString().Contains(w.ToString()))
        {
          clean.Append(w);
        }
      }
      Console.WriteLine(clean);
    }

    /// <summary>
    /// Write a method to decide if two strings are anagrams or not.
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    public void questionFour(string word1, string word2)
    {
      Console.WriteLine("Question Four");
      word1 = Console.ReadLine().ToLower();
      word2 = Console.ReadLine().ToLower();

      if (word1.Length != word2.Length)
      {
        Console.WriteLine("These words are not anagrams");
      }
      else
      {
        char[] word1Arr = word1.ToCharArray();
        for (int i = 0; i < word1.Length; i++)
        {
          if (word2.IndexOf(word1Arr[i].ToString()) != -1)
          {
            word2 = word2.Remove(word2.IndexOf(word1Arr[i].ToString()), 1);
          }
          else
          {
            break;
          }
        }
        if (word2.Length == 0)
        {
          Console.WriteLine("These words are anagrams");
        }
        else
        {
          Console.WriteLine("These words are not anagrams");
        }
      }

    }

    /// <summary>
    /// Write a method to replace all spaces in a string with ‘%20’.
    /// </summary>
    /// <param name="word"></param>
    public void questionFive(string word)
    {
    }

    /// <summary>
    /// Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. 
    /// Can you do this in place?
    /// </summary>
    /// <param name="matrix"></param>
    public void questionSix(Tuple<int, int>[] matrix)
    {
    }

    /// <summary>
    /// Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0.
    /// </summary>
    /// <param name="matrix"></param>
    public void questionSeven(Tuple<int, int>[] matrix)
    {
    }

    /// <summary>
    /// Assume you have a method isSubstring which checks if one word is a substring of another. 
    /// Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring 
    /// (i.e., “waterbottle” is a rotation of “erbottlewat”).
    /// </summary>
    /// <param name="word1"></param>
    /// <param name="word2"></param>
    public void questionEight(string word1, string word2)
    {
    }
  }
}


