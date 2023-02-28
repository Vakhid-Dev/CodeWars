using CodeWars.Lib;

namespace CodeWars.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SumOfMinimums()
    {
       Assert.AreEqual(26, Arrays.SumOfMinimums(new int[3,5] { {1,2,3,4,5}, {5,6,7,8,9}, {20,21,34,56,100} }));
       Assert.AreEqual(9, Arrays.SumOfMinimums(new int[3,5] { {7,9,8,6,2 }, {6,3,5,4,3}, {5,8,7,4,5} }));
       Assert.AreEqual(76, Arrays.SumOfMinimums(new int[4,4] { {11,12,14,54}, {67,89,90,56}, {7,9,4,3}, {9,8,6,7} }));  
    }
}