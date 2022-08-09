using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class StudentRepo : IStudentRepo
    {
        private readonly UserManagementDbContext _db;
        public StudentRepo(UserManagementDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CreateStudent(Student student)
        {
            _db.Students.Add(student);
            return await SaveChanges();
        }

        public async Task<bool> DeleteStudent(Student student)
        {
            _db.Students.Remove(student);
            return await SaveChanges();
        }

        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            return await _db.Students.OrderBy(students => students.FirstName).ToListAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return (await _db.SaveChangesAsync() >= 0);
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            return await _db.Students.Where(sId => sId.Id == studentId).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateStudent(Student student)
        {
            _db.Students.Update(student);
            return await SaveChanges();
        }

        public Task<bool> StudentExists(string name)
        {
            var studentExists = _db.Students.AnyAsync(student => student.FirstName.ToLower().Trim() == name.ToLower());
            return studentExists;
        }
    }
}
