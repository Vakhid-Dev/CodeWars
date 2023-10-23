using System.Text;

namespace CodeWars.Lib._6kuy;

public class DuplicateEncoder
{
    public static string DuplicateEncode(string word)
    {
        var builder = new StringBuilder();
        var strs = word.Select(x=>x.ToString().ToUpperInvariant()).ToList();
        foreach (var x in strs)
        {
            builder.Append(strs.Count(c => c == x)>1? ")" : "(");
        }
        
        return builder.ToString();
    }
    public static string DuplicateEncode2(string word)
    {
        word = word.ToLower();
        return string.Concat(word.Select(x => word.Count(w => w == x) > 1 ? ')' : '('));
    }
}