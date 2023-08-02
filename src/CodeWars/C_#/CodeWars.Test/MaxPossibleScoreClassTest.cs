using CodeWars.Lib;

namespace CodeWars.Test;

public class MaxPossibleScoreClassTest
{
    [Test]
    public void FixedTests()
    {
        Assert.AreEqual(1, MaxPossibleScoreClass.MaxPossibleScore(new Dictionary<object, int> { {"a", 1} }, new object[] {}));
        Assert.AreEqual(2, MaxPossibleScoreClass.MaxPossibleScore(new Dictionary<object, int> { {"a", 1} }, new object[] {"a"}));
        Assert.AreEqual(29, MaxPossibleScoreClass.MaxPossibleScore(new Dictionary<object, int> { {"a", 1}, {"b", 14} }, new object[] {"b"}));
        Assert.AreEqual(14, MaxPossibleScoreClass.MaxPossibleScore(new Dictionary<object, int> { {"a", 1}, {"b", 2}, {"c", 4} }, new object[] {"a", "b", "c"}));
        Assert.AreEqual(23, MaxPossibleScoreClass.MaxPossibleScore(new Dictionary<object, int> { {"a", 2}, {"b", 5}, {"c", 8} }, new object[] {"c"}));
    }
}