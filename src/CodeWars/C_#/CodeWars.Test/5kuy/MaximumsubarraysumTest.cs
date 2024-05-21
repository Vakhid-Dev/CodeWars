using CodeWars.Lib._5kuy;

namespace CodeWars.Test._5kuy;

public class MaximumsubarraysumTest
{

    [Test]
    public void Test0()
    {
        Assert.AreEqual(0, Maximumsubarraysum.MaxSequence(new int[0]));
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual(6, Maximumsubarraysum.MaxSequence(new int[]{-2, 1, -3, 4, -1, 2, 1, -5, 4}));
    }
}