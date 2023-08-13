using CodeWars.Lib;

namespace CodeWars.Test;

public class ArraycomparatorTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.AreEqual(4, Arraycomparator.MatchArrays(new int[] {1,2,3,4,5}, new int[] {2, 3, 4, 5, 6}));
        Assert.AreEqual(2, Arraycomparator.MatchArrays(new int[] {1,2,3,4,5}, new int[] {5, 4}));
        Assert.AreEqual(1, Arraycomparator.MatchArrays(new int[] {0, -1, 1, 4}, new int[] {-1}));
    }
}