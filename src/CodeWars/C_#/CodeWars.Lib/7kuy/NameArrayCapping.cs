namespace CodeWars.Lib;

public class NameArrayCapping
{
    public static string[] CapMe(string[] strings)
    {
        return strings.Select(x =>
                string.Concat(x[0].ToString().ToUpper(), x.Substring(1).ToLower()))
            .ToArray();;
    }
   /// <summary>
   /// Best practices
   /// </summary>
   /// <param name="strings"></param>
   /// <returns></returns>
    public static string[] CapMe2(string[] strings)
    {
        return strings.Select(s => char.ToUpper(s[0]) + s[1..].ToLower()).ToArray();
    }
}