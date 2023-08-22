namespace CodeWars.Lib;

public class Retrievearrayvaluebyindexwithdefault
{
    public static int Solution2(int[] items, int index, int defaultValue)
    {
        int result = -1;

        if (index < 0)
        {    
            var i=  Math.Abs(index);
            if (i <= items.Length)
            {
                result = items[items.Length-1 - (i + (defaultValue))];
            }
            else
            {
                result = defaultValue;
            }
        }
   
        else
            result = index <= items.Length-1 ? items[index] : defaultValue;

        return result;
    }
    
    public static int Solution (int[] items, int index, int defaultValue)
    {
        if (Math.Abs(index) > items.Length) { return defaultValue; };
        var res = 0;
        if (index>=0)
        {
            res = items[index];
        }
        else
        {
            if (Math.Abs(index) > items.Length)
            {
                res = defaultValue;
            }
            else
            {
                var f = items.Length - Math.Abs(index);
                res = items[f];
            }
               
        }
        return res;
    }
   }
