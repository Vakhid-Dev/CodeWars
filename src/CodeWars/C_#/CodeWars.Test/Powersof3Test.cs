using CodeWars.Lib;

namespace CodeWars.Test;

public class Powersof3Test
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(0, Powersof3.LargestPower(3));
        Assert.AreEqual(1, Powersof3.LargestPower(4));
    }
}