/*
Make a program that filters a list of strings and returns a list with only your friends name in it.

If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

i.e.

friend {"Ryan", "Kieran", "Mark"} `shouldBe` {"Ryan", "Mark"}

If there are no friends return {""}.

Note: keep the original order of the names in the output.

*/

//My solution

using System;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) 
    {
    List<string> friends = new List<string>(); //list to save all the names with 4 letters in a friends list 

        foreach (string name in names) //loop in every name in the list
        {
            if (name.Length == 4) //verify if the name has 4 letters
            {   
                friends.Add(name); //if yes, the name is add in the friends list 
            }
        }
    return friends; //return the friends list 

    }
}