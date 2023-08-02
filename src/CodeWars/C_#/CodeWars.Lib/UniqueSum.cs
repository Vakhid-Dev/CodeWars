namespace CodeWars.Lib;

public class UniqueSumClass
{
    public static int? UniqueSum(List<int> lst)
    {
        return lst.Any() ? lst.Distinct().Sum() : null;
    }
}