namespace CodeWars.Test._6kuy;

public class FindMissingLetterClassTest
{
    
    [Test]
    public void ExampleTests()
    {
      Assert.AreEqual('e', FindMissingLetterClass.FindMissingLetter(new [] { 'a','b','c','d','f' }));
      Assert.AreEqual('P', FindMissingLetterClass.FindMissingLetter(new [] { 'O','Q','R','S' }));
    }
}