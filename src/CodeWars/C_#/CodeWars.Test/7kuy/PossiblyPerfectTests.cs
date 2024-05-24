using CodeWars.Lib._7kuy;

namespace CodeWars.Test._7kuy;

public class PossiblyPerfectTests
{
    [TestCase("A_C_B", "ADCEB", ExpectedResult = true)]
    [TestCase("B_B", "BDC", ExpectedResult = false)]
    [TestCase("T_FFF", "FFTTT", ExpectedResult = true)]
    [TestCase("BA__", "BACC", ExpectedResult = true)]
    [TestCase("ABA_", "BACC", ExpectedResult = true)]
    [TestCase("ABC_", "BACC", ExpectedResult = false)]
    [TestCase("B_", "CA", ExpectedResult = true)]
    [TestCase("BA", "CA", ExpectedResult = false)]
    [TestCase("B", "B", ExpectedResult = true)]
    [TestCase("_T__", "TFFF", ExpectedResult = true)]
    [TestCase("_T__", "TTFT", ExpectedResult = true)]
    [TestCase("_TTT", "TTFT", ExpectedResult = false)]
    [TestCase("_TTT", "TTTT", ExpectedResult = true)]
    [TestCase("_TTT", "FFFF", ExpectedResult = true)]
    [TestCase("____", "FFFF", ExpectedResult = true)]
    public bool Sample_Cases(string key, string ans) =>
        PossiblyPerfectClass.PossiblyPerfect(key.ToCharArray().Select(x => "" + x).ToArray(), 
            ans.ToCharArray().Select(x => "" + x).ToArray());
}