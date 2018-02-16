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
      RepeatCounterGenerator newRepeatCounterGenerator = new RepeatCounterGenerator("B");
      string testString = "B";
      //act
      string testInput = newRepeatCounterGenerator.GetInputString();
      //assert
      Assert.AreEqual(testString, testInput);
    }
  }
}
