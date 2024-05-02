namespace CodeWars.Lib._6kuy;

public class DevideBy3or5
{
    public static int Solution(int value)
    {
        return value < 0 ? 0 : Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    } 	
}