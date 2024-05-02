using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CodeWars.Lib._6kuy.Arrays;

public class SpinWordsCLass
{
    public static string SpinWords(string sentence)
    {
        var splitSentence = sentence.Split(' ');
        var builder = new StringBuilder();
        var counter = splitSentence.Length - 1;
        foreach (var s in splitSentence)
        {
            builder.Append(s.Length >= 5 ? Reverse(s) : s);
            if (counter != 0)
            {
                builder.Append(" ");
            }

            --counter;
        }

        return builder.ToString();
    }
    
    private static string Reverse(string str)
    {
        var builder = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            builder.Append(str[i]);
        }

        return builder.ToString();
    }

    public static string SpinWordsBest(string sentence)
    {
        return string.Join(" ", sentence.Split(" ").Select(s => s.Length >= 5 ? new string(s.Reverse().ToArray()) : s));
    }
}