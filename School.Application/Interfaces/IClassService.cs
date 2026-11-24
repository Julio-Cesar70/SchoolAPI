using School.Application.DTOs.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Interfaces
{
    public interface IClassService 
    {
        Task<ClassGetDTO> GetByIdAsync(int id);
        Task<List<ClassGetDTO>> GetAllAsync();
        Task<ClassGetDTO> AddAsync(ClassPostDTO classPostDTO);
        Task<ClassGetDTO> UpdateAsync(ClassPutDTO classPutDTO);
        Task<ClassGetDTO> DeleteAsync(int id);
    }
}
