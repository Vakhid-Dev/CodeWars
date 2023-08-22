namespace CodeWars.Lib;

public class ProductOfMaximumsOfArray_Array_Series__2_
{
    public static int MaxProduct(int[] arr, int size)
    {
        return arr.OrderByDescending(x=>x).Take(size).Aggregate((x, y) => x * y);
    }
}