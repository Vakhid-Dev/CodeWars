namespace CodeWars.Lib._6kuy;

public class DigPowClass
{
    public static long digPow(int n, int p)
    {
        var nums = n.ToString().Select(x => int.Parse(x.ToString())).ToList();
        long sum = 0;
        foreach (var num in nums)
        {
            sum += (long)Math.Pow(num, p);
            ++p;
        }

        return  (sum / n) * n == sum  ? sum / n : -1;
    }
}