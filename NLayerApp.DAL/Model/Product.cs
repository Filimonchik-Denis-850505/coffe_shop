using NLayerApp.DAL.Model.Base;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Model
{
    public class Product : BaseEntity<int>
    {
        public ProductType ProductTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Weight { get; set; }

        public decimal Price { get; set; }

        #region Navigation properties

        public ProductTypeEntity ProductType { get; set; }

        #endregion
    }
}