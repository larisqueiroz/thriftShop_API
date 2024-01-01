using thriftShop_API.Models.DTO;

namespace thriftShop_API.Services;

public interface IProductService
{
    public List<ProductDto> GetAll();
}