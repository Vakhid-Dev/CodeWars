namespace CodeWars.Lib;

public class Powersof3
{
    public static int LargestPower(int n)
    {
        int result = -1;
        for (int i = 0; i < n; i++)
        {
            if (Math.Pow(3, i) < n)
            {
                result = i;
            }
        }

        return result;
    }
    public static int LargestPower2(int n) {
        int k = 0;  
        while(Math.Pow(3,k) < n) {
            k++;
        }
        return k-1;    
    }
    public static int LargestPower3(int n) => (int)Math.Ceiling(Math.Log(n, 3)) - 1;
}