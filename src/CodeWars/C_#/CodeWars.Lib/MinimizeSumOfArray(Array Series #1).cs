namespace CodeWars.Lib;

public class MinimizeSumOfArray_Array_Series__1_
{
    public static int MinSum(int[] a)
    {
        var numOrdes = a.OrderByDescending(x => x).ToList();
        var count = numOrdes.Count / 2;
        var max = numOrdes.Take(count).ToList();
        numOrdes.Reverse();
        var min = numOrdes.Take(count).ToList();
        int sum = 0;
        int i = 0;
        while (i < count )
        {
            sum += max[i] * min[i];
            ++i;
        }
        return sum;
    }
    
    public static int MinSum2(int[] a)
    {
        var list = a.OrderBy(x => x).ToList();
        int result = 0;
        int i = 0, j = a.Length - 1;
            
        while (i < j)
        {
            result += list[i++] * list[j--];
        }

        return result;
    }
}