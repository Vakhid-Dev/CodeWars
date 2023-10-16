using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class StopgninnipSMysdroW_Test
{
    [Test]
    public static void Test1()
    {
        Assert.AreEqual("emocleW", StopgninnipSMysdroW_.SpinWords("Welcome"));
    }
  
    [Test]
    public static void Test2()
    {  
        Assert.AreEqual("Hey wollef sroirraw", StopgninnipSMysdroW_.SpinWords("Hey fellow warriors"));
    }
  
    [Test]
    public static void Test3()
    {
        Assert.AreEqual("This is a test", StopgninnipSMysdroW_.SpinWords("This is a test"));
    }
  
    [Test]
    public static void Test4()
    {
        Assert.AreEqual("This is rehtona test", StopgninnipSMysdroW_.SpinWords("This is another test"));
    }
  
    [Test]
    public static void Test5()
    {
        Assert.AreEqual("You are tsomla to the last test", StopgninnipSMysdroW_.SpinWords("You are almost to the last test"));
    }
  
    [Test]
    public static void Test6()
    {
        Assert.AreEqual("Just gniddik ereht is llits one more", StopgninnipSMysdroW_.SpinWords("Just kidding there is still one more"));
    }
}