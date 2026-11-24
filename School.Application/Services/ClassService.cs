using School.Application.DTOs.Class;
using School.Application.Interfaces;
using School.Domain.Entities;
using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<ClassGetDTO> AddAsync(ClassPostDTO classPostDTO)
        {
            var classEntity = new Class
            {
                CourseId = classPostDTO.CourseId,
                Name = classPostDTO.Name,
                Description = classPostDTO.Description
            };
            var createdClass = await _classRepository.AddClassAsync(classEntity);
            return new ClassGetDTO
            {
                Id = createdClass.Id,
                CourseId = createdClass.CourseId,
                Name = createdClass.Name,
                Description = createdClass.Description
            };
        }

        public async Task<ClassGetDTO> DeleteAsync(int id)
        {
            var classEntity = await _classRepository.DeleteClassAsync(id);
            if (classEntity == null)
                throw new ArgumentException("Class not found");

            return new ClassGetDTO
            {
                Id = classEntity.Id,
                CourseId = classEntity.CourseId,
                Name = classEntity.Name,
                Description = classEntity.Description
            };
        }

        public async Task<List<ClassGetDTO>> GetAllAsync()
        {
            var classes = await _classRepository.GetAllClassesAsync();
            var classGetDTOs = new List<ClassGetDTO>();
            foreach (var classEntity in classes)
            {
                classGetDTOs.Add(new ClassGetDTO
                {
                    Id = classEntity.Id,
                    CourseId = classEntity.CourseId,
                    Name = classEntity.Name,
                    Description = classEntity.Description
                });
            }
            return classGetDTOs;
        }

        public async Task<ClassGetDTO> GetByIdAsync(int id)
        {
            var classEntity = await _classRepository.GetClassByIdAsync(id);
            if (classEntity == null)
                throw new ArgumentException("Class not found");

            return new ClassGetDTO
            {
                Id = classEntity.Id,
                CourseId = classEntity.CourseId,
                Name = classEntity.Name,
                Description = classEntity.Description
            };
        }

        public async Task<ClassGetDTO> UpdateAsync(ClassPutDTO classPutDTO)
        {
            var classEntity = new Class
            {
                Id = classPutDTO.Id,
                CourseId = classPutDTO.CourseId,
                Name = classPutDTO.Name,
                Description = classPutDTO.Description
            };
            var updatedClass = await _classRepository.UpdateClassAsync(classEntity);
            return new ClassGetDTO
            {
                Id = updatedClass.Id,
                CourseId = updatedClass.CourseId,
                Name = updatedClass.Name,
                Description = updatedClass.Description
            };
        }
    }
}
