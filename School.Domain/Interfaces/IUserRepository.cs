using System;
using System.Collections.Generic;
using System.Text;
using School.Domain.Entities;

namespace School.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<List<User>> GetAllUsersAsync();
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUserAsync(int userId);
    }
}
