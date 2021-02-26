using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models.NumberWords;

namespace ModelTests.NumberWordTests
{
  [TestClass]
  public class NumberWordTests : IDisposable
  {

    public void Dispose()
    {
      NumberWord.ClearAll();
    }
    [TestMethod]
    public void NumberChecker_CreateInstanceOfNumberChecker_NumberChecker()
    {
      NumberChecker myNumber = new NumberChecker(8);
      Assert.AreEqual(typeof(NumberChecker), myNumber.GetType());
    }

    [TestMethod]
    public void NumberChecker_MatchEnteredValue_Int()
    {
      int _myNumber = 100;
      NumberChecker myNumber = new NumberChecker(_myNumber);
      int result = myNumber.numberToCheck;
      Assert.AreEqual(_myNumber, result);
    }

    [TestMethod]
    public void NumberToArray_BuildArray_Array()
    {
      int _myNumber = 100;
      int[] _myNumArray = {1, 0, 0};
      Console.WriteLine(_myNumArray);
      NumberChecker myNumber = new NumberChecker(_myNumber);
      char[] result = myNumber.numArray;
      CollectionAssert.AreEqual(_myNumArray, result);
    }
  }
}

//  public void GetDescription_ReturnsDescription_String()
//     {
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       string result = newItem.Description;
//       Assert.AreEqual(description, result);
//     }