namespace CodeWars.Lib;

public class CompleteThePattern__6_Odd_Ladder
{
    /// <summary>
    /// My solution
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string OddLadder(int n)
    {
        string result = String.Empty;
        if(n<=0)
            return result;
        var isEven = n % 2 == 0;
        if (isEven)
            --n;
        for (int i = 1; i <=n; i+=2)
        {
            result+= i!=n ? string.Concat(Enumerable.Repeat(i.ToString(), i))+"\n":string.Concat(
                Enumerable.Repeat(i.ToString(), i));
        }

        return result;
    }
    
    /// <summary>
    /// Best solution
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string OddLadder2(int n)
    {
        if (n <= 0) return String.Empty;
    
        var oddNumbers = Enumerable.Range(1, n).Where(i => i % 2 == 1);
        var lines = oddNumbers.Select(i => String.Join("", Enumerable.Repeat(i.ToString(), i)));
    
        return String.Join(Environment.NewLine, lines);
    }
}