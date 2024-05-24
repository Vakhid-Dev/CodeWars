namespace CodeWars.Lib._7kuy;

public class PossiblyPerfectClass
{
    public static bool PossiblyPerfect(string[] key, string[] ans)
    {
        var complete = new List<bool>();
        for (int i = 0; i < key.Length; i++)
        {
            if (key[i] == "_") continue;
            complete.Add(key[i] == ans[i]);
        }
        return !complete.Any() || complete.TrueForAll(x => x) 
                               || complete.TrueForAll(x=>x == false);
    }
}