namespace CodeWars.Lib._5kuy;

public class Pickpeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        if(arr.Length <3) return new Dictionary<string, List<int>>() { { "pos" , new List<int>()  }, {"peaks" , new List<int>() }};
        var result = new Dictionary<string, List<int>>();
        int k = 0;
        int prev, current, next;
        var posList = new List<int>();
        var peekList = new List<int>();
        for (int i = 1; i < arr.Length-1; i++)
        {
            prev = arr[k];
            current = arr[i];
            next = arr[i + 1];
            if (current >= prev && current >= next)
            {
                if (current == next)
                {
                    if (Isplateaus(arr, current, i))
                    {
                        posList.Add(i);
                        peekList.Add(current);
                        break;
                    }
                }
                else
                {
                    posList.Add(i);
                    peekList.Add(current);
                }

            }
            ++k;
        }
        result.Add("pos",posList);
        result.Add("peaks",peekList);
        return result;
    }
    private static bool Isplateaus( int []arr ,int value,int index)
    {
        bool flag = false;
        for (int i = index; i < arr.Length; i++)
        {
            if (value > arr[i])
            {
                flag =  true;
                break;
            }
        }
        return flag;
    }
    
    
    public static Dictionary<string, List<int>> GetPeaksWork(int[] arr)
    {
        var pos = new List<int>();
        var peaks = new List<int>();
        var result = new Dictionary<string, List<int>> { { "pos", pos }, { "peaks", peaks } };
        
        if (arr == null || arr.Length < 3)
        {
            return result;
        }

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                pos.Add(i);
                peaks.Add(arr[i]);
            }
            else if (arr[i] > arr[i - 1] && arr[i] == arr[i + 1])
            {
                int plateauStart = i;
                while (i < arr.Length - 1 && arr[i] == arr[i + 1])
                {
                    i++;
                }
                if (i < arr.Length - 1 && arr[i] > arr[i + 1])
                {
                    pos.Add(plateauStart);
                    peaks.Add(arr[plateauStart]);
                }
            }
        }

        return result;
    }
    
    public static Dictionary<string, List<int>> GetPeaksBest(int[] arr)
    {
        int pos = 0, peaks = 0;
     
        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
        dictionary.Add("pos", new List<int>());
        dictionary.Add("peaks", new List<int>());
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                pos = i;
                peaks = arr[i];
            }  
            if (arr[i] > arr[i + 1]&&pos!=0) {
                dictionary["pos"].Add(pos);
                dictionary["peaks"].Add(peaks);
                pos = 0;
                peaks = 0;
            }
        }

        return dictionary;
    }
}