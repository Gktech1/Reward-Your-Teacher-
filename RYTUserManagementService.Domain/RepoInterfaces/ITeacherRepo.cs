using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface ITeacherRepo
    {
        Task<IEnumerable<Teacher>> GetAllTeachers();
        Task<Teacher> TeachertExists(int teacherId);
        Task<bool> CreateTeacher(Teacher teacher);
        Task<bool> UpdateTeacher(Teacher teacher);
        Task<bool> DeleteTeacherById(int teacherId);
        Task<bool> SaveChanges();
    }
}
