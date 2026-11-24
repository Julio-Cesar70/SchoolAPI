using School.Application.DTOs.Registration;
using School.Application.Interfaces;
using School.Domain.Entities;
using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _registrationRepository;
        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }
        public async Task<RegistrationGetDTO> AddAsync(RegistrationPostDTO registrationPostDTO)
        {
            var registrationEntity = new Registration
            {
                UserId = registrationPostDTO.UserId,
                ClassId = registrationPostDTO.ClassId,
                RegistrationDate = registrationPostDTO.RegistrationDate,
                ExpirationDate = registrationPostDTO.ExpirationDate
            };
            var createdRegistration = await _registrationRepository.AddRegistrationAsync(registrationEntity);
            return new RegistrationGetDTO
            {
                Id = createdRegistration.Id,
                UserId = createdRegistration.UserId,
                ClassId = createdRegistration.ClassId,
                RegistrationDate = createdRegistration.RegistrationDate,
                ExpirationDate = createdRegistration.ExpirationDate
            };
        }

        public async Task<RegistrationGetDTO> DeleteAsync(int id)
        {
            var registration = await _registrationRepository.DeleteRegistrationAsync(id);
            if (registration == null)
                throw new ArgumentException("Registration not found");
            return new RegistrationGetDTO
            {
                Id = registration.Id,
                UserId = registration.UserId,
                ClassId = registration.ClassId,
                RegistrationDate = registration.RegistrationDate,
                ExpirationDate = registration.ExpirationDate
            };
        }

        public async Task<List<RegistrationGetDTO>> GetAllAsync()
        {
            var registrations = await _registrationRepository.GetAllRegistrationsAsync();
            var registrationGetDTOs = new List<RegistrationGetDTO>();
            registrationGetDTOs.AddRange(registrations.Select(registration => new RegistrationGetDTO
            {
                Id = registration.Id,
                UserId = registration.UserId,
                ClassId = registration.ClassId,
                RegistrationDate = registration.RegistrationDate,
                ExpirationDate = registration.ExpirationDate
            }));
            return registrationGetDTOs;
        }

        public async Task<RegistrationGetDTO> GetByIdAsync(int id)
        {
            var registration = await _registrationRepository.GetRegistrationByIdAsync(id);
            if (registration == null)
                throw new ArgumentException("Registration not found");
            return new RegistrationGetDTO
            {
                Id = registration.Id,
                UserId = registration.UserId,
                ClassId = registration.ClassId,
                RegistrationDate = registration.RegistrationDate,
                ExpirationDate = registration.ExpirationDate
            };
        }

        public async Task<RegistrationGetDTO> UpdateAsync(RegistrationPutDTO registrationPutDTO)
        {
            var registrationEntity = new Registration
            {
                Id = registrationPutDTO.Id,
                UserId = registrationPutDTO.UserId,
                ClassId = registrationPutDTO.ClassId,
                RegistrationDate = registrationPutDTO.RegistrationDate,
                ExpirationDate = registrationPutDTO.ExpirationDate
            };
            var updatedRegistration = await _registrationRepository.UpdateRegistrationAsync(registrationEntity);
            return new RegistrationGetDTO
            {
                Id = updatedRegistration.Id,
                UserId = updatedRegistration.UserId,
                ClassId = updatedRegistration.ClassId,
                RegistrationDate = updatedRegistration.RegistrationDate,
                ExpirationDate = updatedRegistration.ExpirationDate
            };
        }
    }
}
