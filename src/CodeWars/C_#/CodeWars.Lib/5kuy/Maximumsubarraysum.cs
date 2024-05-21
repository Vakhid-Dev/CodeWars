namespace CodeWars.Lib._5kuy;

public class Maximumsubarraysum
{
    public static int MaxSequence(int[] arr)
    {
        if (arr.All(x => x < 0) || arr.Length == 0) return 0;
        if (arr.All(x => x > 0)) return arr.Sum();
        int max = int.MinValue;
        int sum = 0;
        int from = 0;
        int to = 1;
        while (from < arr.Length)
        {
            for (int i = from; i <to; i++)
            {
                sum += arr[i];
            }

            if (sum > max)
            {
                max = sum;
            }

            if (to == arr.Length)
            {
                ++from;
                to = from ;
            }

            sum = 0;
            ++to;
        }

        return max;
    }
    
    public static int MaxSequenceBest(int[] arr) 
    { 
        int max = 0;
        int sum = 0;
        foreach(int i in arr)
        {
            sum += i;
            if (sum > max)
                max = sum;
            else if (sum < 0)
                sum=0;
        }
        return max;

    }
}