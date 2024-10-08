/*
Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
*/

// My solution

using System;
using System.Linq;

public class Kata
{  
  public static int DuplicateCount(string str)
  {
    return str.ToLower().GroupBy(n => n).Count(n => n.Count() >= 2);
  }
}