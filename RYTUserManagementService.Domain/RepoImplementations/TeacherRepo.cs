using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly UserManagementDbContext _db;

        public TeacherRepo(UserManagementDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CreateTeacher(Teacher teacher)
        {
            _db.Teachers.Add(teacher);
            return await SaveChanges();
        }

        public async Task<bool> DeleteTeacher(Teacher teacher)
        {
            _db.Teachers.Remove(teacher);
            return await SaveChanges();
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            return await _db.Teachers.OrderBy(studentsName => studentsName.FirstName).ToListAsync();
        }

        public async Task<Teacher> GetTeacherById(int teacherId)
        {
            return await _db.Teachers.Where(t => t.TeacherId == teacherId).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return await _db.SaveChangesAsync() >= 0;
        }

        public Task<bool> TeacherExists(string name)
        {
            var teacherExists = _db.Teachers.AnyAsync(teacherExists => teacherExists.FirstName.ToLower().Trim() == name.ToLower());
            return teacherExists;
        }

        public Task<bool> UpdateTeacher(Teacher teacher)
        {
            _db.Teachers.Add(teacher);
            return SaveChanges();
        }
    }
}
