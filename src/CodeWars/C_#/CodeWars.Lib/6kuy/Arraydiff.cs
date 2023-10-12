namespace CodeWars.Lib._6kuy;

public class Arraydiff
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        return  a.Where(x => !b.Contains(x)).ToArray();
    }
}