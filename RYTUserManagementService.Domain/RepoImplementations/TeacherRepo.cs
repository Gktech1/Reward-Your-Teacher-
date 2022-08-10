using RYTUserManagementService.Domain.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly ITeacherRepo<Teacher, int> _teacherRepo;

        public TeacherRepo(IStudentRepo<Teacher, int> teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        public async Task<Teacher> GetTeacher(int id)
        {
            return await _teacherRepo.FirstOrDefaultAsync(id);
        }

        public async Task<Teacher> Save(Teacher input)
        {
            return await _teacherRepo.InsertOrUpdateAsync(input);
        }

        public async Task<Teacher> DeleteTeacher(int id)
        {
            return await _teacherRepo.DeleteAsync(id);
        }

        public async Task<ICollection<Teacher>> GetAll()
        {
            return await _teacherRepo.GetAllListAsync();
        }

        public async Task<Teacher> UpdateTeacher(int id)
        {
            return await _teacherRepo.UpdateAsync(id);
        }
    }
}
