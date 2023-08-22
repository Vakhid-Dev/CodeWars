namespace CodeWars.Lib;

public class Findtheuniquenumber
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var listsDist = numbers.Distinct().ToList();
        var uniqueNumber = 0;
        foreach (var num in listsDist)
        {
            if (numbers.Count(x => x == num) == 1) 
                uniqueNumber = num;
        }
        return uniqueNumber;
    }
    //Best practices
    
    public static int GetUnique_(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x=>x).Single(x=> x.Count() == 1).Key;
    }
   
}