namespace CodeWars.Lib;

public class Sorttheodd
{
    public static int[] SortArray(int[] array)
    {
        var mapsOdd = new Dictionary<int, int>();
        for (int i = 0; i <array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                mapsOdd.Add(i,array[i]);
            }
        }
        var indexs = mapsOdd.Keys.ToList();
        var ord = mapsOdd.OrderBy(x=>x.Value).
            ToDictionary(x => x.Key, x => x.Value).Values;
        var k = 0;
        foreach (var value in ord)
        {
            array[indexs[k]] = value;
            ++k;
        }
        return array;
    }
    
    //Best practices
    public static int[] SortArray_(int[] array)
    {
        Queue<int> odds = new Queue<int>(array.Where(e => e%2 == 1).OrderBy(e => e));
        return array.Select(e => e%2 == 1 ? odds.Dequeue() : e).ToArray();
    }
}