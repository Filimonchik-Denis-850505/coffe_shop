using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;
using NLayerApp.DAL.Model;
using NLayerApp.DAL.Model.Enums;
using NLayerApp.DAL.Repositories;
using NLayerApp.DLL.Interfaces;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.Services
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IRepository<Order, int> _orderRepository;
        private readonly IMapper _mapper;

        public OrderAppService(IRepository<Order, int> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        } 
    
        public async Task<OrderViewModel> CreateOrder(Order order)
        {
            await _orderRepository.Insert(order);
            return  _mapper.Map<OrderViewModel>(order);
        }
    }
}