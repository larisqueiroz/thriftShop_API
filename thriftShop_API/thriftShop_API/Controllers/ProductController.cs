using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using thriftShop_API.Models.DAO;
using thriftShop_API.Models.DTO;
using thriftShop_API.Services;

namespace thriftShop_API.Controllers;

[ApiController]
[Route("products")]
public class ProductController: ControllerBase
{
    public IProductService _productService;
    public IMapper _mapper;

    public ProductController(IMapper mapper, IProductService productService)
    {
        _mapper = mapper;
        _productService = productService;
    }

    [HttpGet]
    public List<ProductDto> GetAll()
    {
        return _productService.GetAll();
    }
}