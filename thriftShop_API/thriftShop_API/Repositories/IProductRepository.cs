using thriftShop_API.Models.DAO;

namespace thriftShop_API.Repositories;

public interface IProductRepository
{
    public List<Product> GetAllProducts();
}