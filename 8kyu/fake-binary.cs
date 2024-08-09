/*
Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

Note: input will never be an empty string
*/

// My solution

public class Kata
{
  public static string FakeBin(string x)
  {
    int n = 0;
      
      if (n>5){
        return "0";
      } 
      
      if (n<5){
        return "1";
      }
  }
}