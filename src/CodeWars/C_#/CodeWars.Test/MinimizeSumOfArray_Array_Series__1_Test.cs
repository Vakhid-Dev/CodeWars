using CodeWars.Lib;

namespace CodeWars.Test;

public class MinimizeSumOfArray_Array_Series__1_Test
{
    [TestCase(2, 1, 2)]
    [TestCase(22, 5, 4, 2, 3)]
    [TestCase(342, 12, 6, 10, 26, 3, 24)]
    [TestCase(74, 9, 2, 8, 7, 5, 4, 0, 6)]
    public void BasicTests(int expected, params int[] a)
    {
        Assert.That(MinimizeSumOfArray_Array_Series__1_.MinSum(a), Is.EqualTo(expected));
    }
    [Test]
    public void EmptyInput()
    {
        var a = new int[] { };
        Assert.That(MinimizeSumOfArray_Array_Series__1_.MinSum(a), Is.EqualTo(0));
    }
}