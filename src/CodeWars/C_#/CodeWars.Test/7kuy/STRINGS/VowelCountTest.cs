using CodeWars.Lib._7kuy.STRINGS;

namespace CodeWars.Test._7kuy.STRINGS;

public class VowelCountTest
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"));
    }
}