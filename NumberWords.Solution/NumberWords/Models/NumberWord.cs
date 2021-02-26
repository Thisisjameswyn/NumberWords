//gather int number from user
//push number to array in a loop
//reverse array
//look at index location for decimal location


// Dictionary ones <int, string> {1, "one"}
// Dictionary tens <int, string> {1, "ten"}
// Dictionary hundreds <int, string> {1, "one hundred"}
// Dictionary thousands <int, string> {1, "one thousand"}
// ones[1]


using System;
using System.Collections.Generic;

namespace Models.NumberWords
{
  public class NumberChecker
  {
    public int numberToCheck;
    public char[] numArray = {};

    public NumberChecker(int _number)
    {
      numberToCheck = _number;

      numArray = NumberToArray(numberToCheck);
    }

    private char[] NumberToArray(int _number)
    {
      string number = _number.ToString();
      char[] _numArray = number.ToCharArray();
      Console.WriteLine(_numArray[0]);
      Console.WriteLine(_numArray[1]);
      Console.WriteLine(_numArray[2]);
      return _numArray;
    }

    public static void ClearAll()
    {
      numArray.Clear();
    }
  }
}