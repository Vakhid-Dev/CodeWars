using CodeWars.Lib._5kuy;

namespace CodeWars.Test._5kuy;

public class FirstNonRepeatingLetterClassTest
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("a", FirstNonRepeatingLetterClass.FirstNonRepeatingLetter("a"));
        Assert.AreEqual("t", FirstNonRepeatingLetterClass.FirstNonRepeatingLetter("stress"));
        Assert.AreEqual("e", FirstNonRepeatingLetterClass.FirstNonRepeatingLetter("moonmen"));
    }    
}