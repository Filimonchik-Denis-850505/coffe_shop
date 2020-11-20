using NLayerApp.DAL.Model.Base;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Model
{
    public class DeliveryTypeEntity: BaseEntity<DeliveryType>
    {
        public string Name { get; set; }
    }
}