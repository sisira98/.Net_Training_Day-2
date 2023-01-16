using AutoMapper;
using WebApplication_AutoMapper.Contracts.v1.Response;
using WebApplication_AutoMapper.Domain;

namespace WebApplication_AutoMapper.Mapping;

public class DomainToResponseMappingProfile : Profile
{
    public DomainToResponseMappingProfile()
    {
        CreateMap<Customer, CustomerResponse>();
        CreateMap<Product, ProductResponse>();
        CreateMap<Order, OrderResponse>();
        CreateMap<OrderItem, OrderItemResponse>();
    }
}