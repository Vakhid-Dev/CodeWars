namespace CodeWars.Lib._6kuy;

public class FindTheParityOutlier
{
    public static int Find(int[] integers)
    {
        var list = integers.ToList();
        return list.Count(x=>x%2==0)>1? 
            list.FirstOrDefault(x=>x%2==1): 
            list.FirstOrDefault(x=>x%2==0);
    }
    public static int Find2(int[] arr)
    {
        int n = arr.Take(3).Count(i => i%2 == 0) > 1 ? 1 : 0;
        return arr.First(i => i%2 == n);
    }
}