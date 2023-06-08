namespace CodeWars.Lib;

public class CompoundArrayClass
{
    public static int[] CompoundArray(int[] a, int[] b)
    {
        var k = b.Length;
        var list = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (k <= 0) continue;
            list.AddRange(new []{a[i],b[i]});
            --k;
        }

        list.AddRange(k > 0 ? b.Skip(a.Length) : a.Skip(b.Length));

        return list.ToArray();

    }
}