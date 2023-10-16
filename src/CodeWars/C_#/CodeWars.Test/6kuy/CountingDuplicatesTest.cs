using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class CountingDuplicatesTest
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
        Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
        Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
        Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
        Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
        Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
    }
}