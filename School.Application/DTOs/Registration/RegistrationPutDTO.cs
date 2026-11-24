using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.DTOs.Registration
{
    public class RegistrationPutDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
