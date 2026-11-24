using School.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserGetDTO?> GetUserByIdAsync(int id);
        Task<List<UserGetDTO>> GetAllUsersAsync();
        Task<UserGetDTO> AddUserAsync(UserPostDTO userPostDTO);
        Task<UserGetDTO> UpdateUserAsync(UserPutDTO userPutDTO);
        Task<UserGetDTO> DeleteUserAsync(int id);
    }
}
