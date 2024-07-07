using CodeWars.Lib._6kuy;

public class RevrotTest
{
    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
        Console.WriteLine("Testing RevRot");
        testing(RevrotCLass.RevRot("1234", 0), "");
        testing(RevrotCLass.RevRot("", 0), "");
        testing(RevrotCLass.RevRot("1234", 5), "");
        String s = "733049910872815764";
        testing(RevrotCLass.RevRot(s, 5), "330479108928157");
        testing(RevrotCLass.RevRot("123456779", 8), "23456771");
        testing(RevrotCLass.RevRot("664438769", 8), "67834466");
    }
}