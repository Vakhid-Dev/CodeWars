using System.Text.RegularExpressions;

namespace CodeWars.Lib._7kuy.STRINGS;

public class DisemvowelTrolls
{
    /*
     * Trolls are attacking your comment section!
       
       A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
       
       Your task is to write a function that takes a string and return a new string with all vowels removed.
       
       For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
       
       Note: for this kata y isn't considered a vowel.
     */
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