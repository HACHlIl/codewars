/*
Your coworker was supposed to write a simple helper function to capitalize a string (that contains a single word) before they went on vacation.

Unfortunately, they have now left and the code they gave you doesn't work. Fix the helper function they wrote so that it works as intended (i.e. it must make the first character in the string upper case).

The string will always start with a letter and will never be empty.
*/

// My solution

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string CapitalizeWord(string word)
  {
    return char.ToUpper(word[0]) + word.Substring(1);
  }
}