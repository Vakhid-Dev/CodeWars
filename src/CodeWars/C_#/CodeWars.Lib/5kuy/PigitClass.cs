using System.Text;

namespace CodeWars.Lib._5kuy;

public class PigitClass
{
  public static string PigIt(string str)
  {
    return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
  }
}
