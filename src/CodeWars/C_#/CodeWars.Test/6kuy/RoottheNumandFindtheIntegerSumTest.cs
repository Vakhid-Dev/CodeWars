using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class RoottheNumandFindtheIntegerSumTest
{
    [Test]
    public void _RootingI()
    {
        RoottheNumandFindtheIntegerSum rooter = new RoottheNumandFindtheIntegerSum();
        Assert.AreEqual(0, rooter.RootSum(0));
    }
    [Test]
    public void _RootingII()
    {
        RoottheNumandFindtheIntegerSum rooter = new RoottheNumandFindtheIntegerSum();
        Assert.AreEqual(30, rooter.RootSum2(27));
    }
    [Test]
    public void _RootingIII()
    {
        RoottheNumandFindtheIntegerSum rooter = new RoottheNumandFindtheIntegerSum();
        Assert.AreEqual(130, rooter.RootSum2(125));
    }
    [Test]
    public void _RootingIV()
    {
    RoottheNumandFindtheIntegerSum rooter = new RoottheNumandFindtheIntegerSum();
        Assert.AreEqual(78, rooter.RootSum(64));
    }
    [Test]
    public void _RootingV()
    {
       RoottheNumandFindtheIntegerSum rooter = new RoottheNumandFindtheIntegerSum();
        Assert.AreEqual(16781662, rooter.RootSum(16777216));
    }
}