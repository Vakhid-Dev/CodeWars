namespace CodeWars.Lib._5kuy;

public class FirstNonRepeatingLetterClass
{
    public static string FirstNonRepeatingLetter(string s)
    {
        if (s.Length == 1) return s[0].ToString();
        string result = "";
        var sLowers =  s.ToLower();
        for (int i = 0; i < sLowers.Length; i++)
        {
            if (sLowers.Count(x => x == sLowers[i]) == 1)
            {
                result = s[i].ToString();
                break;
            }
        }
        return result;
    }
    
    public static string FirstNonRepeatingLetterBest(string s)
    {
        return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .DefaultIfEmpty("")
            .First();
    }
}