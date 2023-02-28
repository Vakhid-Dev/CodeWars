namespace CodeWars.Lib;

public class Arrays
{
    #region SumOfMinimums

    /// <summary>
    /// My solution
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int SumOfMinimums(int[,] numbers)
    {
        var sum = 0;
        int count =0 ;
        int length = numbers.GetLength(0);
        var min = numbers[count,0];
        while (count<length)
        {
            for (int j = 0; j < numbers.Length/length; j++)
            {
                var number = numbers[count, j];
                if (number < min)
                    min = number;
            } 
            sum += min;
            ++count;
            if(count!=length)
                min = numbers[count,0];
        }
        return sum ;
    }
    /// <summary>
    /// Best solution
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int SumOfMinimumsBest(int[,] n)
    {
        return Enumerable.Range(0, n.GetLength(0))
            .Select(x => Enumerable.Range(0, n.GetLength(1)).Select(y => n[x,y]))
            .Sum(x => x.Min());
    }
    #endregion
 
}