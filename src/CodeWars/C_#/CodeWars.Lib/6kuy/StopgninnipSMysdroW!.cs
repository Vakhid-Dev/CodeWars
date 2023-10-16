using System.Text;

namespace CodeWars.Lib._6kuy;

public class StopgninnipSMysdroW_
{
    public static string SpinWords(string sentence)
    {
        var strs = sentence.Split(' ');
        var builder = new StringBuilder();
        foreach (var str in strs)
        {
            if (str.Length >= 5)
                builder.Append(string.Concat(str.Reverse()) +' ');
            else
                builder.Append(str + ' ');
        }
        
        builder.Remove(builder.Length-1,1);
        return builder.ToString();
    }
    public static string SpinWords2(string sentence)
    {
        string[] words = sentence.Split(' ');
        var reversedWords = words.Select(word => word.Length >= 5 ? string.Concat(word.Reverse()) : word);
        return string.Join(" ", reversedWords);
    }
}