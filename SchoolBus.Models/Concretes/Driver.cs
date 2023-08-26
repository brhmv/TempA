using SchoolBus.Models.Abstracts;

namespace SchoolBus.Models.Concretes
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        
        public string LastName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string License { get; set; } = null!;

        public int CarId { get; set; }
        
        public virtual Car? Car { get; set; }

        public virtual Ride? Ride { get; set; }

        public override string ToString() => $"{FirstName}";
    }
}