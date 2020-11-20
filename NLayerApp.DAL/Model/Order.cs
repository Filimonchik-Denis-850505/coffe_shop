using System.Collections.Generic;

using NLayerApp.DAL.Model.Base;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Model
{
    public class Order : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public string Address { get; set; }

        public double Price { get; set; }

        public DeliveryType DeliveryTypeId { get; set; }

        public PaymentType PaymentTypeId { get; set; }

        #region Navigation properties

        public PaymentTypeEntity PaymentType { get; set; }

        public DeliveryTypeEntity DeliveryType { get; set; }
        
        public ICollection<ProductOrder> ProductOrders { get; set; }

        #endregion
    }
}