using CodeWars.Lib;

namespace CodeWars.Test;

public class OnlyOneTest
{
    [Test]
    public void BasicTest()
    {
        Assert.AreEqual(true, OnlyOne1.OnlyOne(true, false));
    }
}