using NpgsqlTypes;

namespace NLayerApp.DLL.ViewModels
{
    public class ProductViewModel
    {
        public int ProductTypeId { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public int Weight { get; set; }
        
        public int Price { get; set; }
    }
}