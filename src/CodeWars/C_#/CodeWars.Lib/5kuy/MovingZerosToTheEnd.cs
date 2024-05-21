namespace CodeWars.Lib._5kuy;

public class MovingZerosToTheEnd
{
    public static int[] MoveZeroes(int[] arr)
    {
        
        var list = arr.Where(x => x != 0).ToList();
        list.AddRange(new int [arr.Length - list.Count]);
        return list.ToArray();
    }
    public static int[] MoveZeroesBest(int[] arr)
    {
        return arr.OrderBy(x => x==0).ToArray();
    }
}    
