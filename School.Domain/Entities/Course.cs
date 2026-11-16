using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
    public class Course 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsExcluded { get; set; }
        public ICollection<Class>? Classes { get; set; }

        
    }
}
