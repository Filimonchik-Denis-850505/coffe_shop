using System.Collections.Generic;
using NLayerApp.DAL.Model.Base;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Model
{
    public class Order : BaseEntity<int>
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public string Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; } 
        
        public DeliveryType DeliveryId { get; set; }
        public PaymentType PaymentId { get; set; }
    }
}