using School.Application.DTOs.Score;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Interfaces
{
    public interface IScoreService
    {
        Task<ScoreGetDTO> GetByIdAsync(int id);
        Task<List<ScoreGetDTO>> GetAllAsync();
        Task<ScoreGetDTO> AddAsync(ScorePostDTO scorePostDTO);
        Task<ScoreGetDTO> UpdateAsync(ScorePutDTO scorePutDTO);
        Task<ScoreGetDTO> DeleteAsync(int id);
    }
}
