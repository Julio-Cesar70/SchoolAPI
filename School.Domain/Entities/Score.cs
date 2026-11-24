using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Entities
{
    public class Score
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int ScoreValue { get; set; }
        public bool IsAproved { get; set; }
        public bool IsExcluded { get; set; }
        public DateTime ScoreDate { get; set; }
        public Registration? Registration { get; set; }
    }
}
