using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class ToCamelCaseClassTest
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("theStealthWarrior",  ToCamelCaseClass.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.AreEqual("TheStealthWarrior",  ToCamelCaseClass.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
}