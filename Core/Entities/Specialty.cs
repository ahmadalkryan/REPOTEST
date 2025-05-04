using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class Specialty
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyName { get; set; }

          public int _studentId { get; set; }
        public Student _Student { get; set; }
    }
}
