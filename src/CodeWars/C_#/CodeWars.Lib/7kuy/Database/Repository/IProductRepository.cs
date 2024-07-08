public interface IProductRepository
{
    Task<Product> GetProductAsync(int productId);
}
