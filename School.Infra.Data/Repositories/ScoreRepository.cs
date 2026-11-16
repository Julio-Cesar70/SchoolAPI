using School.Domain.Interfaces;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using School.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace School.Infra.Data.Repositories
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly ApplicationDbContext _context;

        public ScoreRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Score> AddScoreAsync(Score score)
        {
            _context.Score.Add(score);
            await _context.SaveChangesAsync();
            return score;
        }

        public async Task<Score> DeleteScoreAsync(int scoreId)
        {
            var score = await _context.Score.FindAsync(scoreId);
            if (score == null) throw new ArgumentException("Score not found");
            score.IsExcluded = true;
            _context.Score.Update(score);
            await _context.SaveChangesAsync();
            return score;
        }

        public async Task<List<Score>> GetAllScoresAsync()
        {
            return await _context.Score.ToListAsync();
        }

        public async Task<Score> GetScoreByIdAsync(int scoreId)
        {
            var score = await _context.Score.FindAsync(scoreId);
            if (score == null) throw new ArgumentException("Score not found");
            return score;
        }

        public async Task<Score> UpdateScoreAsync(Score score)
        {
            _context.Score.Update(score);
            await _context.SaveChangesAsync();
            return score;
        }
        }
    }

        