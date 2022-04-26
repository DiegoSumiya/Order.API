using AutoMapper;
using Order.Application.DataContract.Request.Order;
using Order.Application.DataContract.Response.Order;
using Order.Application.Interfaces;
using Order.Domain.Interface.Services;
using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Applications
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderApplication(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }
        
        public async Task<Response> CreateAsync(CreateOrderRequest Order)
        {
            try
            {
                var orderModel = _mapper.Map<OrderModel>(Order);

                return await _orderService.CreateAsync(orderModel);
            }
            catch(Exception e)
            {

            }
        }

        public Task<Response<OrderResponse>> GetByIdAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<OrderResponse>>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null)
        {
            throw new NotImplementedException();
        }
    }
}
