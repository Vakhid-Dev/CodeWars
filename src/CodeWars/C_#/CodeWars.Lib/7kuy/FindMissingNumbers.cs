namespace CodeWars.Lib;

public class FindMissingNumbers1
{
    public static int[] FindMissingNumbers(int[] arr)
    {
        return arr.Length > 2 ? (Enumerable.Range(arr[0],arr[arr.Length-1] -arr[0])).Except(arr).ToArray() : new int[0];
        if (arr.Length < 2) return new int[0];
        var list = new List<int>();
        for (int i = arr[0]; i < arr[arr.Length-1]; i++)
        {
            list.Add(i);
        }
       
        return list.Except(arr).ToArray();
    }
}