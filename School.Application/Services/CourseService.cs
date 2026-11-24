using School.Application.DTOs.Course;
using School.Application.Interfaces;
using School.Domain.Entities;
using School.Domain.Interfaces;
using System.Runtime.InteropServices;

namespace School.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<CourseGetDTO> AddAsync(CoursePostDTO coursePostDTO)
        {
            var course = new Course
            {
                Name = coursePostDTO.Name,
                Description = coursePostDTO.Description
            };
            var createdCourse = await _courseRepository.AddCourseAsync(course);
            return new CourseGetDTO
            {
                Id = createdCourse.Id,
                Name = createdCourse.Name,
                Description = createdCourse.Description
            };
        }

        public async Task<CourseGetDTO> DeleteAsync(int id)
        {
            var course = await _courseRepository.DeleteCourseAsync(id);
            if (course == null)
                throw new ArgumentException("Course not found");
            return new CourseGetDTO
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description
            };
        }

        public async Task<List<CourseGetDTO>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllCoursesAsync();
            var courseGetDTOs = new List<CourseGetDTO>();
            courseGetDTOs.AddRange(courses.Select(course => new CourseGetDTO
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description
            }));
            return courseGetDTOs;
        }

        public async Task<CourseGetDTO> GetByIdAsync(int id)
        {
            var course = await _courseRepository.GetCourseByIdAsync(id);
            if (course == null)
                throw new ArgumentException("Course not found");
            return new CourseGetDTO
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description
            };
        }

        public async Task<CourseGetDTO> UpdateAsync(CoursePutDTO coursePutDTO)
        {
            var course = new Course
            {
                Id = coursePutDTO.Id,
                Name = coursePutDTO.Name,
                Description = coursePutDTO.Description
            };
            var updatedCourse = await _courseRepository.UpdateCourseAsync(course);
            return new CourseGetDTO
            {
                Id = updatedCourse.Id,
                Name = updatedCourse.Name,
                Description = updatedCourse.Description
            };
        }
    }
}
