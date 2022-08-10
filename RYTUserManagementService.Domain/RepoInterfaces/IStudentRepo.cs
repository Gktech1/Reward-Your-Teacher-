using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IStudentRepo
    {
        Task<Student> GetStudent(int id);
        Task<Student> Save(Student input);
        Task<Student> DeleteStudent(int id);
        Task<ICollection<Student>> GetAll();
        Task<Student> UpdateStudent(int id);
      
    }
}
