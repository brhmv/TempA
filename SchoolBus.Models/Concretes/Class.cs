using SchoolBus.Models.Abstracts;

namespace SchoolBus.Models.Concretes
{
    public class Class : BaseEntity
    {
        public string Name { get; set; } = null!;

        public virtual List<Student>? Students { get; set; }
    }
}