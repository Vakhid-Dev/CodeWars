using System.Collections;
using System.Collections.Immutable;

namespace CodeWars.Lib._6kuy;

public class UniqueInOrderClass
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {

        if (!iterable.Any()) return Enumerable.Empty<T>();

        var immutableList = iterable.ToImmutableList();
        var result = new List<T>();
        int k = 1;
        for (int i = 0; i < immutableList.Count() - 1; i++)
        {
            if (immutableList[i]?.ToString() == immutableList[k]?.ToString())
            {
                ++k;
                continue;
            }

            result.Add(immutableList[i]);
            ++k;
        }

        //hardcode Add las element
        result.Add(immutableList.Last());
        return result;
    }
    public static IEnumerable<T> UniqueInOrderBest1<T>(IEnumerable<T> iterable) 
    {
        var retList = new List<T>();
        foreach (var element in iterable) if (!element.Equals(retList.LastOrDefault())) retList.Add(element);
        return retList;
    }
    public static IEnumerable<T> UniqueInOrderBest<T>(IEnumerable<T> iterable)
    {
        T previous = default(T);
        foreach (T current in iterable)
        {
            if (!current.Equals(previous))
            {
                previous = current;
                yield return current;
            }
        }
    }
}
