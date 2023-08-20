namespace CodeWars.Lib;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
public class MaximumGap_Array_Series__4_
{
    public static int MaxGap(int[] numbers)
    {
        int max = int.MinValue;
        var numOrders = numbers.OrderByDescending(x=>x).ToList();
        for (int i = 0; i <numOrders.Count-1; i++)
        {
            if (numOrders[i] - numOrders[i + 1] > max)
                    max = numOrders[i] - numOrders[i + 1];
        }
        return max ;
    }
    public static int MaxGap2(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers.Zip(numbers.Skip(1), (a, b) => b - a).Max();
    }
}