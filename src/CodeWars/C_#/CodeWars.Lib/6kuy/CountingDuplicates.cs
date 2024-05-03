namespace CodeWars.Lib._6kuy;

public class CountingDuplicates
{
    public static int DuplicateCount(string str)
    {
        if (str.Length == 0)  return 0;
        var list =  str.ToLower().ToHashSet().Select(s => str.ToLower().Count(x => x == s)).Where(count => count > 1).ToList();
        return !list.Any() ? 0 : list.Count();
    }
    public static int DuplicateCountBest(string str)
    {
        return str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
    }
}