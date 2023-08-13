namespace CodeWars.Lib;

public class Arraycomparator
{
    public static int MatchArrays(int[] v, int[] r)
    {
        return v.Intersect(r).Count();
    }
}