using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RepeatCounter.Models;


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
  }
}
