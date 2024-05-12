using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class IsPangramClassTest
{
    [Test]
    public void SampleTests() 
    {
        Assert.AreEqual(true, IsPangramClass.IsPangram("The quick brown fox jumps over the lazy dog."));
        Assert.AreEqual(false, IsPangramClass.IsPangram("aaaaaaaaaaaaaaaaaaaaaaaaaa"));
        
        
    }
}