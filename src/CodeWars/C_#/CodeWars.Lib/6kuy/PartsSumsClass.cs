namespace CodeWars.Lib._6kuy;

public class PartsSumsClass
{
    public static int[] PartsSums(int[] ls)
    {
        var sum = ls.Sum();
        var result = new List<int> { sum };

        for (var i = 0; i < ls.Length; i++)
        {
            sum -= ls[i];
            result.Add(sum);
        }

        return result.ToArray();
    }
}