using SchoolBus.Models.Abstracts;

namespace SchoolBus.Models.Concretes
{
    public class Car : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Number { get; set; } = null!;
        
        public int SeatCount { get; set; }

        public virtual Driver? Driver { get; set; }
    }
}