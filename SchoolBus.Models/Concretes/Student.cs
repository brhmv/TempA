using SchoolBus.Models.Abstracts;

namespace SchoolBus.Models.Concretes
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        
        public int ParentId { get; set; }
        
        public string Address { get; set; } = null!;
        
        public string? OtherAddress { get; set; }

        public int? RideId { get; set; } 
        
        public int ClassId { get; set; }

        public virtual Parent? Parent { get; set; }
        
        public virtual Ride? Ride { get; set; }
        
        public virtual Class? Class { get; set; }
    }
}