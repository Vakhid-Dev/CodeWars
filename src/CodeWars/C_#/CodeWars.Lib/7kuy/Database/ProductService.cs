
public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository productRepository)
    {
        _repository = productRepository;
    }
    public async Task<Product> GetProductAsync(int productId)
    {
       return await _repository.GetProductAsync(productId);
    }
}