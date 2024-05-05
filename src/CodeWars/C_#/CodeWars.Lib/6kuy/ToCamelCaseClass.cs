using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.Lib._6kuy;

public class ToCamelCaseClass
{
    public static string ToCamelCase(string str)
    {
        var builder = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '_' || str[i] == '-')
                builder.Append(str[++i].ToString().ToUpper());
            else
                builder.Append(str[i]);
        }

        return string.Concat(builder.ToString().Where(Char.IsLetter));
    }
    public static string ToCamelCaseBest(string str)
    {
        return string.Concat(str.Split('-','_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
    }
}