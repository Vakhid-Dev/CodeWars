namespace CodeWars.Lib._7kuy;

public class LatinSquareClass
{
     public  int[][] MakeLatinSquare(int n) 
    {
      var res = new int[n][]; 
      var tempArray = Enumerable.Range(1, n).ToArray();
      
      for (int i = 0; i < tempArray.Length; i++)
      {
        res[i] = BuildArray(tempArray,i,tempArray.Length);
      }

      return res;
    }
    public int [] BuildArray(int [] arr,int startIndex,int len)
    {
        var res = new int[len];

        for (int i = 0; i < len;i++)
        {
            if(startIndex < len)
            {
              res [i] = arr [startIndex];
            }else
             {
             startIndex = 0;
             res [i] = arr [startIndex];
            }
            ++startIndex;
        
        }  
    return res;
    }
}   