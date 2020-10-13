using NLayerApp.DAL.Model.Base;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Model
{
    public class ProductTypeEntity  : BaseEntity<ProductType>
    {
        public string Name { get; set; }
    }
}