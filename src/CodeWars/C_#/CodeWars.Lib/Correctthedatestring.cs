using System.Globalization;
using System.Text.RegularExpressions;

namespace CodeWars.Lib;

public class Correctthedatestring
{
    /// <summary>
    /// Past in the local test
    /// </summary>
    /// <param name="dateString"></param>
    /// <returns></returns>
    public static string Correct(string dateString)
    {
        if (string.IsNullOrEmpty(dateString)) return dateString;
        string result = null;
        DateTime temp;

        if (!DateTime.TryParse(dateString, CultureInfo.CreateSpecificCulture("de-DE"), DateTimeStyles.None, out temp))
        {
            var splitDate = dateString.Split(".");
            if (splitDate.Length == 3 && dateString.ToCharArray().Count(c => c == '.') == 2)
            {
                int year;
                int.TryParse(splitDate[2], out year);
                int month;
                int.TryParse(splitDate[1], out month);
                int day;
                int.TryParse(splitDate[0], out day);
                if (year == 0 || month == 0 || year == 0) return null;
                var date = new DateTime(year, month < 12 ? month : 12, 1);
                var result2 = date.AddMonths(month > 12 ? month - 12 : 0).AddDays(day - 1);
                return result2.ToString("dd.MM.yyyy",
                    CultureInfo.DefaultThreadCurrentCulture);
            }
        }

        return result;
    }
    
    /// <summary>
    /// Clever solution
    /// </summary>
    /// <returns></returns>
    private static string DatePattern = @"\A(?<days>\d+)\.(?<months>\d+)\.(?<years>\d+)\z";
    public static string Correct2(string dateString)
    {
        if (string.IsNullOrEmpty(dateString))
        {
            return dateString;
        }

        var dateMatch = Regex.Match(dateString, DatePattern);
        if (!dateMatch.Success)
        {
            return null;
        }

        int days = int.Parse(dateMatch.Groups["days"].Value);
        int months = int.Parse(dateMatch.Groups["months"].Value);
        int years = int.Parse(dateMatch.Groups["years"].Value);

        var date = DateTime.MinValue.AddYears(years - 1).AddMonths(months - 1).AddDays(days - 1);
        
        return date.ToString("dd.MM.yyyy");
    }
    
    /*
     * Очень много времени потерял ,проблема немного в алгоритме (нужно было использовать regex) и нужно было правильно культуру даты использовать
     */
}