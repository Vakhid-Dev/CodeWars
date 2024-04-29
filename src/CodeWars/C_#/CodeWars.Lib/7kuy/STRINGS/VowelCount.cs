namespace CodeWars.Lib._7kuy.STRINGS;

public class VowelCount
{
    /*
     * Return the number (count) of vowels in the given string.
      
      We will consider a, e, i, o, u as vowels for this Kata (but not y).
      
      The input string will only consist of lower case letters and/or spaces.
    */
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