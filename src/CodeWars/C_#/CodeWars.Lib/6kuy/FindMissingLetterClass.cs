public class FindMissingLetterClass
{
    public static char FindMissingLetter(char[] array)
    {
        var list = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        var result = ' ';
        list = list.SkipWhile(x => x!= char.ToLower(array[0])).ToList();
        for (int i = 0; i < array.Length; i++)
        {
            if (!string.Equals(array[i].ToString(), list[i].ToString(), StringComparison.OrdinalIgnoreCase))
            {
                result = char.IsUpper(array[0])  ? char.ToUpperInvariant(list[i]) : char.ToLowerInvariant(list[i]);
                break;
            };
        }
        return result;
    }

    public static char FindMissingLetterBest(char[] array) => (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x));
}