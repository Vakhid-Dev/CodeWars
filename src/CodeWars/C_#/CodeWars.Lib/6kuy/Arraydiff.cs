namespace CodeWars.Lib._6kuy.Arrays;

public class Arraydiff
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        return a.Where(x => !b.Contains(x)).ToArray();
    }
    
    public static int[] ArrayDiffBest(int[] a, int[] b)
    {
        // With a hashset, we won't have to iterate over b for every item in a.
        // Instead, we can check if an item exists in constant time
        HashSet<int> bSet = new HashSet<int>(b);
    
        return a.Where(v => !bSet.Contains(v)).ToArray();
    }
}