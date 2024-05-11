using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class DigPowClassTest
{
    [Test]
    public void Test1() {
        Assert.AreEqual(1, DigPowClass.digPow(89, 1));
    }
    [Test]
    public void Test2() {
        Assert.AreEqual(-1, DigPowClass.digPow(92, 1));
    }
    [Test]
    public void Test3() {
        Assert.AreEqual(51, DigPowClass.digPow(46288, 3));
    }
}