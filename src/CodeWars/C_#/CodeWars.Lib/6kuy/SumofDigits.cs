namespace CodeWars.Lib._6kuy;

public class SumofDigits
{
    private static bool _isReduce;
    public static int DigitalRoot(long n)
    {
        var result = n;
        while (!_isReduce)
        {
          result = Reducing(result);
        }

        _isReduce = default;
        return (int)result;
    }
    private static long  Reducing(long n)
    {
        var nums = n.ToString().Select(x => (long)char.GetNumericValue(x));
        var enumerable = nums as long[] ?? nums.ToArray();
        if (enumerable.Sum()< 10)
        {
            _isReduce = true;
        }
        return enumerable.Sum();
    }
    
    public int DigitalRootRecursive(long n)
    {
        int sum = n.ToString().Select(d => Int32.Parse(d.ToString())).Sum();
        if (sum.ToString().Count() > 1)
            sum = DigitalRoot(sum);    
        return sum;
    }
}