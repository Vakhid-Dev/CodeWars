using CodeWars.Lib;

namespace CodeWars.Test;

public class LowercasestringsinarrayTest
{
    [Test]
    public void BasicTest()
    {    
        Assert.AreEqual(new object[] { 1,"red", "green" },  Lowercasestringsinarray.ArrayLowerCase(new object[] {1, "Red", "Green" }));
    }
}