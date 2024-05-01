namespace CodeWars.Lib._6kuy;

public class TakeaTenMinutesWalk
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10)
            return false;

        int counter = 0;
        while (counter < walk.Length)
        {
            if (walk[counter] == walk[++counter])
            {
                return false;
            }

            ++counter;
        }

        return true;
    }
}