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
      string word = Word.Ones(numStr);
      Assert.AreEqual("One", word);
    }

    [TestMethod]
    public void Ones_ReturnOnes_Nine()
    {
      string numStr = "9";
      string word = Word.Ones(numStr);
      Assert.AreEqual("Nine", word);
    }

    [TestMethod]
    public void Tens_ReturnTens_Eleven()
    {
      string numStr = "11";
      string word = Word.Tens(numStr);
      Assert.AreEqual("Eleven", word);
    }

    [TestMethod]
    public void Tens_ReturnTens_One()
    {
      string numStr = "01";
      string word = Word.Tens(numStr);
      Assert.AreEqual("One", word);
    }

    [TestMethod]
    public void Tens_ReturnTens_NinetyNine()
    {
      string numStr = "99";
      string word = Word.Tens(numStr);
      Assert.AreEqual("Ninety Nine", word);
    }

    [TestMethod]
    public void WholeNumToWord_ReturnWholeNumberWords_Five()
    {
      string numStr = "5";
      string word = Word.WholeNumToWord(numStr);
      Assert.AreEqual("Five", word);
    }

    [TestMethod]
    public void WholeNumToWord_ReturnWholeNumberWords_EightEight()
    {
      string numStr = "88";
      string word = Word.WholeNumToWord(numStr);
      Assert.AreEqual("Eighty Eight", word);
    }

    [TestMethod]
    public void WholeNumToWord_ReturnWholeNumberWords_OneHundredThirtyFive()
    {
      string numStr = "135";
      string word = Word.WholeNumToWord(numStr);
      Assert.AreEqual("One Hundred Thirty Five", word);
    }

    [TestMethod]
    public void WholeNumToWord_ReturnWholeNumberWords_OneHundred()
    {
      string numStr = "100";
      string word = Word.WholeNumToWord(numStr);
      Assert.AreEqual("One Hundred", word);
    }

    [TestMethod]
    public void WholeNumToWord_ReturnWholeNumberWords_OneThousand()
    {
      string numStr = "1000";
      string word = Word.WholeNumToWord(numStr);
      Assert.AreEqual("One Thousand", word);
    }

    [TestMethod]
    public void WholeNumToWord_ReturnWholeNumberWords_TwoHundredThirtyFourThousandFiveHundred()
    {
      string numStr = "204511";
      string word = Word.WholeNumToWord(numStr);
      Assert.AreEqual("Two Hundred Four Thousand Five Hundred Eleven", word);
    }
  }
}