using CodeWars.Lib._6kuy.Arrays;

namespace CodeWars.Test._6kuy;

public class SpinWordsCLassTest
{
    
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", SpinWordsCLass.SpinWords("Welcome"));
        }
  
        [Test]
        public static void Test2()
        {  
            Assert.AreEqual("Hey wollef sroirraw", SpinWordsCLass.SpinWords("Hey fellow warriors"));
        }
  
        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", SpinWordsCLass.SpinWords("This is a test"));
        }
  
        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", SpinWordsCLass.SpinWords("This is another test"));
        }
  
        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", SpinWordsCLass.SpinWords("You are almost to the last test"));
        }
  
        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", SpinWordsCLass.SpinWords("Just kidding there is still one more"));
        }
    }
