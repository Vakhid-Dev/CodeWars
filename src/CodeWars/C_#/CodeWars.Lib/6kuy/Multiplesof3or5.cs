namespace CodeWars.Lib._6kuy;

public class Multiplesof3or5
{
    public static int Solution(int value)
    {
        return value < 0 ? 0 :
                Enumerable.Range(0, value).
                Sum(x => x % 3 == 0 || x % 5 == 0 ? x:0);
    }
    public static int Solution2(int value)
    {
        var sum = 0;
        for(int i = 3; i < value; i++)
        {
            if(i % 3 == 0 || i % 5 == 0) sum += i;
        }
        return sum;
    }
}