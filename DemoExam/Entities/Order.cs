using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoExam.Enums;

namespace DemoExam.Entities
{
    internal class Order
    {
        [Key] public int Id { get; set; }
        [ForeignKey("ClientId")] public int ClientId { get; set; }
        [ForeignKey("EmployeeId")] public Guid EmployeeId { get; set; } 
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; } 
        public OrderStatus Status { get; set; }

        public List<Product> Products { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
        public Client Client { get; set; } = null!;

    }
}
