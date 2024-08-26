/*
Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.

For example:

a = 1
b = 4
--> [1, 2, 3, 4]
*/

// My solution

public class Kata {
  public static int[] Between(int a, int b) {
    int[] betweenInputs = new int[b - a + 1];
    for (int i = 0; i < betweenInputs.Length; i++)
    {
      betweenInputs[i] = a + i;
    }
    return betweenInputs;
  }
}