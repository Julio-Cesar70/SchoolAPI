using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsExcluded { get; set; }
        public ICollection<Registration>? Registrations { get; set; }
        public Course? Course { get; set; }
    }
}
