using System;
using System.Collections.Generic;
using System.Text;
using School.Domain.Entities;

namespace School.Domain.Interfaces
{
    public interface IRegistrationRepository
    {
        Task<Registration> GetRegistrationByIdAsync(int registrationId);
        Task<List<Registration>> GetAllRegistrationsAsync();
        Task<Registration> AddRegistrationAsync(Registration registration);
        Task<Registration> UpdateRegistrationAsync(Registration registration);
        Task<Registration> DeleteRegistrationAsync(int registrationId);
    }
}
