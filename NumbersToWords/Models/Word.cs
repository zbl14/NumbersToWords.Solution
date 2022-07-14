namespace NumbersToWords.Models
{
  public class Word
  {
    public static int Num { get; set; }

    public static string Ones(string numStr)
    {
      Num = int.Parse(numStr);
      string name = "";
      switch (Num)
      {
        case 1:
          name = "One";
          break;
        case 2:
          name = "Two";
          break;
        case 3:
          name = "Three";
          break;
        case 4:
          name = "Four";
          break;
        case 5:
          name = "Five";
          break;
        case 6:
          name = "Six";
          break;
        case 7:
          name = "Seven";
          break;
        case 8:
          name = "Eight";
          break;
        case 9:
          name = "Nine";
          break;
      } 
      return name;
    }

    public static string Tens(string numStr)
    {
      Num = int.Parse(numStr);
      string name = null;
      switch (Num)
      {
        case 10:
          name = "Ten";
          break;
        case 11:
          name = "Eleven";
          break;
        case 12:
          name = "Tweleve";
          break;
        case 13:
          name = "Thirteen";
          break;
        case 14:
          name = "Forteen";
          break;
        case 15:
          name = "Fifthteen";
          break;
        case 16:
          name = "Sixteen";
          break;
        case 17:
          name = "Seventeen";
          break;
        case 18:
          name = "Eighteen";
          break;
        case 19:
          name = "Nineteen";
          break;
        case 20:
          name = "Twenty";
          break;
        case 30:
          name = "Thirty";
          break;
        case 40:
          name = "Forty";
          break;
        case 50:
          name = "Fifty";
          break;
        case 60:
          name = "Sixty";
          break;
        case 70:
          name = "Seventy";
          break;
        case 80:
          name = "Eighty";
          break;
        case 90:
          name = "Ninety";
          break;
        default:
          name = Tens(numStr.Substring(0, 1) + "0") + " " + Ones(numStr.Substring(1));
          break;          
      } 
      return name;
    }

    public static string WholeNumToWord(string numStr)
    {
      string word = "";
      double num = double.Parse(numStr);
      bool isDone = false;
      int numDigit = numStr.Length;
      int digitGroup = 0;
      string digitGroupName = "";
      switch (numDigit)
      {
        case 1:
          word = Ones(numStr);
          isDone = true;
          break;
        case 2:
          word = Tens(numStr);
          isDone = true;
          break;
        case 3:
          digitGroup = (numDigit % 3) + 1;
          digitGroupName = " Hundred ";
          break;    
      }
      if (!isDone)
      {
        if (numStr.Substring(0, digitGroup) != "0" && numStr.Substring(digitGroup) != "0")
        {
          word = WholeNumToWord(numStr.Substring(0, digitGroup)) + digitGroupName + WholeNumToWord(numStr.Substring(digitGroup));
        }
        else
        {
          word = WholeNumToWord(numStr.Substring(0, digitGroup)) + WholeNumToWord(numStr.Substring(digitGroup));
        }
      }
      return word;
    }
  }
}