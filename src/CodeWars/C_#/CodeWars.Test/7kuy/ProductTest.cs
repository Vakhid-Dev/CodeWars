using Moq;

public class ProductTest
{

     [Test]
    public async Task GetProductAsync_ReturnsProduct()
    {
        // Arrange
        var mockRepository = new Mock<IProductRepository>();
        var productId = 1;
        var expectedProduct = new Product { Id = productId, Name = "Laptop", Count = 10 };
        mockRepository.Setup(repo => repo.GetProductAsync(productId)).ReturnsAsync(expectedProduct);

        var productService = new ProductService(mockRepository.Object);

        // Act
        var result = await productService.GetProductAsync(productId);

        // Assert
        Assert.NotNull(result);
        Assert.AreEqual(expectedProduct.Id, result.Id);
        Assert.AreEqual(expectedProduct.Name, result.Name);
        Assert.AreEqual(expectedProduct.Count, result.Count);
    }

    [Test]
    public async Task GetProductTest()
    {
        //Arrange
        var mock = new Mock<IProductRepository>();
        var productId = 1;
        mock.Setup(x => x.GetProductAsync(productId)).ReturnsAsync( GetProduct());
        var productService = new ProductService(mock.Object);
        //Act
        var getProduct = await productService.GetProductAsync(productId);

        //Assert
        Assert.AreEqual(productId, getProduct.Id);
        Assert.AreEqual("Laptop", getProduct.Name);
        Assert.AreEqual(10, getProduct.Count);
        mock.Verify(r => r.GetProductAsync(productId));
    }
    public  Product GetProduct()
    {
        return new Product
        {
            Name = "Laptop",
            Id = 1,
            Count = 10
        };
    }
}