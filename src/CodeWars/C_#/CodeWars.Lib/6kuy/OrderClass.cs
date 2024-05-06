using System.Text;

namespace CodeWars.Lib._6kuy;

public class OrderClass
{
    public static string Order(string words)
    {
        if (!words.Any()) return "";

        var splits = words.Split(" ");
        var builder = new StringBuilder();
        var nums = words.Where(Char.IsDigit).OrderBy(x => x).ToList();

        return builder.Append(string.Join(" ", nums.Select(n => string.Concat(splits.Where(x => x.Contains(n)))))).ToString();
    }
    
    public static string OrderBest(string words)
    {
        if (string.IsNullOrEmpty(words)) return words;
        return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(char.IsDigit)));
    }
}