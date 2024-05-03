namespace CodeWars.Lib._6kuy;

public class FindTheParityOutlier
{
    public static int Find(int[] integers)
    {
        var a = integers.Where(x => x % 2 == 0).ToList();
        var c = integers.Count(x => x % 2 == 1) > integers.Count(x => x % 2 == 0)
            ? integers.FirstOrDefault(x => x % 2 == 0)
            : integers.FirstOrDefault(x => x % 2 == 1);
        

        var b = integers.Where(x => x % 2 == 1).ToList();
        return a.Count() == 1 ? a[0]:b[0];
    }
}