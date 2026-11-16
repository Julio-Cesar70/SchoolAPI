using School.Domain.Entities;
using School.Domain.Interfaces;
using School.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace School.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;
        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<Course> DeleteCourseAsync(int courseId)
        {
            var course = await _context.Course.FindAsync(courseId);
            if (course == null) throw new ArgumentException("Course not found");
            course.IsExcluded = true;
            _context.Course.Update(course);
            await _context.SaveChangesAsync();
            return course;
        }
        

        public async Task<List<Course>> GetAllCoursesAsync()
        {
            return await _context.Course.ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int courseId)
        {
            var course = await _context.Course.FindAsync(courseId);
            if (course == null) throw new ArgumentException("Course not found");
            return course;
        }

        public async Task<Course> UpdateCourseAsync(Course course)
        {
            _context.Course.Update(course);
            await _context.SaveChangesAsync();
            return course;
        }
        }
    }
