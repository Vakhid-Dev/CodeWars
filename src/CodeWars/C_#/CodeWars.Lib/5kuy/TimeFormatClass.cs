namespace CodeWars.Lib._5kuy;

public class TimeFormatClass
{
    public static string GetReadableTime(int seconds)
    {
        int mm = 0;
        int hh = 0;
        int ss = 0;

        int i = 0;
        int k = 59;
        while (i < seconds)
        {
            if (ss > 59 || i == k)
            {
                ss = 0;
                ++mm;
                k += 60;
                if (mm > 59)
                {
                    ++hh;
                    mm = 0;
                    if (hh > 99)
                    {
                        --hh;
                        break;
                    }
                }
            }
            else
            {
                ++ss;
            }

            ++i;
        }

        return string.Join(":",
            hh.ToString().Count() > 1 ? hh.ToString() : $"0{hh}",
            mm.ToString().Count() > 1 ? mm.ToString() : $"0{mm}",
            ss.ToString().Count() > 1 ? ss.ToString() : $"0{ss}");
    }
    
    public static string GetReadableTimeBest(int seconds)
    {
        return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
    }
    public static string GetReadableTimeBest2(int seconds)
    {
        var t = TimeSpan.FromSeconds(seconds);
        return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
    }
}