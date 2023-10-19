using Exemplo.Entities.Enums;

namespace Exemplo.Entities
{
    public class Order
    {
        public int Id {get; set;}
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        
        
    }
}