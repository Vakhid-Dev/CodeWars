namespace CodeWars.Lib._6kuy;

public class CountingDuplicates
{
    public static int DuplicateCount(string str)
    {
        var chars = str.Select(x => char.ToString(x).ToLower());
        var set = new HashSet<string>();
        var enumerable = chars as string[] ?? chars.ToArray();
        foreach (var c in enumerable)
        {
            if (enumerable.Count(x => x == c) > 1)
            {
                set.Add(c);
            } 
        }
        return set.Count;
    }
    
    public static int DuplicateCoun2t(string str)
    {
        return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
    }
}