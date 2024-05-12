
namespace CodeWars.Lib._6kuy;

public class FindEvenIndexClass
{
    public static int FindEvenIndex(int[] arr)
    {
        var k = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            var sums = GetSum(arr, i );
            if (sums[0] == sums[1])
            {
                k = i;
                break;
            }
        }
        
        return k;
    }
    
    private static int [] GetSum(int[] arr, int indexStart)
    {
        if (indexStart == 0) return new[] { 0, arr.TakeLast(arr.Length-1).Sum()};
        int sum = 0;
        int [] sums = new int [2];
        int step = 0;
        int k = 0;
        int count = indexStart;
        
        while (step < 2)
        {
            for (int i = k; i <count; i++)
            {
                sum += arr[i];
            }
            sums[step] = sum;
            ++step;
            sum = 0;
            k = ++indexStart;
            count = arr.Length;
        }
        
        return sums;
    }
    
    public static int FindEvenIndexBest(int[] arr)
    {
        int leftSum = 0, rightSum = arr.Sum();

        for (int i = 0; i < arr.Length; ++i)
        {
            rightSum -= arr[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += arr[i];
        }

        return -1;
    }
}