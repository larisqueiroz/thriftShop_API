using thriftShop_API.Data;
using thriftShop_API.Models.DAO;

namespace thriftShop_API.Repositories.Impl;

public class ProductRepository: IProductRepository
{
    public readonly ThriftShopContext _productRepository;

    public ProductRepository(ThriftShopContext productRepository)
    {
        _productRepository = productRepository;
    }
    
    public List<Product> GetAllProducts()
    {
        return _productRepository.Products.ToList();
    }
}