namespace CodeWars.Lib;

public static class SimpleExtensionMethods
{
    public static string SayHello(this string m)
    {
        return $"Hello, {m}!";
    }
    public static string SayGoodbye(this string m)
    {
        return $"Goodbye, {m}. See you again soon!";
    }
}