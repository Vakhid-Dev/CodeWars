using CodeWars.Lib;

namespace CodeWars.Test;

public class NameArrayCappingTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new[] {"Expected"}, NameArrayCapping.CapMe2(new[] {"ExPeCteD"}));
    }
}