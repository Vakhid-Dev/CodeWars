public interface IProductService
{
    Task <Product> GetProductAsync (int productId);
}
