using System;
using System.Collections.Generic;
using System.Text;
using School.Domain.Entities;

namespace School.Domain.Interfaces
{
    public interface IClassRepository
    {
        Task<Class> GetClassByIdAsync(int classId);
        Task<List<Class>> GetAllClassesAsync();
        Task<Class> AddClassAsync(Class classEntity);
        Task<Class> UpdateClassAsync(Class classEntity);
        Task<Class> DeleteClassAsync(int classId);
    }
}
