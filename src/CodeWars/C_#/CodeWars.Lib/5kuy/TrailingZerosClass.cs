using System.Numerics;

public class TrailingZerosClass
{ 
 public static int TrailingZeros(int n)
  { 
    int fives = 0;
    for (int i = 5; i <= n; i *= 5)
        fives += n/i;
    
    return fives;
  }
}