
class TrailingZerosClassTest
{

    [Test]
    public void BasicTests() 
    {
       Assert.AreEqual(1,  TrailingZerosClass.TrailingZeros(5));
       Assert.That(TrailingZerosClass.TrailingZeros(25), Is.EqualTo(6));
       Assert.That(TrailingZerosClass.TrailingZeros(531), Is.EqualTo(131));
    }
}