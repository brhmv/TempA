using SchoolBus.Models.Abstracts;

namespace SchoolBus.Models.Concretes
{
    public class Ride : BaseEntity
    {

        public int CarId { get; set; }

        public virtual Car? Car { get; set; }


        public int? DriverId { get; set; }

        public virtual Driver? Driver { get; set; }

        public virtual List<Student>? Students { get; set; }
    }
}
