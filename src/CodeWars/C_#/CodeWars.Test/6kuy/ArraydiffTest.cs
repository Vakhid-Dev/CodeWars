using CodeWars.Lib._6kuy;
using CodeWars.Lib._6kuy.Arrays;

namespace CodeWars.Test._6kuy;

public class ArraydiffTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new int[] { 2 }, Arraydiff.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
        Assert.AreEqual(new int[] { 2, 2 }, Arraydiff.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
        Assert.AreEqual(new int[] { 1 }, Arraydiff.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
        Assert.AreEqual(new int[] { 1, 2, 2 }, Arraydiff.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
        Assert.AreEqual(new int[] { }, Arraydiff.ArrayDiff(new int[] { }, new int[] { 1, 2 }));

    }
}