using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.Lib;

public class Filterthenumber
{
    public static int FilterString(string s)
    {
        StringBuilder builder = new StringBuilder();
        var regex = new Regex(@"\d");
        MatchCollection matches = regex.Matches(s);
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
                builder.Append(match.Value); 
        }
        
        return int.Parse(builder.ToString());
    }

        public static int FilterString2(string s)
        {
            return int.Parse(new string(s.Where(char.IsDigit).ToArray()));
        }
}