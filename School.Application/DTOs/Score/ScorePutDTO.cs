using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.DTOs.Score
{
    public class ScorePutDTO
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int ScoreValue { get; set; }
        public DateTime ScoreDate { get; set; }
    }
}
