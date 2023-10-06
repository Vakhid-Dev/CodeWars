using CodeWars.Lib._6kuy;

namespace CodeWars.Test._6kuy;

public class Findtheodd_intTest
{
    [Test]
    public void Tests()
    {
        Assert.That(Findtheodd_int.find_it ( new[] { 1,1,2 }), Is.EqualTo(2));
        Assert.That(Findtheodd_int.find_it ( new[] { 1,2,2,3,3,3,4,3,3,3,2,2,1 }), Is.EqualTo(4));
        Assert.AreEqual(5 , Findtheodd_int.find_it ( new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
    }
}