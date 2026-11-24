using School.Application.DTOs.Registration;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Interfaces
{
    public interface IRegistrationService
    {
        Task<RegistrationGetDTO> GetByIdAsync(int id);
        Task<List<RegistrationGetDTO>> GetAllAsync();
        Task<RegistrationGetDTO> AddAsync(RegistrationPostDTO registrationPostDTO);
        Task<RegistrationGetDTO> UpdateAsync(RegistrationPutDTO registrationPutDTO);
        Task<RegistrationGetDTO> DeleteAsync(int id);
    }
}
