using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class UniqueInOrderClassTest
{
    [Test]
    public void EmptyTest()
    {
        Assert.AreEqual("", UniqueInOrderClass.UniqueInOrderBest(""));
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual("ABCDAB", UniqueInOrderClass.UniqueInOrderBest("AAAABBBCCDAABBB"));
        Assert.AreEqual("ABCDABC", UniqueInOrderClass.UniqueInOrderBest("AAAABBBCCDAABBC"));
    }
}