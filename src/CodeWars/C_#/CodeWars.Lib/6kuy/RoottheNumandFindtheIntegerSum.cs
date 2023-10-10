namespace CodeWars.Lib._6kuy;
public class RoottheNumandFindtheIntegerSum
{
    //Local test passed
    public int RootSum(int n)
    {
        var sum = 0;
        if (n <= 1) return n;
        int k = 1;
        if (n % 2 == 0)
            k = 2;
        for (int i = k; i <=n; i+=k)
        {
            var log = Math.Round(Math.Log(n, i));
            if(Math.Pow(i, log)==n)
                sum+=i;
        }
        
        return sum;
    }
    //Local + Global
    public int RootSum2(int n)
    {
        int t = n;
        for (int p=2;; ++p) {
            int v = (int)Math.Round(Math.Pow(n, (double)1/p), 10);
            if (v < 2) break;
            if (Math.Pow(v, p) == n) t += v;
        }
        return t;
    }
}