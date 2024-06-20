public class Polindrom
{
    public bool IsPalindrome(int x)
{
    string s = x.ToString();
    int length = s.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (s[i] != s[length - 1 - i])
        {
            return false;
        }
    }

    return true;
}
}