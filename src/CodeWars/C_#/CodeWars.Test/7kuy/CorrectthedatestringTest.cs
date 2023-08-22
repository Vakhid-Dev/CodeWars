using System.Runtime.InteropServices.JavaScript;
using CodeWars.Lib;

namespace CodeWars.Test;

public class CorrectthedatestringTest
{
   [Test]
    public void NullTest()
    {
        Assert.AreEqual(null, Correctthedatestring.Correct(null));
    }
  
    [Test]
    public void EmptyTest()
    {
        Assert.AreEqual("", Correctthedatestring.Correct(""));
    }
  
    [Test]
    public void InvalidFormatTests()
    {
        Assert.AreEqual(null, Correctthedatestring.Correct("01112016"));
        Assert.AreEqual(null, Correctthedatestring.Correct("01,11,2016"));
        Assert.AreEqual(null, Correctthedatestring.Correct("0a.1c.2016"));
    } 
  
   [Test]
    public void CorrectionTests()
    {
        Assert.AreEqual("01.03.2016", Correctthedatestring.Correct("30.02.2016"));
        Assert.AreEqual("10.07.2015", Correctthedatestring.Correct("40.06.2015"));
        Assert.AreEqual("11.01.2015", Correctthedatestring.Correct("11.13.2014"));
        Assert.AreEqual("07.02.2011", Correctthedatestring.Correct("99.11.2010"));    
    }  
}