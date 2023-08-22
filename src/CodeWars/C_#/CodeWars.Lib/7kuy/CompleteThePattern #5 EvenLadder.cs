using System.Text;

namespace CodeWars.Lib;

public class CompleteThePattern__5_EvenLadder
{
    public static string Pattern(int n)
    {
        if (n <= 1) return "";
        StringBuilder builder = new StringBuilder();
        for (int i = 1; i <=n; i++)
        {
            if (i % 2 == 0 ) 
                builder.Append(string.Concat(Enumerable.Repeat(i, i)) + "\n");
        }
        return builder.ToString().TrimEnd();
    }
    
    /// <summary>
    /// Linq solution
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string Pattern2(int n)
    {
        return string.Join("\n", Enumerable.Range(1, Math.Max(0, n)).Where(x => x % 2 == 0)
            .Select(x => string.Concat(Enumerable.Repeat(x.ToString(), x))));
    }
}