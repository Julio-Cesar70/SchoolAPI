using School.Domain.Entities;
using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository

    {
        public Task<User> AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
