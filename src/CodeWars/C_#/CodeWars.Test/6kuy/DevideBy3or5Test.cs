using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class DevideBy3or5Test
{
    [Test]
    public void SampleTests()
    {
        Assertion(expected : 23, input : 10);
        Assertion(expected : 78, input : 20);
        Assertion(expected : 9168, input : 200);
        Assertion(expected : 0, input : 0);
    }
  
    private static void Assertion(int expected, int input) =>
        Assert.AreEqual(
            expected,
            DevideBy3or5.Solution(input),
            $"Value: {input}"
        );
}