using CodeWars.Lib;

namespace CodeWars.Test;

public class CompleteThePattern__6_Odd_LadderTest
{
    [Test]
    public void Test_3()
    {
        Assert.AreEqual("1\n333", CompleteThePattern__6_Odd_Ladder.OddLadder(4), "Nope!");
    }
}