namespace CodeWars.Lib;

public class Lowercasestringsinarray
{
    public static object[] ArrayLowerCase(object[] arr)
    {
        return arr.Select(x => x is string ? x.ToString().ToLower() : x ).ToArray();;
    }
    /// <summary>
    /// Good solution
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static object[] ArrayLowerCase2(object[] arr)
    {
        return arr.Select(o => (o as string)?.ToLower() ?? o).ToArray();
    }
}