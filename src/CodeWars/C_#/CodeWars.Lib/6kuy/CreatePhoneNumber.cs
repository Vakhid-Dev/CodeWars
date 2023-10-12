using System.Text;

namespace CodeWars.Lib._6kuy;

public class CreatePhoneNumberClass
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append('(');
        int k = 3;
        int step = 2;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == k)
            {
                if (step != 1)
                {
                    builder.Append(')');
                    builder.Append(' ');
                }
                else
                    builder.Append('-');
                --step;
                if(step!=0)
                    k += 3;
            }
     
            builder.Append(numbers[i]);
        }

        return builder.ToString();
    }
    
    public static string CreatePhoneNumber2(int[] numbers)
    {
        return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
    }
    public static string CreatePhoneNumber3(int[] numbers)
    {
        return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
    }
}