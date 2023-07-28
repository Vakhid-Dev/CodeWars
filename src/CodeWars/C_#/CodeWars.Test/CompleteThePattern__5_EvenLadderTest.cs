using CodeWars.Lib;

namespace CodeWars.Test;

public class CompleteThePattern__5_EvenLadderTest
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("22", CompleteThePattern__5_EvenLadder.Pattern(2));
        Assert.AreEqual("", CompleteThePattern__5_EvenLadder.Pattern(1));
        Assert.AreEqual("22\n4444", CompleteThePattern__5_EvenLadder.Pattern(5));
        Assert.AreEqual("", CompleteThePattern__5_EvenLadder.Pattern(0));
        Assert.AreEqual("", CompleteThePattern__5_EvenLadder.Pattern(-25));
    }
}