using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IStudentRepo
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentById(int studentId);
        Task<bool> CreateStudent(Student student);
        Task<bool> UpdateStudent(Student student);
        Task<bool>  DeleteStudent(Student student);
        Task<bool> StudentExists(string name);
        Task<bool> SaveChanges();



    }
}
