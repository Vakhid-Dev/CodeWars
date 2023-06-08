using CodeWars.Lib;

namespace CodeWars.Test;

public class ShowingXtoYofZ_ProductsTest
{
    [Test]
    [TestCase(1,10,30,ExpectedResult="Showing 1 to 10 of 30 Products.")]
    [TestCase(3,10,26,ExpectedResult="Showing 21 to 26 of 26 Products.")]
    [TestCase(1,10,8,ExpectedResult="Showing 1 to 8 of 8 Products.")]
    public static string FixedTest(int pageNumber, int pageSize, int totalProducts)
    {
        return ShowingXtoYofZ_Products.PaginationText(pageNumber, pageSize, totalProducts);
    }
}