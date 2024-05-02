using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class TakeaTenMinutesWalkTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(true, TakeaTenMinutesWalk.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}), "should return true");
        Assert.AreEqual(false, TakeaTenMinutesWalk.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}), "should return false");
        Assert.AreEqual(false, TakeaTenMinutesWalk.IsValidWalk(new string[] {"w"}), "should return false");
        Assert.AreEqual(false, TakeaTenMinutesWalk.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"}), "should return false");
    }
}