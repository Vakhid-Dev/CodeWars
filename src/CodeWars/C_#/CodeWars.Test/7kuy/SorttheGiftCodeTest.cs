using CodeWars.Lib;

namespace CodeWars.Test;

public class SorttheGiftCodeTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual("abcdef", SorttheGiftCode.SortGiftCode("abcdef"));
        Assert.AreEqual("kpqsuvy", SorttheGiftCode.SortGiftCode("pqksuvy"));
        Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", SorttheGiftCode.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
    }
}