using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class WordTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void Ones_ReturnOnes_One()
    {
      string numStr = "1";
      string word = Word.ones(numStr);
      Assert.AreEqual("One", word);
    }

    [TestMethod]
    public void Ones_ReturnOnes_Nine()
    {
      string numStr = "9";
      string word = Word.ones(numStr);
      Assert.AreEqual("Nine", word);
    }

    [TestMethod]
    public void Tens_ReturnTens_Eleven()
    {
      string numStr = "11";
      string word = Word.tens(numStr);
      Assert.AreEqual("Eleven", word);
    }

    [TestMethod]
    public void Tens_ReturnTens_NinetyNine()
    {
      string numStr = "99";
      string word = Word.tens(numStr);
      Assert.AreEqual("Ninety Nine", word);
    }
  }
}