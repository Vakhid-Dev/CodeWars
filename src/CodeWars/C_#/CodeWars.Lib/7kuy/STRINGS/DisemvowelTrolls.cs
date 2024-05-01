using System.Text.RegularExpressions;

namespace CodeWars.Lib._7kuy.STRINGS;

public class DisemvowelTrolls
{
    public static string Disemvowel(string str)
    {
        var set = "aeiouAEIOU".ToHashSet();
        return string.Concat(str.Where(x => !set.Contains(x)));
    }
    
    public static string DisemvowelBest(string str)
    {
        return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
    }
}