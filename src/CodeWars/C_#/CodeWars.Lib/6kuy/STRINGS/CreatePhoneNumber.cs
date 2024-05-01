using System.Text;

namespace CodeWars.Lib._6kuy.STRINGS;

public class CreatePhoneNumber_
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var builder = new StringBuilder();
        for (int i = 0; i <numbers.Length; i++)
        {
            while (i <3)
            {
                if (i == 0)
                {
                    builder.Append('(');
                }
                builder.Append(numbers[i]);
                ++i;
                if (i == 3)
                {
                    builder.Append(')');
                }
            }
            builder.Append(' ');
            while (i <6)
            {
                builder.Append(numbers[i]);
                ++i;
            }
            builder.Append('-');
            while (i<numbers.Length)
            {
                builder.Append(numbers[i]);
                ++i;
            }
        }

        return builder.ToString();
    }
    
    public static string CreatePhoneNumberBest(int[] numbers)
    {
        return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
    }
    public static string CreatePhoneNumberRefactor(int[] numbers)
    {
        var builder = new StringBuilder();
        var pattern = "(___) ___-____";
        var indexOfList = IndexOfList(pattern, '_');
        var counter = 0;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (indexOfList.Any(x => x == i))
            {
                builder.Append(numbers[counter]);
                ++counter;
            }
            else
            {
                builder.Append(pattern[i]);
            }
        }

        return builder.ToString();
    }

    private static List<int> IndexOfList(string source, char value)
    {
        var list = new List<int>();
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] == value)
            {
                list.Add(i);
            }
        }
        return list;
    }
}