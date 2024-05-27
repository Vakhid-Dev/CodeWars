public class Scramblies
{
      public static bool Scramble(string str1, string str2) 
    {
        var a = str1.Select(x=>x).OrderBy(x=>x).ToList();
        var b = str2.Select(x=>x).OrderBy(x=>x).ToList();
        var flag = true;
        foreach (var item in b)
        {
            if(a.Contains(item)){
              a.Remove(item);
        
            }else{
                flag = false;
                  break;
            }
        }
        return flag;
    }
      public static bool ScrambleBest(string str1, string str2) 
    {
        return str2.All(x=>str1.Count(y=>y==x)>=str2.Count(y=>y==x));
    }
}