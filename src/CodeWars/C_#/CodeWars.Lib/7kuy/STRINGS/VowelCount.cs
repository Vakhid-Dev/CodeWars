namespace CodeWars.Lib._7kuy.STRINGS;

public class VowelCount
{
    public static int GetVowelCount(string str)
    {
        var vowels = "aeiou";
        var vowelSet = vowels.ToHashSet();
        return str.Trim().Count(s => vowelSet.Contains(s));
    }
    
    public static int GetVowelCountBest(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}