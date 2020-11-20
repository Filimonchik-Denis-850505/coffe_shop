using System;

using NLayerApp.DAL.Model.Base;

namespace NLayerApp.DAL.Model
{
    public class ProductOrder : BaseEntity<Guid>
    {
        public int ProductId { get; set; }
        
        public int OrderId { get; set; }
        
        public int Count { get; set; }
        
        #region Navigation properties

        public Product Product { get; set; }
        
        public Order Order { get; set; }

        #endregion
    }
}