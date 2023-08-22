using System.Globalization;
using System.Text;

namespace CodeWars.Lib;

public class ConvertingIntegertoCurrencyFormat
{
    public static string ToCurrency(int price)
    {
        return string.Concat(string.Format("{0:0,0}", price).Split(null).Select(x => $"{x},")).TrimEnd(',');
    }

    public static string ToCurrency2(int price)
    {
        return string.Format(CultureInfo.InvariantCulture, "{0:N0}", price); 
    }
    
    public static string ToCurrency3(int price)
    {
       return  string.Format(CultureInfo.InvariantCulture, "{0:0,0}", price);
  
    }
}