namespace CodeWars.Lib;

public class ShowingXtoYofZ_Products
{
    /// <summary>
    /// https://www.codewars.com/kata/545cff101288c1d2da0006fb/train/csharp
    /// </summary>
    /// <param name="pageNumber"></param>
    /// <param name="pageSize"></param>
    /// <param name="totalProducts"></param>
    /// <returns></returns>
    public static string PaginationText(int pageNumber, int pageSize, int totalProducts)
    {
        var number = totalProducts;
        var a = 1;
        var b = 0;
       
        for (int i = 0; i < pageNumber; i++)
        {
            number -= pageSize;
            
            switch (number)
            {
                case <= 0 when i==0:
                    return $"Showing {1} to {totalProducts} of {totalProducts} Products.";
                case <= 0:
                    a = b+1;
                    b = a + (pageSize+number)-1;
                    return $"Showing {a} to {b} of {totalProducts} Products.";
                default:
                    a = b+1;
                    b += pageSize;
                    break;
            }
        }
        return $"Showing {a} to {b} of {totalProducts} Products.";
    }
    
}