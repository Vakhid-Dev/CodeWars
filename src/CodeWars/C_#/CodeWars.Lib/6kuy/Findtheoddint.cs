namespace CodeWars.Lib._6kuy;

public class Findtheoddint
{
    public static int find_it(int[] seq)
    {
        if (seq.Length == 1)
            return seq[0];
        
        return seq.GroupBy(s => s).
            Select(y => new { Value = y.Key, Count = y.Count()}).
            Where(x => x.Count % 2 == 1).
            Select(x => x.Value).First();
    }
    public static int find_itBest(int[] seq) 
    {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
    }
  
}