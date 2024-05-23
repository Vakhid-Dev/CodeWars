namespace CodeWars.Lib._5kuy;

public class CountIPAddresses
{
    public static long IpsBetween(string start, string end)
    {
       
        var AList = start.Split('.').Select(int.Parse).ToList();
        var BList = end.Split('.').Select(int.Parse).ToList();
        var power = 3;
        long sumA = 0; 
        long sumb = 0;
        foreach (var t in AList)
        {
            sumA += t * (long)Math.Pow(256, power);
            --power;
        }
        power = 3;
        foreach (var t in BList)
        {
            sumb += t * (long)Math.Pow(256, power);
            --power;
        }

        return sumb - sumA;
    }
    
    
    public static long IpsBetween1(string start, string end)
    {
        return IpToNumberBest(end) - IpToNumberBest(start);
    }
    
    public static long IpToNumberBest(string ip)
    {
        var ints = ip.Split('.').Select(long.Parse).Reverse().ToArray();
        long value = 0;
        for (int i = 0; i < 4; i++)
        {
            value += ints[i] * (long)Math.Pow(256, i);
        }

        return value;
    }
    
}