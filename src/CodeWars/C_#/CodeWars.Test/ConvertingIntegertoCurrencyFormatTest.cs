using CodeWars.Lib;

namespace CodeWars.Test;

public class ConvertingIntegertoCurrencyFormatTest
{
    [Test]
    [TestCase(100000, ExpectedResult="100,000")]
    [TestCase(5678545, ExpectedResult="5,678,545")]
    public static string FixedTest(int price)
    {
        return ConvertingIntegertoCurrencyFormat.ToCurrency3(price);
    }
}