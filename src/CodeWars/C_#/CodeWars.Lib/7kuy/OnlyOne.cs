namespace CodeWars.Lib;

public class OnlyOne1
{
    public static bool OnlyOne(params bool[] flags)
    {
        if (flags.Length == 0) return false;
        return flags.Where(x=> x).Count()==1;
    }
}