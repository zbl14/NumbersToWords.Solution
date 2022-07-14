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
      // Word testWord = new Word();
      string numStr = "1";
      string word = Word.ones(numStr);
      Assert.AreEqual("One", word);
    }
  }
}