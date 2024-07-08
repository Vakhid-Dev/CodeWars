
public class BubbleSortClass
{

    public  int[] BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        return arr;
    }

    public  void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b= c;
    }
}