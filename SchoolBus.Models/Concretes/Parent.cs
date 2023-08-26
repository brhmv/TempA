using SchoolBus.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus.Models.Concretes
{
    public class Parent : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        
        public string PhoneNumber { get; set; } = null!;

        public virtual List<Student>? Students { get; set; }
    }
}
