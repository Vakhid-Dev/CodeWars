using CodeWars.Lib;

namespace CodeWars.Test;

public class FindMissingNumbersTest
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[] { -1, 0, 2, 3 }, FindMissingNumbers1.FindMissingNumbers(new int[] { -3, -2, 1, 4 }));
        Assert.AreEqual(new int[0], FindMissingNumbers1.FindMissingNumbers(new int[] { -1,0,1,2,3,4 }));
        Assert.AreEqual(new int[0], FindMissingNumbers1.FindMissingNumbers(new int[0]));      
    }
}