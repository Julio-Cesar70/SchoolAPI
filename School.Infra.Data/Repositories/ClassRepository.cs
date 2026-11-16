using School.Domain.Entities;
using School.Domain.Interfaces;
using School.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace School.Infra.Data.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext _context;
        public ClassRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Class> AddClassAsync(Class classEntity)
        {
            _context.Class.Add(classEntity);
            await _context.SaveChangesAsync();
            return classEntity;
        }

        public async Task<Class> DeleteClassAsync(int classId)
        {
            var classEntity = await _context.Class.FindAsync(classId);
            if (classEntity == null) throw new ArgumentException("Class not found");
            classEntity.IsExcluded = true;
            _context.Class.Update(classEntity);
            await _context.SaveChangesAsync();
            return classEntity;
        }

        public async Task<List<Class>> GetAllClassesAsync()
        {
            return await _context.Class.ToListAsync();
        }

        public async Task<Class> GetClassByIdAsync(int classId)
        {
            var classEntity = await _context.Class.FindAsync(classId);
            if (classEntity == null) throw new ArgumentException("Class not found");
            return classEntity;
        }

        public async Task<Class> UpdateClassAsync(Class classEntity)
        {
            _context.Class.Update(classEntity);
            await _context.SaveChangesAsync();
            return classEntity; 
        }
    }
}
