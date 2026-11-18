using School.Domain.Entities;
using School.Domain.Interfaces;
using School.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace School.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository

    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> AddUserAsync(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUserAsync(int userId)
        {
            var user = await GetUserByIdAsync(userId);
            if (user == null) throw new ArgumentException("User not found");
            user.IsExcluded = true;
            _context.User.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            var user = await _context.User.FindAsync(userId);
            if (user == null) throw new ArgumentException("User not found");
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.User.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
