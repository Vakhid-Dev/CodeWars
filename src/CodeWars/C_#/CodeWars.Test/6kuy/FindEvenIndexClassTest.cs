using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class FindEvenIndexClassTest
{

    [Test]
    public void GenericTests()
    {
        Assert.AreEqual(0,FindEvenIndexClass.FindEvenIndex(new int[] {0,0,0,0,0}));
        Assert.AreEqual(0,FindEvenIndexClass.FindEvenIndex(new int[] {8,0}));
        Assert.AreEqual(-1,FindEvenIndexClass.FindEvenIndex(new int[] {8,8}));
        Assert.AreEqual(3,FindEvenIndexClass.FindEvenIndex(new int[] {1,2,3,4,3,2,1}));
        Assert.AreEqual(1,FindEvenIndexClass.FindEvenIndex(new int[] {1,100,50,-51,1,1}));
        Assert.AreEqual(-1,FindEvenIndexClass.FindEvenIndex(new int[] {1,2,3,4,5,6}));
        Assert.AreEqual(3,FindEvenIndexClass.FindEvenIndex(new int[] {20,10,30,10,10,15,35}));
    }
}