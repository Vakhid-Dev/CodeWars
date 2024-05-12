namespace CodeWars.Lib._6kuy;

public class IsPangramClass
{
    public static bool IsPangram(string str)
    {
        var aList = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        var sList = str.Where(char.IsLetter).Select(char.ToLower).ToList();
        return  aList.All(x => sList.Contains(x));
    }
    public static bool IsPangramBest(string str)
    {
        return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
    }
}