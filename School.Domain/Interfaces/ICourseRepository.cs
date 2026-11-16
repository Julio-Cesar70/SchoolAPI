using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> GetCourseByIdAsync(int courseId);
        Task<List<Course>> GetAllCoursesAsync();
        Task<Course> AddCourseAsync(Course course);
        Task<Course> UpdateCourseAsync(Course course);
        Task<Course> DeleteCourseAsync(int courseId);
    }
}
