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
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator("B", "C");
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
      new RepeatCounterGenerator("dog", "buffalo");
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
      List<string> test = new List<string> {"bufalo", "buffalo"};
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator(inputString, testString);
      newRepeatCounterGenerator.BreakString();
      List<string> newList = new List<string> {};
      newList = newRepeatCounterGenerator.GetCompareList();
      CollectionAssert.AreEqual(newList, test);
    }
  }
}
