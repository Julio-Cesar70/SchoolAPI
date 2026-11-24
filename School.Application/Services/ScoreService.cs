using School.Application.DTOs.Score;
using School.Application.Interfaces;
using School.Domain.Entities;
using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public async Task<ScoreGetDTO> AddAsync(ScorePostDTO scorePostDTO)
        {
            var score = new Score
            {
                RegistrationId = scorePostDTO.RegistrationId,
                ScoreValue = scorePostDTO.ScoreValue,
                ScoreDate = scorePostDTO.ScoreDate
            };
            var createdScore = await _scoreRepository.AddScoreAsync(score);
            return new ScoreGetDTO
            {
                Id = createdScore.Id,
                RegistrationId = createdScore.RegistrationId,
                ScoreValue = createdScore.ScoreValue,
                ScoreDate = createdScore.ScoreDate
            };
        }

        public async Task<ScoreGetDTO> DeleteAsync(int id)
        {
            var score = await _scoreRepository.DeleteScoreAsync(id);
            if (score == null)
                throw new ArgumentException("Score not found");
            return new ScoreGetDTO
            {
                Id = score.Id,
                RegistrationId = score.RegistrationId,
                ScoreValue = score.ScoreValue,
                ScoreDate = score.ScoreDate
            };
        }

        public async Task<List<ScoreGetDTO>> GetAllAsync()
        {
            var scores = await _scoreRepository.GetAllScoresAsync();
            var scoreGetDTOs = new List<ScoreGetDTO>();
            scoreGetDTOs.AddRange(scores.Select(score => new ScoreGetDTO
            {
                Id = score.Id,
                RegistrationId = score.RegistrationId,
                ScoreValue = score.ScoreValue,
                ScoreDate = score.ScoreDate
            }));
        }

        public async Task<ScoreGetDTO> GetByIdAsync(int id)
        {
            var score = await _scoreRepository.GetScoreByIdAsync(id);
            if (score == null)
                throw new ArgumentException("Score not found");
            return new ScoreGetDTO
            {
                Id = score.Id,
                RegistrationId = score.RegistrationId,
                ScoreValue = score.ScoreValue,
                ScoreDate = score.ScoreDate
            };
        }

        public async Task<ScoreGetDTO> UpdateAsync(ScorePutDTO scorePutDTO)
        {
            var score = new Score
            {
                Id = scorePutDTO.Id,
                RegistrationId = scorePutDTO.RegistrationId,
                ScoreValue = scorePutDTO.ScoreValue,
                ScoreDate = scorePutDTO.ScoreDate
            };
            var updatedScore = await _scoreRepository.UpdateScoreAsync(score);
            return new ScoreGetDTO
            {
                Id = updatedScore.Id,
                RegistrationId = updatedScore.RegistrationId,
                ScoreValue = updatedScore.ScoreValue,
                ScoreDate = updatedScore.ScoreDate
            };
        }
    }
}
