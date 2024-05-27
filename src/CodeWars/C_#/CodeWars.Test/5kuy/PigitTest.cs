using CodeWars.Lib._5kuy;

namespace CodeWars.Test._5kuy;

public class PigitTest {
  [Test]
  public void KataTests()
  {
    Assert.AreEqual("igPay atinlay siay oolcay", PigitClass.PigIt("Pig latin is cool"));
    Assert.AreEqual("hisTay siay ymay tringsay", PigitClass.PigIt("This is my string"));
  }
}