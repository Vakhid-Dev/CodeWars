namespace CodeWars.Lib;

public class Findfactor_ofanumber
{
    public static int[] Factors(int num)
    {
        if (num < 1)
            return Array.Empty<int>();
        var devider = 2;
        int n=-1;
        var list = new List<int>();
         list.Add(num);
        do
        {
            if (num % devider == 0)
            {
                n = num / devider;
                list.Add(n);
            }
            ++devider;
        } while (n!=1);

        return list.ToArray();
    }
    /// <summary>
    /// Clever solution
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[] Factors2(int n)
    {
        return n<1 ?new int[]{} : Enumerable.Range(1,n).Where(x=>n%x==0).OrderByDescending(x=>x).ToArray();
    }
}