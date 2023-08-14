using System.Text;

namespace CodeWars.Lib;

public class SorttheGiftCode
{
    public static string SortGiftCode(string code)
    {
        var s = code.ToList();
        s.Sort();
        return string.Concat(s);
    }
    public static string SortGiftCode2(string code)
    {
        return string.Join("", code.OrderBy(v => v));
    }
}