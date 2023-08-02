namespace CodeWars.Lib;

public class MaxPossibleScoreClass
{
    public static int MaxPossibleScore(Dictionary<object, int> obj, object[] arr)
    {
        int sum = 0;
        foreach (var kv in obj)
        {
            if(arr.Contains(kv.Key))
                sum += kv.Value * 2;
            else
                sum += kv.Value;
        }

        return sum;
    }
    /// <summary>
    /// BS
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int MaxPossibleScore2(Dictionary<object, int> obj, object[] arr)
    {
        return obj.Sum(x=>x.Value * (arr.Contains(x.Key) ? 2 : 1));
    }
}