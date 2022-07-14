namespace NumbersToWords.Models
{
  public class Word
  {
    public static int Num { get; set; }

    public static string ones(string numStr)
    {
      Num = int.Parse(numStr);
      string name = "";
      switch (Num)
      {
        case 1:
          name = "One";
          break;
      } 
      return name;
    }
  }
}