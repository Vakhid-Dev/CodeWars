namespace CodeWars.Lib;

public class Findalloccurrencesofanelementinanarray
{
    public static int[] FindAll(int[] array, int n)
    {
        return array.Select((_, y) =>
             Array.IndexOf(array, n, y))
            .Distinct()
            .Where(item => item >= 0)
            .ToArray();
    }
    
    public static int[] FindAll2(int[] a, int n) => 
        a.Select((v, i) => v == n ? i : -1)
        .Where(i => i >= 0).ToArray();
}