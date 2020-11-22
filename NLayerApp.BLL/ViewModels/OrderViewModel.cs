namespace NLayerApp.DLL.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }
        
        public string Address { get; set; }
        
        public double Price { get; set; }
        
        public int DeliveryTypeId { get; set; }
        
        public int PaymentTypeId { get; set; }
    }
}