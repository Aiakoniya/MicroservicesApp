using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ordering.API.DTOs;
using Ordering.Core.Entitites;
using Ordering.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Ordering.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<OrderResponse>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersByUsername(string username)
        {
            var orderList = await _orderRepository.GetOrdersByUsername(username);
            //var orderResponseList = _mapper.Map<IEnumerable<OrderResponse>>(orderList);
            List<Order> orders = new List<Order>
            {
                new Order
                {
                    FirstName = "salem",
                    Username = "alem"
                }
            };
            return Ok(orders);
        }
    }
}
