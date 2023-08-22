using CodeWars.Lib;

namespace CodeWars.Test;

public class SumofOddCubedNumbersTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(28, SumofOddCubedNumbers.CubeOdd(new int[] {1, 2, 3, 4}));
        Assert.AreEqual(0, SumofOddCubedNumbers.CubeOdd(new int[] {-3, -2, 2, 3}));
    }
}