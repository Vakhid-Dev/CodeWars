namespace CodeWars.Lib._6kuy;

public class Findtheodd_int
{
    public static int find_it(int[] seq)
    {
        if (seq.Length ==1) return seq[0];
        var list = new List<int>() { };
        list.AddRange(seq);
        int result = Int32.MinValue;
        foreach (var t in list.Where(t => list.Count(x => x == t) % 2 == 1))
        {
            result = t;
            break;
        }

        return result;
    }
    public static int find_it2(int[] seq) 
    {
        return  seq.First(x => seq.Count(s => s == x) % 2 == 1);
    }
}