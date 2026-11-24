using School.Application.DTOs.User;
using School.Application.Interfaces;
using School.Domain.Entities;
using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserGetDTO> AddUserAsync(UserPostDTO userPostDTO)
        {
            var user = new User
            {
                Name = userPostDTO.Name,
                Email = userPostDTO.Email,
                Profile = userPostDTO.Profile
            };
            var createdUser = await _userRepository.AddUserAsync(user);
            return new UserGetDTO
            {
                Id = createdUser.Id,
                Name = createdUser.Name,
                Email = createdUser.Email,
                Profile = createdUser.Profile
            };
        }

        public async Task<UserGetDTO> DeleteUserAsync(int id)
        {
            var user = await _userRepository.DeleteUserAsync(id);
            if (user == null) throw new InvalidOperationException("User not found");
            return new UserGetDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Profile = user.Profile
            };
        }

        public async Task<List<UserGetDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            var userGetDTOs = new List<UserGetDTO>();
            userGetDTOs.AddRange(users.Select(user => new UserGetDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Profile = user.Profile
            }));
            return userGetDTOs;
        }

        public async Task<UserGetDTO?> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) return null;

            return new UserGetDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Profile = user.Profile
            };
        }

        public async Task<UserGetDTO> UpdateUserAsync(UserPutDTO userPutDTO)
        {
            var user = new User
            {
                Id = userPutDTO.Id,
                Name = userPutDTO.Name,
                Email = userPutDTO.Email,
                Profile = userPutDTO.Profile
            };
            var updatedUser = await _userRepository.UpdateUserAsync(user);
            return new UserGetDTO
            {
                Id = updatedUser.Id,
                Name = updatedUser.Name,
                Email = updatedUser.Email,
                Profile = updatedUser.Profile
            };
        }
    }
}
