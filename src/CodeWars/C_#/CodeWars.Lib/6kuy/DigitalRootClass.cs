namespace CodeWars.Lib._6kuy;

public class DigitalRootClass
{
    public static int DigitalRoot(long n)
    {
        long sum;
        while (true)
        {
            var strs = n.ToString();
            if (strs.Length == 1)
            {
                sum = int.Parse(strs);
                break;
            }

            n = RecursiveCalc(strs);
        }       
        return (int)sum;
    }

    private static long RecursiveCalc(string strs)
    {
        var list = new List<int>();
        foreach (var str in strs)
        {
            int num = int.Parse(str.ToString());
            list.Add(num);
        }
        return list.Sum();
    }
    
    public int DigitalRootBest(long n)
    {
        int sum = n.ToString().Select(d => Int32.Parse(d.ToString())).Sum();
        if (sum.ToString().Count() > 1)
            sum = DigitalRoot(sum);    
        return sum;
    }
}