namespace CodeWars.Lib;

public class JavascriptFilter1
{
    public static string[][] search_names(string[][] logins)
    {
        return logins.Where(login => login[0].Substring(login[0].Length - 1) == "_").ToArray();
    }
}