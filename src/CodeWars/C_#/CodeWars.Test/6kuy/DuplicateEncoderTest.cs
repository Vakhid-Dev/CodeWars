using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class DuplicateEncoderTest
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
        Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
        Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
        Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
    }
}