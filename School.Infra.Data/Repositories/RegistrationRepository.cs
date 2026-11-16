using School.Domain.Entities;
using School.Domain.Interfaces;
using School.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace School.Infra.Data.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDbContext _context;

        public RegistrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Registration> AddRegistrationAsync(Registration registration)
        {
            _context.Registration.Add(registration);
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<Registration> DeleteRegistrationAsync(int registrationId)
        {
            var registration = await _context.Registration.FindAsync(registrationId);
            if (registration == null) throw new ArgumentException("Registration not found");
            registration.IsExcluded = true;
            _context.Registration.Update(registration);
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<List<Registration>> GetAllRegistrationsAsync()
        {
            return await _context.Registration.ToListAsync();
        }

        public async Task<Registration> GetRegistrationByIdAsync(int registrationId)
        {
            var registration = await _context.Registration.FindAsync(registrationId);
            if (registration == null) throw new ArgumentException("Registration not found");
            return registration;
        }

        public async Task<Registration> UpdateRegistrationAsync(Registration registration)
        {
            _context.Registration.Update(registration);
            await _context.SaveChangesAsync();
            return registration;
        }
    }
}
