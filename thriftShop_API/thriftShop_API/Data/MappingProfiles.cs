using AutoMapper;
using thriftShop_API.Models.DAO;
using thriftShop_API.Models.DTO;

namespace thriftShop_API.Data;

public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<ProductDto, Product>();
        CreateMap<Product, ProductDto>();
    }
}