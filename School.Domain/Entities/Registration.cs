using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsExcluded { get; set; }
        public ICollection<Score>? Scores { get; set; }
        public User? User { get; set; }
        public Class? Class { get; set; }
    }
}
