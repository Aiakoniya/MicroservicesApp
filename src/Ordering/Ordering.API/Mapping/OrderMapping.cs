using AutoMapper;
using Ordering.API.DTOs;
using Ordering.Core.Entitites;
using EventBusRabbitMQ.Entities;

namespace Ordering.API.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<BasketCheckoutEvent, Order>().ReverseMap();
            CreateMap<Order, OrderResponse>().ReverseMap();
        }
    }
} 
    

