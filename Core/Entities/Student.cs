﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StudentAge { get; set; } = 0;

        public virtual Room? _Room { get; set; }
        public virtual Specialty? _Specialty { get; set; }
        
        
    }
}
