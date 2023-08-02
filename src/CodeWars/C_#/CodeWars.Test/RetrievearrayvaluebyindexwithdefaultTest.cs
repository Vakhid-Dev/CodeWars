using CodeWars.Lib;

namespace CodeWars.Test;

public class RetrievearrayvaluebyindexwithdefaultTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        int[] range = Enumerable.Range(1, 3).ToArray();
        Assert.AreEqual(-1, Retrievearrayvaluebyindexwithdefault.Solution(range, 5, -1));
        Assert.AreEqual(2, Retrievearrayvaluebyindexwithdefault.Solution(range, 1, -1));
        Assert.AreEqual(3, Retrievearrayvaluebyindexwithdefault.Solution(range, -1, -1));
        Assert.AreEqual(-1, Retrievearrayvaluebyindexwithdefault.Solution(range, -5, -1));
        Assert.AreEqual(1, Retrievearrayvaluebyindexwithdefault.Solution(range, -3, -1));
    }
}