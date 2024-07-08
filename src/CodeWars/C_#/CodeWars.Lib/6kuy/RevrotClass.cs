using System.Text;

namespace CodeWars.Lib._6kuy;
public class RevrotCLass
{
    public static string RevRot(string strng, int sz)
    {
        if (strng.Length == 0 || sz == 0 || strng.Length < sz) return "";
        var chunks = strng
        .Chunk(sz)
        .Where(x => x.Count() == sz)
        .Select(chunk => chunk.Select(c => int.Parse(c.ToString())).ToList())
        .ToList();
        var builder = new StringBuilder();
        foreach (var chunk in chunks)
        {
            var str = string.Concat(chunk);
            builder.Append(chunk.Sum() % 2 == 0 ?
            string.Concat(str.Reverse()) :
            string.Concat(str.Substring(1), chunk[0]));
        }

        return builder.ToString();
    }
    private static List<List<int>> GetChunks(string strng, int sz)
    {
        var chunks = new List<List<int>>();

        var chunkCount = strng.Length / sz;
        int from = 0;
        int to = sz;
        int index = 0;
        while (index < chunkCount)
        {
            var array = new List<int>();
            for (int i = from; i < to; i++)
            {
                array.Add(int.Parse(strng[i].ToString()));
            }
            chunks.Add(array);
            from = to;
            to += sz;
            ++index;
        }
        return chunks;
    }
}