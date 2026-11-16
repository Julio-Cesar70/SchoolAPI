using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Email { get; set; } 
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public string ?Profile { get; set; }
        public bool IsExcluded { get; set; }
        public ICollection<Registration>? Registrations { get; set; } // Matricula do Usuario
    }
}
