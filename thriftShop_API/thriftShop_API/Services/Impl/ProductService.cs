using thriftShop_API.Models.DAO;
using thriftShop_API.Models.DTO;
using thriftShop_API.Repositories;
using AutoMapper;

namespace thriftShop_API.Services.Impl;

public class ProductService: IProductService
{
    public IProductRepository _productRepository;
    public IMapper _mapper;

    public ProductService(IMapper mapper, IProductRepository productRepository)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public List<ProductDto> GetAll()
    {
        return _mapper.Map<List<ProductDto>>(_productRepository.GetAllProducts());
    }
}