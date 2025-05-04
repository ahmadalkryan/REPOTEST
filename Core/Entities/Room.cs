using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
   public  class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int studentId { get; set; }
        public virtual Student? _Student { get; set; }
    }
}
