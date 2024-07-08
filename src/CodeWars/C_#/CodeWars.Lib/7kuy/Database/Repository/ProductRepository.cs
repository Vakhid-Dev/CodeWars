
public class ProductRepository : IProductRepository
{
    private readonly ProductContext _productContext;

    public ProductRepository(ProductContext productContext)
    {
        _productContext = productContext;
    }

    public async Task<Product> GetProductAsync(int productId)
    {
        return await _productContext.Products.FindAsync(productId);  
    }
}