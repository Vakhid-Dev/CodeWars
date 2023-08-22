namespace CodeWars.Lib;

public class BasicCalculator
{
    
    public static double Execute(double num1, char op, double num2)
    {
        return op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : CallArgumentException(op),
            _ => CallArgumentException(op)
        };
    }

    private static double CallArgumentException(char param)
    {
        throw new ArgumentException(nameof(param), "You can not divide by zero");
    }
}