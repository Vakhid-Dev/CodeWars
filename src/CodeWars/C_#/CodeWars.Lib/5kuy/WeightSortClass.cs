namespace CodeWars.Lib._5kuy;

public class WeightSortClass
{
    public static string orderWeight(string strng)
    {
        return string.Join(" ", strng.Split(' ')
                .OrderBy(n => n.ToCharArray()
                    .Select(c => (int)char.GetNumericValue(c)).Sum())
                .ThenBy(n => n));
    }
    
}