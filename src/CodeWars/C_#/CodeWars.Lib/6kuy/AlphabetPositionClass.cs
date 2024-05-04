using System.Text;

namespace CodeWars.Lib._6kuy;

public class AlphabetPositionClass
{
    public static string AlphabetPosition(string text)
    {
        var list = new List<char>()
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        var builder = new StringBuilder();
        var newText = text.ToLower();
        foreach (var t in newText)
        {
            if (list.Contains(t))
            {
                builder.Append(string.Concat( list.FindIndex(x => x == t) + 1," "));
            }
        }
        return builder.ToString().TrimEnd();
    }
    
    public static string AlphabetPositionBest(string text)
    {
          return string.Join(" ", text.ToLower()
            .Where(char.IsLetter)
            .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
            .ToArray());
    }
}