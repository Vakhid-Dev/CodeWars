namespace CodeWars.Lib;

public class SumofOddCubedNumbers
{
    public static int CubeOdd(int[] arr)
    {
        return arr.Where(x => Math.Abs(x) % 2 == 1).Select(x => (int) Math.Pow(x, 3)).Sum();
    }
}