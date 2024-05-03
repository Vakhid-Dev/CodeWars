using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class LikesClassTest
{
    [Test, Description("It should return correct text")]
    public void SampleTest()
    {
        Assert.AreEqual("no one likes this", LikesClass.Likes(new string[0]));
        Assert.AreEqual("Peter likes this", LikesClass.Likes(new string[] {"Peter"}));
        Assert.AreEqual("Jacob and Alex like this", LikesClass.Likes(new string[] {"Jacob", "Alex"}));
        Assert.AreEqual("Max, John and Mark like this", LikesClass.Likes(new string[] {"Max", "John", "Mark"}));
        Assert.AreEqual("Alex, Jacob and 2 others like this", LikesClass.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}));
    }
}