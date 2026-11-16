using System;
using System.Collections.Generic;
using System.Text;
using School.Domain.Entities;

namespace School.Domain.Interfaces
{
    public interface IScoreRepository
    {
        Task<Score> GetScoreByIdAsync(int scoreId);
        Task<List<Score>> GetAllScoresAsync();
        Task<Score> AddScoreAsync(Score score);
        Task<Score> UpdateScoreAsync(Score score);
        Task<Score> DeleteScoreAsync(int scoreId);
    }
}
