using System.Text;

namespace CodeWars.Lib._6kuy;

public class DuplicateEncoder
{
    public static string DuplicateEncode(string word)
    {
        var tempWords = word.ToLowerInvariant().ToList();
        return string.Concat(tempWords.Select(x => tempWords.Count(y=>y==x) > 1 ? ")" : "("));
    }
}