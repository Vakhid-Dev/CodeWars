namespace CodeWars.Lib._6kuy;

public class Persist
{
    public static int Persistence(long n)
    {
        if (n.ToString().Length == 1) return 0;
         int counter = 0;
         while (true)
         {
             ++counter;
             var sum = RecursiveCall(n);
             if (sum.ToString().Length == 1)
             {
                 break;
             }
             n = sum;
         }
         return counter;
    }

    private static int RecursiveCall(long n)
    {
        var nChars = n.ToString();
        var mult = 1;
        foreach (var nc in nChars)
        {
            mult *= int.Parse(nc.ToString());
           
        }
        return mult;
    }
    
    
    public static int PersistenceBest(long n)
    {
        int count = 0;
        while (n > 9)
        {
            count++;
            n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
        }
        return count;
    }
}