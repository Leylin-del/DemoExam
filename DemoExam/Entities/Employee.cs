using System.ComponentModel.DataAnnotations;

namespace DemoExam.Entities
{
    internal class Employee
    {
        [Key] public Guid Id { get; set; } 
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }

        public DateTime BirthDay { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string House { get; set; } = string.Empty;
        public string Apartment { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = null!;

    }

}
