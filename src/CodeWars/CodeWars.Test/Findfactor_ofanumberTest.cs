using CodeWars.Lib;

namespace CodeWars.Test;

public class Findfactor_ofanumberTest
{
    [Test]
    [TestCase(54, ExpectedResult=new[]{54,27,18,9,6,3,2,1})]
    [TestCase(9, ExpectedResult=new[]{9,3,1})]
    public static int[] FixedTest(int num)
    {
        return Findfactor_ofanumber.Factors(num);
    } 
}