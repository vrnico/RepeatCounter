using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RepeatCounter.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RepeatCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetInputString_GetsString_ReturnsString()
    {
      //arrange
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator("B", "C", "b");
      string testString = "B";
      //act
      string testInput = newRepeatCounterGenerator.GetInputString();
      //assert
      Assert.AreEqual(testString, testInput);
    }
    [TestMethod]
    public void GetFindString_GetsString_ReturnsString()
    {
      //arrange
      RepeatCounterGenerator newRepeatCounterGenerator =
      new RepeatCounterGenerator("dog", "buffalo", "dog");
      string testString = "buffalo";
      //act
      string testInput = newRepeatCounterGenerator.GetFindString();

      //assert
      Assert.AreEqual(testString, testInput);
    }

    [TestMethod]
    public void BreakString_ReturnNewList()
    {
      string testString = "buffalo";
      string inputString = "buffalo buffalo";
      List<string> test = new List<string> {"buffalo", "buffalo"};
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator(inputString, testString, "buffalo buffalo");
      newRepeatCounterGenerator.BreakString();
      List<string> newList = new List<string> {};
      newList = newRepeatCounterGenerator.GetCompareList();
      CollectionAssert.AreEqual(newList, test);
    }
    [TestMethod]
    public void RepeatCount_GetsCount_ReturnsCount()
    {
      //arrange
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator("Buffalo buffalo buffalo buffalo", "buffalo", "buffalo buffalo buffalo buffalo");
      int testInt = 4;
      //act
      int testInput = newRepeatCounterGenerator.RepeatCount();
      //assert
      Assert.AreEqual(testInt, testInput);
    }
    [TestMethod]
    public void LowerCase_FetchesInputString_LowersCase()
    {
      //arrange
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator("tEsT", "test", "test");
      string testString = "test";
      //act
      string lowerTest = newRepeatCounterGenerator.LowerCase();
      //assert
      Assert.AreEqual(testString, lowerTest);
    }

  }
}
