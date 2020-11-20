using NLayerApp.DAL.Model.Base;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Model
{
    public class PaymentTypeEntity : BaseEntity<PaymentType>
    {
        public string Name { get; set; }
    }
}