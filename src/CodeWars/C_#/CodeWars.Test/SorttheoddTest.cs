using CodeWars.Lib;

namespace CodeWars.Test;

public class SorttheoddTest
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Sorttheodd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Sorttheodd.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        Assert.AreEqual(new int[] { }, Sorttheodd.SortArray(new int[] { }));
    }
}