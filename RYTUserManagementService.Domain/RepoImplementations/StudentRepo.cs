using RYTUserManagementService.Domain.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class StudentRepo : IStudentRepo
    {
        private readonly IStudentRepo<Student, int> _studentRepo;

        public StudentRepo(IStudentRepo<Student, int> studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _studentRepo.FirstOrDefaultAsync(id);
        } 
        
        public async Task<Student> Save(Student input)
        {
            return await _studentRepo.InsertOrUpdateAsync(input);
        }

        public async Task<Student> DeleteStudent(int id)
        {
            return await _studentRepo.DeleteAsync(id);
        }  
        
        public async Task<ICollection<Student>> GetAll()
        {
            return await _studentRepo.GetAllListAsync();
        }

        public async Task<Student> UpdateStudent(int id)
        {
            return await _studentRepo.UpdateAsync(id);
        }


    }
}
